namespace DialogEditor;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        EditorForm editorForm = new EditorForm();
        editorForm.Show();
        editorForm.loadedDialog = "";
        editorForm.LoadOrCreateDialog();
        this.Hide();
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
        if (textBox1.Text != "")
        {
            EditorForm editorForm = new EditorForm();
            editorForm.Show();
            editorForm.loadedDialog = textBox1.Text;
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