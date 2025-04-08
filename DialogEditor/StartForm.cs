namespace DialogEditor;

using System.Text.Json;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
        // Вставляем все существующие диалоги
        using (var fs = new FileStream("dialogues.json", FileMode.Open))
        {
            DialogCollection dialogCollection = JsonSerializer.Deserialize<DialogCollection>(fs);
            foreach (Dialog dialog in dialogCollection.Dialogs)
                comboBox1.Items.Add(dialog.NameDialog);
        }
    }
    
    private void buttonLoad_Click(object sender, EventArgs e)
    {
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
            editorForm.LoadedDialog = dialogName;
            editorForm.LoadOrCreateDialog();
            this.Hide();
        }
        else
            MessageBox.Show("Вы не ввели название файла");
    }

    private void buttonLoadJson_Click(object sender, EventArgs e)
    {
    }
}