using System.Text.Json;

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
                    if (dialog.NameDialog == LoadedDialog)
                    {
                        _selectedDialog = dialog;
                        break;
                    }
                }

                // Если не нашли - создаем
                if (_selectedDialog == null)
                {
                    _selectedDialog = new Dialog(LoadedDialog);
                    _selectedDialog.StepBranches.Add(new StepBranch("Main"));
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
                if (dialogCollection.Dialogs[i].NameDialog == _selectedDialog.NameDialog)
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
        /// Сохраняем диалог(основу)
        /// </summary>
        private void buttonSaveDialog_Click(object sender, EventArgs e)
        {
            _selectedStep.TotalNpcName = textBoxNpcName.Text;
            if (_selectedStep.TotalNpcName == "")
                _selectedStep.TotalNpcName = "nothing";
            _selectedStep.DialogText = new LanguageSetting(textBoxRu.Text, textBoxEn.Text);
            _selectedStep.IconMoodSelected = (IconMood)comboBoxMood.SelectedIndex;
        }

        #region Brahcnes

        /// <summary>
        /// Добавление новой ветки
        /// </summary>
        private void buttonAddBranch_Click(object sender, EventArgs e)
        {
            if (!comboBoxSelectedBranch.Items.Contains(comboBoxSelectedBranch.Text))
            {
                _selectedDialog.StepBranches.Add(new StepBranch(comboBoxSelectedBranch.Text));
                UpdateBranchesUi();
                UpdateStepsUi();
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
        }

        #endregion

        #region Steps

        /// <summary>
        /// Добавление нового шага
        /// </summary>
        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            _selectedStep = new DialogStep(comboBoxSelectedStep.Items.Count.ToString());
            _selectedStep.DialogText = new LanguageSetting();
            _selectedBranch.DialogSteps.Add(_selectedStep);
            UpdateStepsUi();
            UpdateStep();
        }
        
        /// <summary>
        /// Удаление выбранного шага
        /// </summary>
        private void buttonRemoveStep_Click(object sender, EventArgs e)
        {
            // Меняем индекс(имя)
            foreach (DialogStep step in _selectedBranch.DialogSteps)
            {
                if (int.Parse(_selectedStep.StepName) < int.Parse(step.StepName))
                    step.StepName = (int.Parse(step.StepName) - 1).ToString();
            }
            _selectedBranch.DialogSteps.Remove(_selectedStep);
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

        #region ParamsToDialog

        private void checkCanMove_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.CanMove = checkCanMove.Checked;

        private void checkCanInter_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.CanInter = checkCanInter.Checked;

        private void checkMoreRead_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.MoreRead = checkMoreRead.Checked;

        private void checkBoxCursedText_CheckedChanged(object sender, EventArgs e) =>
            _selectedStep.CursedText = checkBoxCursedText.Checked;

        /// <summary>
        /// Меняем стиль диалога
        /// </summary>
        private void dialogStyles_SelectedIndexChanged(object sender, EventArgs e) =>
            _selectedDialog.StyleOfDialog = (Dialog.DialogStyle)dialogStyles.SelectedIndex;

        #endregion

        #region ManagePages

        /// <summary>
        /// Открытие первой страницы диалога(настройки)
        /// </summary>
        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = true;
            pageSteps.Visible = false;
            checkCanMove.Checked = _selectedDialog.CanMove;
            checkCanInter.Checked = _selectedDialog.CanInter;
            checkMoreRead.Checked = _selectedDialog.MoreRead;
        }

        private void ManagePagesStep(bool stepManagePage, bool stepPreferencePage)
        {
            dialogStepManage.Visible = stepManagePage;
            dialogStepPreference.Visible = stepPreferencePage;
        }

        /// <summary>
        /// Открытие страницы диалога(Основа)
        /// </summary>
        private void buttonPageDialog_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = false;
            pageSteps.Visible = true;
            _selectedBranch = _selectedDialog.StepBranches[0];
            comboBoxSelectedBranch.Text = _selectedBranch.BranchName;
            ManagePagesStep(true, false);
            UpdateBranchesUi();
            UpdateStepsUi();
        }

        /// <summary>
        /// Переключаем страницу в шагах диалогов на основу
        /// </summary>
        private void buttonDialogStep_Click(object sender, EventArgs e) => ManagePagesStep(true, false);

        /// <summary>
        /// Переключаем страницу в шагах диалогов на настройки
        /// </summary>
        private void buttonDialogStepPref_Click(object sender, EventArgs e) => ManagePagesStep(false, true);

        #endregion

        #region UpdateUI

        /// <summary>
        /// Обновляем список веток
        /// </summary>
        private void UpdateBranchesUi()
        {
            comboBoxSelectedBranch.Items.Clear();
            foreach (StepBranch branch in _selectedDialog.StepBranches)
                comboBoxSelectedBranch.Items.Add(branch.BranchName);
        }

        /// <summary>
        /// Обновляем список шагов в ветке
        /// </summary>
        private void UpdateStepsUi()
        {
            comboBoxSelectedStep.Items.Clear();
            foreach (DialogStep step in _selectedBranch.DialogSteps)
                comboBoxSelectedStep.Items.Add(step.StepName);
        }

        /// <summary>
        /// Обновляем страницу шага
        /// </summary>
        private void UpdateStep()
        {
            comboBoxSelectedStep.Text = _selectedStep.StepName;
            textBoxNpcName.Text = _selectedStep.TotalNpcName;
            if (textBoxNpcName.Text == "nothing")
                textBoxNpcName.Text = "";
            comboBoxMood.Text = _selectedStep.IconMoodSelected.ToString();
            textBoxRu.Text = _selectedStep.DialogText.ru;
            textBoxEn.Text = _selectedStep.DialogText.en;
            dialogStepManage.Visible = true;
            dialogStepPreference.Visible = false;
        }

        /// <summary>
        /// Автоматическое обновление UI
        /// </summary>
        private void AutoFill()
        {
            labelDialog.Text = _selectedDialog.NameDialog;
            // Стили
            dialogStyles.Items.Add("Main");
            dialogStyles.Items.Add("SubMain");
            dialogStyles.Items.Add("BigPicture");
            dialogStyles.Text = dialogStyles.Items[(int)_selectedDialog.StyleOfDialog].ToString();
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
                if (dialogCollection.Dialogs[i].NameDialog == _selectedDialog.NameDialog)
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