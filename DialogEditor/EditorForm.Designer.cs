using System.ComponentModel;

namespace DialogEditor;

partial class EditorForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        buttonExit = new System.Windows.Forms.Button();
        labelDialog = new System.Windows.Forms.Label();
        ButtonSave = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        dialogStyles = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // buttonExit
        // 
        buttonExit.Location = new System.Drawing.Point(21, 15);
        buttonExit.Name = "buttonExit";
        buttonExit.Size = new System.Drawing.Size(40, 39);
        buttonExit.TabIndex = 0;
        buttonExit.Text = "<-";
        buttonExit.UseVisualStyleBackColor = true;
        // 
        // labelDialog
        // 
        labelDialog.Location = new System.Drawing.Point(243, 13);
        labelDialog.Name = "labelDialog";
        labelDialog.Size = new System.Drawing.Size(285, 40);
        labelDialog.TabIndex = 1;
        labelDialog.Text = "НазваниеДиалога";
        labelDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ButtonSave
        // 
        ButtonSave.Location = new System.Drawing.Point(641, 398);
        ButtonSave.Name = "ButtonSave";
        ButtonSave.Size = new System.Drawing.Size(147, 40);
        ButtonSave.TabIndex = 2;
        ButtonSave.Text = "Сохранить";
        ButtonSave.UseVisualStyleBackColor = true;
        ButtonSave.Click += ButtonSave_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(70, 54);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(106, 25);
        label1.TabIndex = 4;
        label1.Text = "Стиль диалога";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // dialogStyles
        // 
        dialogStyles.FormattingEnabled = true;
        dialogStyles.Location = new System.Drawing.Point(182, 56);
        dialogStyles.Name = "dialogStyles";
        dialogStyles.Size = new System.Drawing.Size(121, 23);
        dialogStyles.TabIndex = 5;
        dialogStyles.SelectedIndexChanged += dialogStyles_SelectedIndexChanged;
        // 
        // EditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dialogStyles);
        Controls.Add(label1);
        Controls.Add(ButtonSave);
        Controls.Add(labelDialog);
        Controls.Add(buttonExit);
        Text = "EditorForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox dialogStyles;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button ButtonSave;

    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Label labelDialog;

    #endregion
}