namespace DialogEditor;

partial class StartForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonCreate = new System.Windows.Forms.Button();
        buttonLoad = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        labelDialogName = new System.Windows.Forms.Label();
        buttonLoadJson = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // buttonCreate
        // 
        buttonCreate.Location = new System.Drawing.Point(224, 229);
        buttonCreate.Name = "buttonCreate";
        buttonCreate.Size = new System.Drawing.Size(134, 34);
        buttonCreate.TabIndex = 0;
        buttonCreate.Text = "Создать";
        buttonCreate.UseVisualStyleBackColor = true;
        buttonCreate.Click += buttonCreate_Click_1;
        // 
        // buttonLoad
        // 
        buttonLoad.Location = new System.Drawing.Point(419, 229);
        buttonLoad.Name = "buttonLoad";
        buttonLoad.Size = new System.Drawing.Size(134, 34);
        buttonLoad.TabIndex = 1;
        buttonLoad.Text = "Загрузить";
        buttonLoad.UseVisualStyleBackColor = true;
        buttonLoad.Click += buttonLoad_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(284, 162);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(206, 23);
        textBox1.TabIndex = 2;
        // 
        // labelDialogName
        // 
        labelDialogName.Location = new System.Drawing.Point(284, 116);
        labelDialogName.Name = "labelDialogName";
        labelDialogName.Size = new System.Drawing.Size(206, 43);
        labelDialogName.TabIndex = 3;
        labelDialogName.Text = "Название диалога";
        labelDialogName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // buttonLoadJson
        // 
        buttonLoadJson.Location = new System.Drawing.Point(12, 404);
        buttonLoadJson.Name = "buttonLoadJson";
        buttonLoadJson.Size = new System.Drawing.Size(134, 34);
        buttonLoadJson.TabIndex = 4;
        buttonLoadJson.Text = "Подгрузить json";
        buttonLoadJson.UseVisualStyleBackColor = true;
        buttonLoadJson.Click += buttonLoadJson_Click;
        // 
        // StartForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonLoadJson);
        Controls.Add(labelDialogName);
        Controls.Add(textBox1);
        Controls.Add(buttonLoad);
        Controls.Add(buttonCreate);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonLoadJson;

    private System.Windows.Forms.Button buttonCreate;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label labelDialogName;

    #endregion
}