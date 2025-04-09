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
        buttonLoad = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        labelDialogName = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        buttonJsonSet = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // buttonLoad
        // 
        buttonLoad.Location = new System.Drawing.Point(318, 275);
        buttonLoad.Name = "buttonLoad";
        buttonLoad.Size = new System.Drawing.Size(134, 34);
        buttonLoad.TabIndex = 1;
        buttonLoad.Text = "Открыть";
        buttonLoad.UseVisualStyleBackColor = true;
        buttonLoad.Click += buttonLoad_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(128, 215);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(206, 23);
        textBox1.TabIndex = 2;
        // 
        // labelDialogName
        // 
        labelDialogName.Location = new System.Drawing.Point(281, 156);
        labelDialogName.Name = "labelDialogName";
        labelDialogName.Size = new System.Drawing.Size(206, 43);
        labelDialogName.TabIndex = 3;
        labelDialogName.Text = "Название диалога";
        labelDialogName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(340, 210);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(82, 31);
        label1.TabIndex = 4;
        label1.Text = "или";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(428, 215);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(212, 23);
        comboBox1.TabIndex = 5;
        // 
        // buttonJsonSet
        // 
        buttonJsonSet.Location = new System.Drawing.Point(24, 414);
        buttonJsonSet.Name = "buttonJsonSet";
        buttonJsonSet.Size = new System.Drawing.Size(90, 26);
        buttonJsonSet.TabIndex = 6;
        buttonJsonSet.Text = "Выбрать .json";
        buttonJsonSet.UseVisualStyleBackColor = true;
        buttonJsonSet.Click += buttonJsonSet_Click;
        // 
        // StartForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonJsonSet);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Controls.Add(labelDialogName);
        Controls.Add(textBox1);
        Controls.Add(buttonLoad);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonJsonSet;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label labelDialogName;

    #endregion
}