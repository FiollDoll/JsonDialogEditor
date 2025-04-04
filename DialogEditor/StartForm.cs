namespace DialogEditor;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
    }

    private void CreateOrEdit(bool edit)
    {
        if (textBox1.Text != "")
        {
            EditorForm editorForm = new EditorForm();
            editorForm.Show();
            editorForm.LoadedDialog = textBox1.Text;
            editorForm.NewDialog = !edit;
            editorForm.LoadOrCreateDialog();
            this.Hide();
        }
        else
            MessageBox.Show("Вы не ввели название файла");
    }

    private void buttonCreate_Click_1(object sender, EventArgs e) => CreateOrEdit(false);
    private void buttonLoad_Click(object sender, EventArgs e) => CreateOrEdit(true);

    private void buttonLoadJson_Click(object sender, EventArgs e)
    {
    }
}