using System.Text.Json;

namespace DialogEditor
{
    public partial class EditorForm : Form
    {
        private Dialog _selectedDialog;
        private StepBranch _selectedBranch;
        private DialogStep _selectedStep;
        public string LoadedDialog;

        public EditorForm()
        {
            InitializeComponent();
            pagePreference.Visible = false;
            pageSteps.Visible = false;
        }

        public void LoadOrCreateDialog()
        {
            using (var fs = new FileStream("dialogues.json", FileMode.Open))
            {
                DialogCollection dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
                foreach (Dialog dialog in dialogCollection.Dialogs)
                {
                    if (dialog.NameDialog == LoadedDialog)
                    {
                        _selectedDialog = dialog;
                        break;
                    }
                }
                if (_selectedDialog == null)
                {
                    _selectedDialog = new Dialog(LoadedDialog);
                    _selectedDialog.StepBranches.Add(new StepBranch("Main"));
                }
            }

            AutoFill();
        }

        private void AutoFill()
        {
            labelDialog.Text = _selectedDialog.NameDialog;
            // Стили
            dialogStyles.Items.Add("Main");
            dialogStyles.Items.Add("SubMain");
            dialogStyles.Items.Add("BigPicture");
            dialogStyles.Text = dialogStyles.Items[(int)_selectedDialog.StyleOfDialog].ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DialogCollection dialogCollection;

            // Проверяем существование файла
            if (!File.Exists("dialogues.json") || new FileInfo("dialogues.json").Length == 0)
                dialogCollection = new DialogCollection();
            else
            {
                using (var fs = new FileStream("dialogues.json", FileMode.Open))
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

            bool copyFind = false;
            // Ищем копию
            for (int i = 0; i < dialogCollection.Dialogs.Count; i++)
            {
                if (dialogCollection.Dialogs[i].NameDialog == _selectedDialog.NameDialog)
                {
                    dialogCollection.Dialogs[i] = _selectedDialog;
                    copyFind = true;
                    break;
                }
            }

            if (!copyFind)
                dialogCollection.Dialogs.Add(_selectedDialog);

            using (var fs = new FileStream("dialogues.json", FileMode.Create)) // Открываем файл для записи
                JsonSerializer.Serialize(fs, dialogCollection);
        }

        private void dialogStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedDialog.StyleOfDialog = (Dialog.DialogStyle)dialogStyles.SelectedIndex;
        }

        private void buttonPageFirst_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = true;
            pageSteps.Visible = false;
            checkCanMove.Checked = _selectedDialog.CanMove;
            checkCanInter.Checked = _selectedDialog.CanInter;
            checkMoreRead.Checked = _selectedDialog.MoreRead;
        }

        private void buttonPageDialog_Click(object sender, EventArgs e)
        {
            pagePreference.Visible = false;
            pageSteps.Visible = true;
            _selectedBranch = _selectedDialog.StepBranches[0];
            comboBoxSelectedBranch.Text = _selectedBranch.BranchName;
            UpdateBranchesUi();
            UpdateStepsUi();
            dialogStepManage.Visible = true;
            dialogStepPreference.Visible = false;
        }

        private void UpdateBranchesUi()
        {
            comboBoxSelectedBranch.Items.Clear();
            foreach (StepBranch branch in _selectedDialog.StepBranches)
                comboBoxSelectedBranch.Items.Add(branch.BranchName);
        }

        private void UpdateStepsUi()
        {
            comboBoxSelectedStep.Items.Clear();
            foreach (DialogStep step in _selectedBranch.DialogSteps)
                comboBoxSelectedStep.Items.Add(step.StepName);
        }

        private void buttonAddBranch_Click(object sender, EventArgs e)
        {
            if (!comboBoxSelectedBranch.Items.Contains(_selectedDialog.GetBranchByName(comboBoxSelectedBranch.Text)))
            {
                _selectedDialog.StepBranches.Add(new StepBranch(comboBoxSelectedBranch.Text));
                UpdateBranchesUi();
                UpdateStepsUi();
            }
        }

        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            _selectedStep = new DialogStep(comboBoxSelectedStep.Items.Count.ToString());
            _selectedStep.DialogText = new LanguageSetting();
            _selectedBranch.DialogSteps.Add(_selectedStep);
            UpdateStepsUi();
        }

        private void comboBoxSelectedBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedBranch = _selectedDialog.GetBranchByName(comboBoxSelectedBranch.Text);
        }


        private void checkCanMove_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.CanMove = checkCanMove.Checked;

        private void checkCanInter_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.CanInter = checkCanInter.Checked;

        private void checkMoreRead_CheckedChanged(object sender, EventArgs e) =>
            _selectedDialog.MoreRead = checkMoreRead.Checked;

        private void comboBoxSelectedStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Для изменяемой ссылки
            _selectedStep = _selectedBranch.GetDialogStepByName(comboBoxSelectedStep.Text);
            textBoxNpcName.Text = _selectedStep.TotalNpcName;
            textBoxRu.Text = _selectedStep.DialogText.ru;
            textBoxEn.Text = _selectedStep.DialogText.en;
            dialogStepManage.Visible = true;
            dialogStepPreference.Visible = false;
        }

        private void buttonSaveDialog_Click(object sender, EventArgs e)
        {
            _selectedStep.TotalNpcName = textBoxNpcName.Text;
            _selectedStep.DialogText = new LanguageSetting(textBoxRu.Text, textBoxEn.Text);
        }

        private void buttonDialogStep_Click(object sender, EventArgs e)
        {
            dialogStepManage.Visible = true;
            dialogStepPreference.Visible = false;
        }

        private void buttonDialogStepPref_Click(object sender, EventArgs e)
        {
            dialogStepManage.Visible = false;
            dialogStepPreference.Visible = true;
        }
    }
}