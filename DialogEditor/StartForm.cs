namespace DialogEditor;

using System.Text.Json;

public partial class StartForm : Form
{
    private string _pathToFile;

    public StartForm()
    {
        InitializeComponent();
        StreamReader fileWithPath = new StreamReader("path.txt");
        _pathToFile = fileWithPath.ReadLine();
        fileWithPath.Close();
        if (_pathToFile == null) return;
        UpdateListDialogs();
    }

    private void UpdateListDialogs()
    {
        // Вставляем все существующие диалоги
        using (var fs = new FileStream(_pathToFile, FileMode.Open))
        {
            DialogCollection dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
            foreach (Dialog dialog in dialogCollection.Dialogs)
                comboBox1.Items.Add(dialog.NameDialog);
        }
    }
    
    private void buttonLoad_Click(object sender, EventArgs e)
    {
        if (_pathToFile == null) return;
        // Выбираем какой-либо из текстов
        string dialogName = "";

        if (textBox1.Text != "")
            dialogName = textBox1.Text;
        if (comboBox1.Text != "")
            dialogName = comboBox1.Text;

        if (dialogName != "")
        {
            EditorForm editorForm = new EditorForm();
            editorForm.Show();
            editorForm.Location = this.Location;
            editorForm.LoadedDialog = dialogName;
            editorForm.PathToFile = _pathToFile;
            editorForm.LoadOrCreateDialog();
        }
        else
            MessageBox.Show("Вы не ввели название файла");
    }

    private void buttonLoadJson_Click(object sender, EventArgs e)
    {
    }

    private void buttonJsonSet_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _pathToFile = openFileDialog.FileName;
                using (StreamWriter sw = File.AppendText("path.txt")) 
                    sw.Write(openFileDialog.FileName);
            }

            UpdateListDialogs();
        }
    }
}