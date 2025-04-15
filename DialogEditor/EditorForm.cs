using System.Text.Json;
using System.Globalization;

namespace DialogEditor
{
    public partial class EditorForm : Form
    {
        /// <summary>
        /// Выбранный диалог
        /// </summary>
        private Dialog _selectedDialog;

        /// <summary>
        /// Выбранная ветка диалога
        /// </summary>
        private StepBranch _selectedBranch;

        /// <summary>
        /// Выбранный шаг диалога
        /// </summary>
        private DialogStep _selectedStep;

        /// <summary>
        /// Выбранный выбор
        /// </summary>
        private DialogChoice _selectedChoice;

        /// <summary>
        /// Название диалога. Происходит из StartForm
        /// </summary>
        public string LoadedDialog;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string PathToFile;

        public EditorForm()
        {
            InitializeComponent();
            pagePreference.Visible = false;
            pageSteps.Visible = false;
            for (int i = 0; i < 8; i++)
                comboBoxMood.Items.Add(((IconMood)i).ToString());
        }

        /// <summary>
        /// Загружает класс по LoadedDialog, если он есть, создает, если его нету.
        /// </summary>
        public void LoadOrCreateDialog()
        {
            using (var fs = new FileStream(PathToFile, FileMode.Open))
            {
                DialogCollection dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
                // Ищем
                foreach (Dialog dialog in dialogCollection.Dialogs)
                {
                    if (dialog.nameDialog == LoadedDialog)
                    {
                        _selectedDialog = dialog;
                        break;
                    }
                }

                // Если не нашли - создаем
                if (_selectedDialog == null)
                {
                    _selectedDialog = new Dialog(LoadedDialog);
                    _selectedDialog.stepBranches.Add(new StepBranch("Main"));
                }
            }

            AutoFill();
        }

        /// <summary>
        /// Сохранение класса Dialog в DialogCollection, а после и в json
        /// </summary>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DialogCollection dialogCollection;

            // Проверяем существование файла
            if (!File.Exists(PathToFile) || new FileInfo(PathToFile).Length == 0)
                dialogCollection = new DialogCollection();
            else
            {
                using (var fs = new FileStream(PathToFile, FileMode.Open))
                {
                    try
                    {
                        dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine(ex.Message);
                        dialogCollection = new DialogCollection();
                    }
                }
            }

            // Ищем копию для обновления
            bool copyFind = false;

            for (int i = 0; i < dialogCollection.Dialogs.Count; i++)
            {
                if (dialogCollection.Dialogs[i].nameDialog == _selectedDialog.nameDialog)
                {
                    dialogCollection.Dialogs[i] = _selectedDialog;
                    copyFind = true;
                    break;
                }
            }

            // Если копии нету - значит это новый диалог
            if (!copyFind)
                dialogCollection.Dialogs.Add(_selectedDialog);

            using (var fs = new FileStream(PathToFile, FileMode.Create)) // Открываем файл для записи
                JsonSerializer.Serialize(fs, dialogCollection);
        }

        /// <summary>
        /// Сохраняем шаг диалога
        /// </summary>
        private void buttonSaveDialog_Click(object sender, EventArgs e)
        {
            _selectedStep.totalNpcName = textBoxNpcName.Text;
            if (_selectedStep.totalNpcName == "")
                _selectedStep.totalNpcName = "nothing";
            _selectedStep.dialogText = new LanguageSetting(textBoxRu.Text, textBoxEn.Text);
            _selectedStep.iconMoodSelected = (IconMood)comboBoxMood.SelectedIndex;
            _selectedStep.bigPictureName = textBoxBigPicture.Text;

            if (_selectedStep.fastChanges == null)
                _selectedStep.fastChanges = new FastChangesController();
            _selectedStep.cursedText = checkBoxCursedText.Checked;
            _selectedStep.fastChanges.activateDialog = textBoxNewDialog.Text;
            _selectedStep.fastChanges.moveToLocation = textBoxNewLocation.Text;
            _selectedStep.fastChanges.moveToLocationSpawn = textBoxLocationSpawn.Text;
            _selectedStep.fastChanges.blockPlayerMove = checkBoxBlockMove.Checked;
            _selectedStep.fastChanges.blockPlayerMoveZ = checkBoxBlockMoveZ.Checked;
            _selectedStep.fastChanges.lockAllMenu = checkBoxBlockAllMenu.Checked;
            _selectedStep.fastChanges.addItem = new List<string>();
            _selectedStep.fastChanges.addNote = new List<string>();
            _selectedStep.fastChanges.changeRelationships = new List<FastChangesController.ChangeRelationship>();
            foreach (var t in textBoxAddItem.Lines)
                _selectedStep.fastChanges.addItem.Add(t);
            foreach (var t in textBoxAddNote.Lines)
                _selectedStep.fastChanges.addNote.Add(t);
            foreach (var t in textBoxChangeRelationship.Lines)
            {
                _selectedStep.fastChanges.changeRelationships.Add(
                    new FastChangesController.ChangeRelationship(t.Split(" ")[0],
                        float.Parse(t.Split(" ")[1], CultureInfo.InvariantCulture)));
            }
        }

        #region Brahcnes

        /// <summary>
        /// Добавление новой ветки
        /// </summary>
        private void buttonAddBranch_Click(object sender, EventArgs e)
        {
            if (!comboBoxSelectedBranch.Items.Contains(comboBoxSelectedBranch.Text))
            {
                _selectedDialog.stepBranches.Add(new StepBranch(comboBoxSelectedBranch.Text));
                UpdateBranchesUi();
            }
            else
                MessageBox.Show("Такая ветка уже существует");
        }

        /// <summary>
        /// Выбираем ветку
        /// </summary>
        private void comboBoxSelectedBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedBranch = _selectedDialog.GetBranchByName(comboBoxSelectedBranch.Text);
            UpdateBranchesUi();
            comboBoxSelectedStep.Text = "";
            comboBoxChoice.Text = "";
        }

        #endregion

        #region Steps

        /// <summary>
        /// Добавление нового шага
        /// </summary>
        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            _selectedStep = new DialogStep(comboBoxSelectedStep.Items.Count.ToString());
            _selectedStep.dialogText = new LanguageSetting();
            _selectedBranch.dialogSteps.Add(_selectedStep);
            UpdateStepsUi();
            UpdateStep();
        }

        /// <summary>
        /// Удаление выбранного шага
        /// </summary>
        private void buttonRemoveStep_Click(object sender, EventArgs e)
        {
            // Меняем индекс(имя)
            foreach (DialogStep step in _selectedBranch.dialogSteps)
            {
                if (int.Parse(_selectedStep.stepName) < int.Parse(step.stepName))
                    step.stepName = (int.Parse(step.stepName) - 1).ToString();
            }

            _selectedBranch.dialogSteps.Remove(_selectedStep);
            buttonLastStep_Click(sender, e);
            UpdateStepsUi();
            UpdateStep();
        }

        /// <summary>
        /// Выбираем шаг диалога
        /// </summary>
        private void comboBoxSelectedStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Для изменяемой ссылки
            _selectedStep = _selectedBranch.GetDialogStepByName(comboBoxSelectedStep.Text);
            UpdateStep();
        }

        /// <summary>
        /// Быстрое переключение шага на +1
        /// </summary>
        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectedStep.SelectedIndex < comboBoxSelectedStep.Items.Count - 1)
            {
                comboBoxSelectedStep.Text =
                    comboBoxSelectedStep.Items[comboBoxSelectedStep.SelectedIndex + 1].ToString();
                _selectedStep = _selectedBranch.GetDialogStepByName(comboBoxSelectedStep.Text);
                UpdateStep();
            }
        }

        /// <summary>
        /// Быстрое переключение шага на -1
        /// </summary>
        private void buttonLastStep_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectedStep.SelectedIndex > 0)
            {
                comboBoxSelectedStep.Text =
                    comboBoxSelectedStep.Items[comboBoxSelectedStep.SelectedIndex - 1].ToString();
                _selectedStep = _selectedBranch.GetDialogStepByName(comboBoxSelectedStep.Text);
                UpdateStep();
            }
        }

        #endregion

        #region DialogChoices

        private void buttonChoiceAdd_Click(object sender, EventArgs e)
        {
            _selectedChoice = new DialogChoice(_selectedBranch.choices.Count.ToString());
            _selectedChoice.textQuestion = new LanguageSetting();
            _selectedBranch.choices.Add(_selectedChoice);
            comboBoxChoice.Text = _selectedChoice.choiceName;
            UpdateBranchesUi();
            UpdateChoicesUi();
            UpdateChoices();
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedChoice = _selectedBranch.GetDialogChoiceByName(comboBoxChoice.Text);
            UpdateChoices();
        }

        private void buttonSaveChoice_Click_1(object sender, EventArgs e)
        {
            if (_selectedChoice != null)
            {
                _selectedChoice.textQuestion.ru = textBoxQuestionRu.Text;
                _selectedChoice.textQuestion.en = textBoxQuestionEn.Text;
                _selectedChoice.nameNewBranch = comboBoxBranchesToChoice.Text;
                _selectedChoice.moreRead = checkBoxChoiceMoreRead.Checked;
            }
        }

        #endregion

        #region ParamsToDialog

        private void checkCanMove_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.canMove = checkCanMove.Checked;

        private void checkCanInter_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.canInter = checkCanInter.Checked;

        private void checkMoreRead_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.moreRead = checkMoreRead.Checked;

        /// <summary>
        /// Меняем стиль диалога
        /// </summary>
        private void dialogStyles_SelectedIndexChanged(object sender, EventArgs e) =>
            _selectedDialog.styleOfDialog = (Dialog.DialogStyle)dialogStyles.SelectedIndex;

        #endregion

        #region ManagePages

        /// <summary>
        /// Открытие первой страницы диалога(настройки)
        /// </summary>
        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = true;
            pageSteps.Visible = false;
            checkCanMove.Checked = _selectedDialog.canMove;
            checkCanInter.Checked = _selectedDialog.canInter;
            checkMoreRead.Checked = _selectedDialog.moreRead;
        }

        private void ManagePagesStep(bool stepManagePage, bool stepPreferencePage, bool stepChoicePage)
        {
            dialogStepManage.Visible = stepManagePage;
            dialogStepPreference.Visible = stepPreferencePage;
            pageChoice.Visible = stepChoicePage;
        }

        /// <summary>
        /// Открытие страницы диалога(Основа)
        /// </summary>
        private void buttonPageDialog_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = false;
            pageSteps.Visible = true;
            _selectedBranch = _selectedDialog.stepBranches[0];
            comboBoxSelectedBranch.Text = _selectedBranch.branchName;
            ManagePagesStep(true, false, false);
            UpdateBranchesUi();
            UpdateStepsUi();
        }

        /// <summary>
        /// Переключаем страницу в шагах диалогов на основу
        /// </summary>
        private void buttonDialogStep_Click(object sender, EventArgs e) => ManagePagesStep(true, false, false);

        /// <summary>
        /// Переключаем страницу в шагах диалогов на выбор
        /// </summary>
        private void buttonChoice_Click(object sender, EventArgs e) => ManagePagesStep(false, false, true);

        /// <summary>
        /// Переключаем страницу в шагах диалогов на настройки
        /// </summary>
        private void buttonDialogStepPref_Click(object sender, EventArgs e) => ManagePagesStep(false, true, false);

        #endregion

        #region UpdateUI

        /// <summary>
        /// Обновляем список веток
        /// </summary>
        private void UpdateBranchesUi()
        {
            comboBoxSelectedBranch.Items.Clear();
            comboBoxBranchesToChoice.Items.Clear();
            foreach (StepBranch branch in _selectedDialog.stepBranches)
            {
                comboBoxSelectedBranch.Items.Add(branch.branchName);
                comboBoxBranchesToChoice.Items.Add(branch.branchName);
            }
            
            UpdateStepsUi();
            UpdateChoicesUi();
        }

        /// <summary>
        /// Обновляем список шагов в ветке
        /// </summary>
        private void UpdateStepsUi()
        {
            comboBoxSelectedStep.Items.Clear();
            foreach (DialogStep step in _selectedBranch.dialogSteps)
                comboBoxSelectedStep.Items.Add(step.stepName);
        }
        
        /// <summary>
        /// Обновляем список выборов в ветке
        /// </summary>
        private void UpdateChoicesUi()
        {
            comboBoxChoice.Items.Clear();
            foreach (DialogChoice choice in _selectedBranch.choices)
                comboBoxChoice.Items.Add(choice.choiceName);
        }

        /// <summary>
        /// Обновляем страницу шага
        /// </summary>
        private void UpdateStep()
        {
            comboBoxSelectedStep.Text = _selectedStep.stepName;
            textBoxNpcName.Text = _selectedStep.totalNpcName;
            if (textBoxNpcName.Text == "nothing")
                textBoxNpcName.Text = "";
            comboBoxMood.Text = _selectedStep.iconMoodSelected.ToString();
            textBoxRu.Text = _selectedStep.dialogText.ru;
            textBoxEn.Text = _selectedStep.dialogText.en;
            textBoxBigPicture.Text = _selectedStep.bigPictureName;
            if (_selectedStep.fastChanges != null)
            {
                checkBoxCursedText.Checked = _selectedStep.cursedText;
                textBoxNewDialog.Text = _selectedStep.fastChanges.activateDialog;
                textBoxNewLocation.Text = _selectedStep.fastChanges.moveToLocation;
                textBoxLocationSpawn.Text = _selectedStep.fastChanges.moveToLocationSpawn;
                checkBoxBlockMove.Checked = _selectedStep.fastChanges.blockPlayerMove;
                checkBoxBlockMoveZ.Checked = _selectedStep.fastChanges.blockPlayerMoveZ;
                checkBoxBlockAllMenu.Checked = _selectedStep.fastChanges.lockAllMenu;
                foreach (var t in _selectedStep.fastChanges.addItem)
                    textBoxAddItem.Text += t + "\n";
                foreach (var t in _selectedStep.fastChanges.addNote)
                    textBoxAddNote.Text += t + "\n";
                foreach (var t in _selectedStep.fastChanges.changeRelationships)
                    textBoxChangeRelationship.Text = t.npcName + " " + t.valueChange;
            }

            dialogStepManage.Visible = true;
            dialogStepPreference.Visible = false;
            pageChoice.Visible = false;
        }

        private void UpdateChoices()
        {
            textBoxQuestionRu.Text = _selectedChoice.textQuestion.ru;
            textBoxQuestionEn.Text = _selectedChoice.textQuestion.en;
            checkBoxChoiceMoreRead.Checked = _selectedChoice.moreRead;
            UpdateBranchesUi();
            dialogStepManage.Visible = false;
            dialogStepPreference.Visible = false;
            pageChoice.Visible = true;
        }

        /// <summary>
        /// Автоматическое обновление UI
        /// </summary>
        private void AutoFill()
        {
            labelDialog.Text = _selectedDialog.nameDialog;
            // Стили
            dialogStyles.Items.Add("Main");
            dialogStyles.Items.Add("SubMain");
            dialogStyles.Items.Add("BigPicture");
            dialogStyles.Text = dialogStyles.Items[(int)_selectedDialog.styleOfDialog].ToString();
        }

        #endregion

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();

        private void buttonDeleteDialog_Click(object sender, EventArgs e)
        {
            DialogCollection dialogCollection;
            using (var fs = new FileStream(PathToFile, FileMode.Open))
            {
                try
                {
                    dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
                }
                catch (JsonException ex)
                {
                    Console.WriteLine(ex.Message);
                    dialogCollection = new DialogCollection();
                }
            }

            for (int i = 0; i < dialogCollection.Dialogs.Count; i++)
            {
                if (dialogCollection.Dialogs[i].nameDialog == _selectedDialog.nameDialog)
                {
                    dialogCollection.Dialogs.Remove(dialogCollection.Dialogs[i]);
                    break;
                }
            }

            using (var fs = new FileStream(PathToFile, FileMode.Create)) // Открываем файл для записи
                JsonSerializer.Serialize(fs, dialogCollection);
            this.Close();
        }
    }
}