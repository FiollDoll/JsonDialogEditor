using System.Text.Json;

namespace DialogEditor
{
    public partial class EditorForm : Form
    {
        private Dialog _selectedDialog;
        public string LoadedDialog;
        public bool NewDialog;

        public EditorForm()
        {
            InitializeComponent();
        }

        public void LoadOrCreateDialog()
        {
            if (NewDialog)
                _selectedDialog = new Dialog(LoadedDialog);
            else
            {
                using (var fs = new FileStream("dialogues.json", FileMode.Open))
                {
                    DialogCollection dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);

                    foreach (Dialog dialog in dialogCollection.Dialogs)
                    {
                        Console.WriteLine(dialog.NameDialog);
                        if (dialog.NameDialog == LoadedDialog)
                        {
                            _selectedDialog = dialog;
                            break;
                        }
                    }
                }
            }

            AutoFill();
        }

        public void AutoFill()
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
    }
}