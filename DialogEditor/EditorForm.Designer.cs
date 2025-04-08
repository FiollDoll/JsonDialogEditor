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
        pagePreference = new System.Windows.Forms.GroupBox();
        checkMoreRead = new System.Windows.Forms.CheckBox();
        checkCanInter = new System.Windows.Forms.CheckBox();
        checkCanMove = new System.Windows.Forms.CheckBox();
        pageSteps = new System.Windows.Forms.GroupBox();
        buttonDialogStepPref = new System.Windows.Forms.Button();
        buttonDialogStep = new System.Windows.Forms.Button();
        dialogStepManage = new System.Windows.Forms.GroupBox();
        comboBoxMood = new System.Windows.Forms.ComboBox();
        label3 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBoxEn = new System.Windows.Forms.TextBox();
        textBoxRu = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        textBoxNpcName = new System.Windows.Forms.TextBox();
        buttonSaveDialog = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        Label = new System.Windows.Forms.Label();
        buttonAddStep = new System.Windows.Forms.Button();
        comboBoxSelectedStep = new System.Windows.Forms.ComboBox();
        buttonAddBranch = new System.Windows.Forms.Button();
        comboBoxSelectedBranch = new System.Windows.Forms.ComboBox();
        dialogStepPreference = new System.Windows.Forms.GroupBox();
        checkBoxCursedText = new System.Windows.Forms.CheckBox();
        buttonPageFirst = new System.Windows.Forms.Button();
        buttonPageDialog = new System.Windows.Forms.Button();
        pagePreference.SuspendLayout();
        pageSteps.SuspendLayout();
        dialogStepManage.SuspendLayout();
        dialogStepPreference.SuspendLayout();
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
        labelDialog.Text = "DialogName";
        labelDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ButtonSave
        // 
        ButtonSave.Location = new System.Drawing.Point(641, 401);
        ButtonSave.Name = "ButtonSave";
        ButtonSave.Size = new System.Drawing.Size(147, 40);
        ButtonSave.TabIndex = 2;
        ButtonSave.Text = "Сохранить";
        ButtonSave.UseVisualStyleBackColor = true;
        ButtonSave.Click += ButtonSave_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(44, 57);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(106, 25);
        label1.TabIndex = 4;
        label1.Text = "Стиль диалога";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // dialogStyles
        // 
        dialogStyles.FormattingEnabled = true;
        dialogStyles.Location = new System.Drawing.Point(156, 59);
        dialogStyles.Name = "dialogStyles";
        dialogStyles.Size = new System.Drawing.Size(121, 23);
        dialogStyles.TabIndex = 5;
        dialogStyles.SelectedIndexChanged += dialogStyles_SelectedIndexChanged;
        // 
        // pagePreference
        // 
        pagePreference.Controls.Add(checkMoreRead);
        pagePreference.Controls.Add(checkCanInter);
        pagePreference.Controls.Add(checkCanMove);
        pagePreference.Location = new System.Drawing.Point(65, 85);
        pagePreference.Name = "pagePreference";
        pagePreference.Size = new System.Drawing.Size(697, 306);
        pagePreference.TabIndex = 6;
        pagePreference.TabStop = false;
        pagePreference.Visible = false;
        // 
        // checkMoreRead
        // 
        checkMoreRead.Location = new System.Drawing.Point(17, 85);
        checkMoreRead.Name = "checkMoreRead";
        checkMoreRead.Size = new System.Drawing.Size(361, 24);
        checkMoreRead.TabIndex = 0;
        checkMoreRead.Text = "Читать несколько раз";
        checkMoreRead.UseVisualStyleBackColor = true;
        checkMoreRead.CheckedChanged += checkMoreRead_CheckedChanged;
        // 
        // checkCanInter
        // 
        checkCanInter.Location = new System.Drawing.Point(17, 55);
        checkCanInter.Name = "checkCanInter";
        checkCanInter.Size = new System.Drawing.Size(361, 24);
        checkCanInter.TabIndex = 0;
        checkCanInter.Text = "Можно взаимодействовать";
        checkCanInter.UseVisualStyleBackColor = true;
        checkCanInter.CheckedChanged += checkCanInter_CheckedChanged;
        // 
        // checkCanMove
        // 
        checkCanMove.Location = new System.Drawing.Point(17, 25);
        checkCanMove.Name = "checkCanMove";
        checkCanMove.Size = new System.Drawing.Size(361, 24);
        checkCanMove.TabIndex = 0;
        checkCanMove.Text = "Можно двигаться";
        checkCanMove.UseVisualStyleBackColor = true;
        checkCanMove.CheckedChanged += checkCanMove_CheckedChanged;
        // 
        // pageSteps
        // 
        pageSteps.Controls.Add(buttonDialogStepPref);
        pageSteps.Controls.Add(buttonDialogStep);
        pageSteps.Controls.Add(buttonSaveDialog);
        pageSteps.Controls.Add(label2);
        pageSteps.Controls.Add(Label);
        pageSteps.Controls.Add(buttonAddStep);
        pageSteps.Controls.Add(comboBoxSelectedStep);
        pageSteps.Controls.Add(buttonAddBranch);
        pageSteps.Controls.Add(comboBoxSelectedBranch);
        pageSteps.Controls.Add(dialogStepPreference);
        pageSteps.Controls.Add(dialogStepManage);
        pageSteps.Location = new System.Drawing.Point(65, 85);
        pageSteps.Name = "pageSteps";
        pageSteps.Size = new System.Drawing.Size(697, 306);
        pageSteps.TabIndex = 7;
        pageSteps.TabStop = false;
        // 
        // buttonDialogStepPref
        // 
        buttonDialogStepPref.Location = new System.Drawing.Point(128, 270);
        buttonDialogStepPref.Name = "buttonDialogStepPref";
        buttonDialogStepPref.Size = new System.Drawing.Size(99, 29);
        buttonDialogStepPref.TabIndex = 8;
        buttonDialogStepPref.Text = "Настройки";
        buttonDialogStepPref.UseVisualStyleBackColor = true;
        buttonDialogStepPref.Click += buttonDialogStepPref_Click;
        // 
        // buttonDialogStep
        // 
        buttonDialogStep.Location = new System.Drawing.Point(23, 270);
        buttonDialogStep.Name = "buttonDialogStep";
        buttonDialogStep.Size = new System.Drawing.Size(99, 29);
        buttonDialogStep.TabIndex = 7;
        buttonDialogStep.Text = "Диалог";
        buttonDialogStep.UseVisualStyleBackColor = true;
        buttonDialogStep.Click += buttonDialogStep_Click;
        // 
        // dialogStepManage
        // 
        dialogStepManage.Controls.Add(comboBoxMood);
        dialogStepManage.Controls.Add(label3);
        dialogStepManage.Controls.Add(label6);
        dialogStepManage.Controls.Add(label5);
        dialogStepManage.Controls.Add(textBoxEn);
        dialogStepManage.Controls.Add(textBoxRu);
        dialogStepManage.Controls.Add(label4);
        dialogStepManage.Controls.Add(textBoxNpcName);
        dialogStepManage.Location = new System.Drawing.Point(10, 67);
        dialogStepManage.Name = "dialogStepManage";
        dialogStepManage.Size = new System.Drawing.Size(670, 203);
        dialogStepManage.TabIndex = 6;
        dialogStepManage.TabStop = false;
        // 
        // comboBoxMood
        // 
        comboBoxMood.FormattingEnabled = true;
        comboBoxMood.Location = new System.Drawing.Point(423, 21);
        comboBoxMood.Name = "comboBoxMood";
        comboBoxMood.Size = new System.Drawing.Size(144, 23);
        comboBoxMood.TabIndex = 8;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(349, 20);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(68, 22);
        label3.TabIndex = 7;
        label3.Text = "Mood";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(323, 56);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(31, 21);
        label6.TabIndex = 5;
        label6.Text = "En";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(44, 56);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(31, 21);
        label5.TabIndex = 4;
        label5.Text = "Ru";
        // 
        // textBoxEn
        // 
        textBoxEn.Location = new System.Drawing.Point(360, 56);
        textBoxEn.Multiline = true;
        textBoxEn.Name = "textBoxEn";
        textBoxEn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBoxEn.ShortcutsEnabled = false;
        textBoxEn.Size = new System.Drawing.Size(227, 114);
        textBoxEn.TabIndex = 3;
        // 
        // textBoxRu
        // 
        textBoxRu.Location = new System.Drawing.Point(81, 56);
        textBoxRu.Multiline = true;
        textBoxRu.Name = "textBoxRu";
        textBoxRu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBoxRu.ShortcutsEnabled = false;
        textBoxRu.Size = new System.Drawing.Size(227, 114);
        textBoxRu.TabIndex = 2;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(23, 23);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(68, 22);
        label4.TabIndex = 1;
        label4.Text = "Npc name";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // textBoxNpcName
        // 
        textBoxNpcName.Location = new System.Drawing.Point(97, 22);
        textBoxNpcName.Name = "textBoxNpcName";
        textBoxNpcName.Size = new System.Drawing.Size(147, 23);
        textBoxNpcName.TabIndex = 0;
        // 
        // buttonSaveDialog
        // 
        buttonSaveDialog.Location = new System.Drawing.Point(580, 274);
        buttonSaveDialog.Name = "buttonSaveDialog";
        buttonSaveDialog.Size = new System.Drawing.Size(100, 26);
        buttonSaveDialog.TabIndex = 6;
        buttonSaveDialog.Text = "Сохранить диалог";
        buttonSaveDialog.UseVisualStyleBackColor = true;
        buttonSaveDialog.Click += buttonSaveDialog_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(536, 19);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(113, 14);
        label2.TabIndex = 5;
        label2.Text = "Шаг диалога";
        // 
        // Label
        // 
        Label.Location = new System.Drawing.Point(10, 19);
        Label.Name = "Label";
        Label.Size = new System.Drawing.Size(116, 18);
        Label.TabIndex = 4;
        Label.Text = "Ветки";
        // 
        // buttonAddStep
        // 
        buttonAddStep.Location = new System.Drawing.Point(655, 34);
        buttonAddStep.Name = "buttonAddStep";
        buttonAddStep.Size = new System.Drawing.Size(25, 24);
        buttonAddStep.TabIndex = 3;
        buttonAddStep.Text = "+";
        buttonAddStep.UseVisualStyleBackColor = true;
        buttonAddStep.Click += buttonAddStep_Click;
        // 
        // comboBoxSelectedStep
        // 
        comboBoxSelectedStep.FormattingEnabled = true;
        comboBoxSelectedStep.Location = new System.Drawing.Point(536, 36);
        comboBoxSelectedStep.Name = "comboBoxSelectedStep";
        comboBoxSelectedStep.Size = new System.Drawing.Size(113, 23);
        comboBoxSelectedStep.TabIndex = 2;
        comboBoxSelectedStep.SelectedIndexChanged += comboBoxSelectedStep_SelectedIndexChanged;
        // 
        // buttonAddBranch
        // 
        buttonAddBranch.Location = new System.Drawing.Point(129, 36);
        buttonAddBranch.Name = "buttonAddBranch";
        buttonAddBranch.Size = new System.Drawing.Size(25, 24);
        buttonAddBranch.TabIndex = 1;
        buttonAddBranch.Text = "+";
        buttonAddBranch.UseVisualStyleBackColor = true;
        buttonAddBranch.Click += buttonAddBranch_Click;
        // 
        // comboBoxSelectedBranch
        // 
        comboBoxSelectedBranch.FormattingEnabled = true;
        comboBoxSelectedBranch.Location = new System.Drawing.Point(10, 38);
        comboBoxSelectedBranch.Name = "comboBoxSelectedBranch";
        comboBoxSelectedBranch.Size = new System.Drawing.Size(113, 23);
        comboBoxSelectedBranch.TabIndex = 1;
        comboBoxSelectedBranch.SelectedIndexChanged += comboBoxSelectedBranch_SelectedIndexChanged;
        // 
        // dialogStepPreference
        // 
        dialogStepPreference.Controls.Add(checkBoxCursedText);
        dialogStepPreference.Location = new System.Drawing.Point(10, 67);
        dialogStepPreference.Name = "dialogStepPreference";
        dialogStepPreference.Size = new System.Drawing.Size(670, 203);
        dialogStepPreference.TabIndex = 6;
        dialogStepPreference.TabStop = false;
        // 
        // checkBoxCursedText
        // 
        checkBoxCursedText.Location = new System.Drawing.Point(18, 19);
        checkBoxCursedText.Name = "checkBoxCursedText";
        checkBoxCursedText.Size = new System.Drawing.Size(164, 19);
        checkBoxCursedText.TabIndex = 0;
        checkBoxCursedText.Text = "Сломанный текст";
        checkBoxCursedText.UseVisualStyleBackColor = true;
        checkBoxCursedText.CheckedChanged += checkBoxCursedText_CheckedChanged;
        // 
        // buttonPageFirst
        // 
        buttonPageFirst.Location = new System.Drawing.Point(63, 413);
        buttonPageFirst.Name = "buttonPageFirst";
        buttonPageFirst.Size = new System.Drawing.Size(128, 28);
        buttonPageFirst.TabIndex = 7;
        buttonPageFirst.Text = "Настройки диалога";
        buttonPageFirst.UseVisualStyleBackColor = true;
        buttonPageFirst.Click += buttonPageFirst_Click;
        // 
        // buttonPageDialog
        // 
        buttonPageDialog.Location = new System.Drawing.Point(194, 413);
        buttonPageDialog.Name = "buttonPageDialog";
        buttonPageDialog.Size = new System.Drawing.Size(125, 28);
        buttonPageDialog.TabIndex = 8;
        buttonPageDialog.Text = "Ветки диалога";
        buttonPageDialog.UseVisualStyleBackColor = true;
        buttonPageDialog.Click += buttonPageDialog_Click;
        // 
        // EditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonPageDialog);
        Controls.Add(buttonPageFirst);
        Controls.Add(dialogStyles);
        Controls.Add(label1);
        Controls.Add(ButtonSave);
        Controls.Add(labelDialog);
        Controls.Add(buttonExit);
        Controls.Add(pageSteps);
        Controls.Add(pagePreference);
        Location = new System.Drawing.Point(15, 15);
        Text = "EditorForm";
        pagePreference.ResumeLayout(false);
        pageSteps.ResumeLayout(false);
        dialogStepManage.ResumeLayout(false);
        dialogStepManage.PerformLayout();
        dialogStepPreference.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBoxMood;

    private System.Windows.Forms.CheckBox checkBoxCursedText;
    private System.Windows.Forms.Button buttonDialogStep;
    private System.Windows.Forms.Button buttonDialogStepPref;

    private System.Windows.Forms.GroupBox dialogStepPreference;

    private System.Windows.Forms.Button buttonSaveDialog;

    private System.Windows.Forms.TextBox textBoxEn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxRu;

    private System.Windows.Forms.TextBox textBoxNpcName;

    private System.Windows.Forms.GroupBox dialogStepManage;

    private System.Windows.Forms.ComboBox comboBoxSelectedBranch;
    private System.Windows.Forms.Button buttonAddBranch;
    private System.Windows.Forms.ComboBox comboBoxSelectedStep;
    private System.Windows.Forms.Button buttonAddStep;
    private System.Windows.Forms.Label Label;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button buttonPageFirst;
    private System.Windows.Forms.GroupBox pageSteps;

    private System.Windows.Forms.CheckBox checkCanInter;
    private System.Windows.Forms.Button buttonPageDialog;

    private System.Windows.Forms.CheckBox checkCanMove;
    private System.Windows.Forms.CheckBox checkMoreRead;

    private System.Windows.Forms.GroupBox pagePreference;

    private System.Windows.Forms.ComboBox dialogStyles;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button ButtonSave;

    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Label labelDialog;

    #endregion
}