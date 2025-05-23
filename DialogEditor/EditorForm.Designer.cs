﻿using System.ComponentModel;

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
        label19 = new System.Windows.Forms.Label();
        textBoxDelay = new System.Windows.Forms.TextBox();
        checkCanInter = new System.Windows.Forms.CheckBox();
        checkCanMove = new System.Windows.Forms.CheckBox();
        checkMoreRead = new System.Windows.Forms.CheckBox();
        pageSteps = new System.Windows.Forms.GroupBox();
        buttonChoiceRemove = new System.Windows.Forms.Button();
        label17 = new System.Windows.Forms.Label();
        buttonChoiceAdd = new System.Windows.Forms.Button();
        comboBoxChoice = new System.Windows.Forms.ComboBox();
        buttonChoice = new System.Windows.Forms.Button();
        buttonLastStep = new System.Windows.Forms.Button();
        buttonNextStep = new System.Windows.Forms.Button();
        buttonRemoveBranch = new System.Windows.Forms.Button();
        buttonRemoveStep = new System.Windows.Forms.Button();
        buttonDialogStepPref = new System.Windows.Forms.Button();
        buttonDialogStep = new System.Windows.Forms.Button();
        buttonSaveDialog = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        Label = new System.Windows.Forms.Label();
        buttonAddStep = new System.Windows.Forms.Button();
        comboBoxSelectedStep = new System.Windows.Forms.ComboBox();
        buttonAddBranch = new System.Windows.Forms.Button();
        comboBoxSelectedBranch = new System.Windows.Forms.ComboBox();
        dialogStepManage = new System.Windows.Forms.GroupBox();
        label13 = new System.Windows.Forms.Label();
        textBoxBigPicture = new System.Windows.Forms.TextBox();
        comboBoxMood = new System.Windows.Forms.ComboBox();
        label3 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBoxEn = new System.Windows.Forms.TextBox();
        textBoxRu = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        textBoxNpcName = new System.Windows.Forms.TextBox();
        dialogStepPreference = new System.Windows.Forms.GroupBox();
        label18 = new System.Windows.Forms.Label();
        textBoxCutscene = new System.Windows.Forms.TextBox();
        label12 = new System.Windows.Forms.Label();
        textBoxChangeRelationship = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        textBoxAddNote = new System.Windows.Forms.TextBox();
        label10 = new System.Windows.Forms.Label();
        textBoxAddItem = new System.Windows.Forms.TextBox();
        checkBoxBlockAllMenu = new System.Windows.Forms.CheckBox();
        label9 = new System.Windows.Forms.Label();
        textBoxLocationSpawn = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        textBoxNewLocation = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        textBoxNewDialog = new System.Windows.Forms.TextBox();
        checkBoxCursedText = new System.Windows.Forms.CheckBox();
        pageChoice = new System.Windows.Forms.GroupBox();
        buttonSaveChoice = new System.Windows.Forms.Button();
        comboBoxBranchesToChoice = new System.Windows.Forms.ComboBox();
        checkBoxChoiceMoreRead = new System.Windows.Forms.CheckBox();
        label16 = new System.Windows.Forms.Label();
        label15 = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        textBoxQuestionEn = new System.Windows.Forms.TextBox();
        textBoxQuestionRu = new System.Windows.Forms.TextBox();
        buttonPageFirst = new System.Windows.Forms.Button();
        buttonPageDialog = new System.Windows.Forms.Button();
        buttonDeleteDialog = new System.Windows.Forms.Button();
        label20 = new System.Windows.Forms.Label();
        textBoxAudio = new System.Windows.Forms.TextBox();
        pagePreference.SuspendLayout();
        pageSteps.SuspendLayout();
        dialogStepManage.SuspendLayout();
        dialogStepPreference.SuspendLayout();
        pageChoice.SuspendLayout();
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
        buttonExit.Click += buttonExit_Click;
        // 
        // labelDialog
        // 
        labelDialog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        labelDialog.Location = new System.Drawing.Point(243, 13);
        labelDialog.Name = "labelDialog";
        labelDialog.Size = new System.Drawing.Size(285, 26);
        labelDialog.TabIndex = 1;
        labelDialog.Text = "DialogName";
        labelDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ButtonSave
        // 
        ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        ButtonSave.FlatAppearance.BorderSize = 0;
        ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ButtonSave.Location = new System.Drawing.Point(641, 401);
        ButtonSave.Name = "ButtonSave";
        ButtonSave.Size = new System.Drawing.Size(147, 40);
        ButtonSave.TabIndex = 2;
        ButtonSave.Text = "Сохранить";
        ButtonSave.UseVisualStyleBackColor = false;
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
        pagePreference.Controls.Add(label19);
        pagePreference.Controls.Add(textBoxDelay);
        pagePreference.Controls.Add(checkCanInter);
        pagePreference.Controls.Add(checkCanMove);
        pagePreference.Controls.Add(checkMoreRead);
        pagePreference.Location = new System.Drawing.Point(65, 85);
        pagePreference.Name = "pagePreference";
        pagePreference.Size = new System.Drawing.Size(697, 306);
        pagePreference.TabIndex = 6;
        pagePreference.TabStop = false;
        pagePreference.Visible = false;
        // 
        // label19
        // 
        label19.Location = new System.Drawing.Point(44, 117);
        label19.Name = "label19";
        label19.Size = new System.Drawing.Size(131, 22);
        label19.TabIndex = 19;
        label19.Text = "Задержка диалога";
        label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxDelay
        // 
        textBoxDelay.Location = new System.Drawing.Point(11, 116);
        textBoxDelay.Name = "textBoxDelay";
        textBoxDelay.Size = new System.Drawing.Size(27, 23);
        textBoxDelay.TabIndex = 18;
        textBoxDelay.TextChanged += textBoxDelay_TextChanged;
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
        // pageSteps
        // 
        pageSteps.Controls.Add(buttonChoiceRemove);
        pageSteps.Controls.Add(label17);
        pageSteps.Controls.Add(buttonChoiceAdd);
        pageSteps.Controls.Add(comboBoxChoice);
        pageSteps.Controls.Add(buttonChoice);
        pageSteps.Controls.Add(buttonLastStep);
        pageSteps.Controls.Add(buttonNextStep);
        pageSteps.Controls.Add(buttonRemoveBranch);
        pageSteps.Controls.Add(buttonRemoveStep);
        pageSteps.Controls.Add(buttonDialogStepPref);
        pageSteps.Controls.Add(buttonDialogStep);
        pageSteps.Controls.Add(buttonSaveDialog);
        pageSteps.Controls.Add(label2);
        pageSteps.Controls.Add(Label);
        pageSteps.Controls.Add(buttonAddStep);
        pageSteps.Controls.Add(comboBoxSelectedStep);
        pageSteps.Controls.Add(buttonAddBranch);
        pageSteps.Controls.Add(comboBoxSelectedBranch);
        pageSteps.Controls.Add(dialogStepManage);
        pageSteps.Controls.Add(dialogStepPreference);
        pageSteps.Controls.Add(pageChoice);
        pageSteps.Location = new System.Drawing.Point(65, 85);
        pageSteps.Name = "pageSteps";
        pageSteps.Size = new System.Drawing.Size(697, 306);
        pageSteps.TabIndex = 7;
        pageSteps.TabStop = false;
        // 
        // buttonChoiceRemove
        // 
        buttonChoiceRemove.Location = new System.Drawing.Point(412, 36);
        buttonChoiceRemove.Name = "buttonChoiceRemove";
        buttonChoiceRemove.Size = new System.Drawing.Size(25, 24);
        buttonChoiceRemove.TabIndex = 18;
        buttonChoiceRemove.Text = "-";
        buttonChoiceRemove.UseVisualStyleBackColor = true;
        // 
        // label17
        // 
        label17.Location = new System.Drawing.Point(262, 21);
        label17.Name = "label17";
        label17.Size = new System.Drawing.Size(113, 14);
        label17.TabIndex = 17;
        label17.Text = "Выборы диалога";
        // 
        // buttonChoiceAdd
        // 
        buttonChoiceAdd.Location = new System.Drawing.Point(381, 36);
        buttonChoiceAdd.Name = "buttonChoiceAdd";
        buttonChoiceAdd.Size = new System.Drawing.Size(25, 24);
        buttonChoiceAdd.TabIndex = 16;
        buttonChoiceAdd.Text = "+";
        buttonChoiceAdd.UseVisualStyleBackColor = true;
        buttonChoiceAdd.Click += buttonChoiceAdd_Click;
        // 
        // comboBoxChoice
        // 
        comboBoxChoice.FormattingEnabled = true;
        comboBoxChoice.Location = new System.Drawing.Point(262, 38);
        comboBoxChoice.Name = "comboBoxChoice";
        comboBoxChoice.Size = new System.Drawing.Size(113, 23);
        comboBoxChoice.TabIndex = 15;
        comboBoxChoice.SelectedIndexChanged += comboBoxChoice_SelectedIndexChanged;
        // 
        // buttonChoice
        // 
        buttonChoice.Location = new System.Drawing.Point(128, 270);
        buttonChoice.Name = "buttonChoice";
        buttonChoice.Size = new System.Drawing.Size(99, 29);
        buttonChoice.TabIndex = 13;
        buttonChoice.Text = "Выбор";
        buttonChoice.UseVisualStyleBackColor = true;
        buttonChoice.Click += buttonChoice_Click;
        // 
        // buttonLastStep
        // 
        buttonLastStep.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        buttonLastStep.Location = new System.Drawing.Point(453, 37);
        buttonLastStep.Name = "buttonLastStep";
        buttonLastStep.Size = new System.Drawing.Size(25, 24);
        buttonLastStep.TabIndex = 12;
        buttonLastStep.Text = "<-";
        buttonLastStep.UseVisualStyleBackColor = true;
        buttonLastStep.Click += buttonLastStep_Click;
        // 
        // buttonNextStep
        // 
        buttonNextStep.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        buttonNextStep.Location = new System.Drawing.Point(484, 37);
        buttonNextStep.Name = "buttonNextStep";
        buttonNextStep.Size = new System.Drawing.Size(25, 24);
        buttonNextStep.TabIndex = 11;
        buttonNextStep.Text = "->";
        buttonNextStep.UseVisualStyleBackColor = true;
        buttonNextStep.Click += buttonNextStep_Click;
        // 
        // buttonRemoveBranch
        // 
        buttonRemoveBranch.Location = new System.Drawing.Point(160, 36);
        buttonRemoveBranch.Name = "buttonRemoveBranch";
        buttonRemoveBranch.Size = new System.Drawing.Size(25, 24);
        buttonRemoveBranch.TabIndex = 10;
        buttonRemoveBranch.Text = "-";
        buttonRemoveBranch.UseVisualStyleBackColor = true;
        // 
        // buttonRemoveStep
        // 
        buttonRemoveStep.Location = new System.Drawing.Point(665, 36);
        buttonRemoveStep.Name = "buttonRemoveStep";
        buttonRemoveStep.Size = new System.Drawing.Size(25, 24);
        buttonRemoveStep.TabIndex = 9;
        buttonRemoveStep.Text = "-";
        buttonRemoveStep.UseVisualStyleBackColor = true;
        buttonRemoveStep.Click += buttonRemoveStep_Click;
        // 
        // buttonDialogStepPref
        // 
        buttonDialogStepPref.Location = new System.Drawing.Point(233, 270);
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
        label2.Location = new System.Drawing.Point(515, 21);
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
        buttonAddStep.Location = new System.Drawing.Point(634, 36);
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
        comboBoxSelectedStep.Location = new System.Drawing.Point(515, 38);
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
        // dialogStepManage
        // 
        dialogStepManage.Controls.Add(label20);
        dialogStepManage.Controls.Add(textBoxAudio);
        dialogStepManage.Controls.Add(label13);
        dialogStepManage.Controls.Add(textBoxBigPicture);
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
        // label13
        // 
        label13.Location = new System.Drawing.Point(8, 175);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(68, 22);
        label13.TabIndex = 10;
        label13.Text = "Big picture";
        label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // textBoxBigPicture
        // 
        textBoxBigPicture.Location = new System.Drawing.Point(82, 174);
        textBoxBigPicture.Name = "textBoxBigPicture";
        textBoxBigPicture.Size = new System.Drawing.Size(147, 23);
        textBoxBigPicture.TabIndex = 9;
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
        textBoxEn.Location = new System.Drawing.Point(360, 51);
        textBoxEn.Multiline = true;
        textBoxEn.Name = "textBoxEn";
        textBoxEn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBoxEn.Size = new System.Drawing.Size(227, 114);
        textBoxEn.TabIndex = 3;
        // 
        // textBoxRu
        // 
        textBoxRu.Location = new System.Drawing.Point(81, 56);
        textBoxRu.Multiline = true;
        textBoxRu.Name = "textBoxRu";
        textBoxRu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
        // dialogStepPreference
        // 
        dialogStepPreference.Controls.Add(label18);
        dialogStepPreference.Controls.Add(textBoxCutscene);
        dialogStepPreference.Controls.Add(label12);
        dialogStepPreference.Controls.Add(textBoxChangeRelationship);
        dialogStepPreference.Controls.Add(label11);
        dialogStepPreference.Controls.Add(textBoxAddNote);
        dialogStepPreference.Controls.Add(label10);
        dialogStepPreference.Controls.Add(textBoxAddItem);
        dialogStepPreference.Controls.Add(checkBoxBlockAllMenu);
        dialogStepPreference.Controls.Add(label9);
        dialogStepPreference.Controls.Add(textBoxLocationSpawn);
        dialogStepPreference.Controls.Add(label8);
        dialogStepPreference.Controls.Add(textBoxNewLocation);
        dialogStepPreference.Controls.Add(label7);
        dialogStepPreference.Controls.Add(textBoxNewDialog);
        dialogStepPreference.Controls.Add(checkBoxCursedText);
        dialogStepPreference.Location = new System.Drawing.Point(10, 67);
        dialogStepPreference.Name = "dialogStepPreference";
        dialogStepPreference.Size = new System.Drawing.Size(670, 203);
        dialogStepPreference.TabIndex = 6;
        dialogStepPreference.TabStop = false;
        // 
        // label18
        // 
        label18.Location = new System.Drawing.Point(51, 45);
        label18.Name = "label18";
        label18.Size = new System.Drawing.Size(131, 22);
        label18.TabIndex = 17;
        label18.Text = "Дальше по катсене";
        label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxCutscene
        // 
        textBoxCutscene.Location = new System.Drawing.Point(18, 44);
        textBoxCutscene.Name = "textBoxCutscene";
        textBoxCutscene.Size = new System.Drawing.Size(27, 23);
        textBoxCutscene.TabIndex = 16;
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(505, 120);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(113, 50);
        label12.TabIndex = 15;
        label12.Text = "Изменить отношения\r\n(Имя изменение)";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxChangeRelationship
        // 
        textBoxChangeRelationship.Location = new System.Drawing.Point(391, 119);
        textBoxChangeRelationship.Multiline = true;
        textBoxChangeRelationship.Name = "textBoxChangeRelationship";
        textBoxChangeRelationship.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBoxChangeRelationship.Size = new System.Drawing.Size(108, 51);
        textBoxChangeRelationship.TabIndex = 14;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(314, 120);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(97, 50);
        label11.TabIndex = 13;
        label11.Text = "Добавить записку";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxAddNote
        // 
        textBoxAddNote.Location = new System.Drawing.Point(200, 119);
        textBoxAddNote.Multiline = true;
        textBoxAddNote.Name = "textBoxAddNote";
        textBoxAddNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBoxAddNote.Size = new System.Drawing.Size(108, 51);
        textBoxAddNote.TabIndex = 12;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(132, 120);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(97, 50);
        label10.TabIndex = 11;
        label10.Text = "Добавить предмет";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxAddItem
        // 
        textBoxAddItem.Location = new System.Drawing.Point(18, 119);
        textBoxAddItem.Multiline = true;
        textBoxAddItem.Name = "textBoxAddItem";
        textBoxAddItem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBoxAddItem.Size = new System.Drawing.Size(108, 51);
        textBoxAddItem.TabIndex = 10;
        // 
        // checkBoxBlockAllMenu
        // 
        checkBoxBlockAllMenu.Location = new System.Drawing.Point(168, 18);
        checkBoxBlockAllMenu.Name = "checkBoxBlockAllMenu";
        checkBoxBlockAllMenu.Size = new System.Drawing.Size(164, 19);
        checkBoxBlockAllMenu.TabIndex = 7;
        checkBoxBlockAllMenu.Text = "Заблокировать меню";
        checkBoxBlockAllMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        checkBoxBlockAllMenu.UseVisualStyleBackColor = true;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(552, 79);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(97, 22);
        label9.TabIndex = 6;
        label9.Text = "Спавн локации";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxLocationSpawn
        // 
        textBoxLocationSpawn.Location = new System.Drawing.Point(438, 78);
        textBoxLocationSpawn.Name = "textBoxLocationSpawn";
        textBoxLocationSpawn.Size = new System.Drawing.Size(108, 23);
        textBoxLocationSpawn.TabIndex = 5;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(552, 50);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(97, 22);
        label8.TabIndex = 4;
        label8.Text = "Новая локация";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxNewLocation
        // 
        textBoxNewLocation.Location = new System.Drawing.Point(438, 49);
        textBoxNewLocation.Name = "textBoxNewLocation";
        textBoxNewLocation.Size = new System.Drawing.Size(108, 23);
        textBoxNewLocation.TabIndex = 3;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(552, 21);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(97, 22);
        label7.TabIndex = 2;
        label7.Text = "Новый диалог";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxNewDialog
        // 
        textBoxNewDialog.Location = new System.Drawing.Point(438, 20);
        textBoxNewDialog.Name = "textBoxNewDialog";
        textBoxNewDialog.Size = new System.Drawing.Size(108, 23);
        textBoxNewDialog.TabIndex = 1;
        // 
        // checkBoxCursedText
        // 
        checkBoxCursedText.Location = new System.Drawing.Point(18, 19);
        checkBoxCursedText.Name = "checkBoxCursedText";
        checkBoxCursedText.Size = new System.Drawing.Size(164, 19);
        checkBoxCursedText.TabIndex = 0;
        checkBoxCursedText.Text = "Сломанный текст";
        checkBoxCursedText.UseVisualStyleBackColor = true;
        // 
        // pageChoice
        // 
        pageChoice.Controls.Add(buttonSaveChoice);
        pageChoice.Controls.Add(comboBoxBranchesToChoice);
        pageChoice.Controls.Add(checkBoxChoiceMoreRead);
        pageChoice.Controls.Add(label16);
        pageChoice.Controls.Add(label15);
        pageChoice.Controls.Add(label14);
        pageChoice.Controls.Add(textBoxQuestionEn);
        pageChoice.Controls.Add(textBoxQuestionRu);
        pageChoice.Location = new System.Drawing.Point(10, 67);
        pageChoice.Name = "pageChoice";
        pageChoice.Size = new System.Drawing.Size(670, 203);
        pageChoice.TabIndex = 14;
        pageChoice.TabStop = false;
        // 
        // buttonSaveChoice
        // 
        buttonSaveChoice.Location = new System.Drawing.Point(568, 158);
        buttonSaveChoice.Name = "buttonSaveChoice";
        buttonSaveChoice.Size = new System.Drawing.Size(87, 21);
        buttonSaveChoice.TabIndex = 8;
        buttonSaveChoice.Text = "Сохранить";
        buttonSaveChoice.UseVisualStyleBackColor = true;
        buttonSaveChoice.Click += buttonSaveChoice_Click_1;
        // 
        // comboBoxBranchesToChoice
        // 
        comboBoxBranchesToChoice.FormattingEnabled = true;
        comboBoxBranchesToChoice.Location = new System.Drawing.Point(122, 146);
        comboBoxBranchesToChoice.Name = "comboBoxBranchesToChoice";
        comboBoxBranchesToChoice.Size = new System.Drawing.Size(110, 23);
        comboBoxBranchesToChoice.TabIndex = 7;
        // 
        // checkBoxChoiceMoreRead
        // 
        checkBoxChoiceMoreRead.Location = new System.Drawing.Point(23, 179);
        checkBoxChoiceMoreRead.Name = "checkBoxChoiceMoreRead";
        checkBoxChoiceMoreRead.Size = new System.Drawing.Size(125, 23);
        checkBoxChoiceMoreRead.TabIndex = 6;
        checkBoxChoiceMoreRead.Text = "Много раз";
        checkBoxChoiceMoreRead.UseVisualStyleBackColor = true;
        // 
        // label16
        // 
        label16.Location = new System.Drawing.Point(17, 149);
        label16.Name = "label16";
        label16.Size = new System.Drawing.Size(113, 24);
        label16.TabIndex = 5;
        label16.Text = "Переход на ветку";
        // 
        // label15
        // 
        label15.Location = new System.Drawing.Point(379, 33);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(41, 27);
        label15.TabIndex = 4;
        label15.Text = "En";
        // 
        // label14
        // 
        label14.Location = new System.Drawing.Point(34, 34);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(44, 26);
        label14.TabIndex = 3;
        label14.Text = "Ru";
        // 
        // textBoxQuestionEn
        // 
        textBoxQuestionEn.Location = new System.Drawing.Point(424, 33);
        textBoxQuestionEn.Multiline = true;
        textBoxQuestionEn.Name = "textBoxQuestionEn";
        textBoxQuestionEn.Size = new System.Drawing.Size(147, 87);
        textBoxQuestionEn.TabIndex = 2;
        // 
        // textBoxQuestionRu
        // 
        textBoxQuestionRu.Location = new System.Drawing.Point(85, 33);
        textBoxQuestionRu.Multiline = true;
        textBoxQuestionRu.Name = "textBoxQuestionRu";
        textBoxQuestionRu.Size = new System.Drawing.Size(147, 87);
        textBoxQuestionRu.TabIndex = 1;
        // 
        // buttonPageFirst
        // 
        buttonPageFirst.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        buttonPageFirst.FlatAppearance.BorderSize = 0;
        buttonPageFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonPageFirst.Location = new System.Drawing.Point(63, 413);
        buttonPageFirst.Name = "buttonPageFirst";
        buttonPageFirst.Size = new System.Drawing.Size(128, 28);
        buttonPageFirst.TabIndex = 7;
        buttonPageFirst.Text = "Настройки диалога";
        buttonPageFirst.UseVisualStyleBackColor = false;
        buttonPageFirst.Click += buttonPageFirst_Click;
        // 
        // buttonPageDialog
        // 
        buttonPageDialog.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        buttonPageDialog.FlatAppearance.BorderSize = 0;
        buttonPageDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonPageDialog.Location = new System.Drawing.Point(194, 413);
        buttonPageDialog.Name = "buttonPageDialog";
        buttonPageDialog.Size = new System.Drawing.Size(125, 28);
        buttonPageDialog.TabIndex = 8;
        buttonPageDialog.Text = "Ветки диалога";
        buttonPageDialog.UseVisualStyleBackColor = false;
        buttonPageDialog.Click += buttonPageDialog_Click;
        // 
        // buttonDeleteDialog
        // 
        buttonDeleteDialog.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)192)));
        buttonDeleteDialog.FlatAppearance.BorderColor = System.Drawing.Color.White;
        buttonDeleteDialog.FlatAppearance.BorderSize = 0;
        buttonDeleteDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttonDeleteDialog.Location = new System.Drawing.Point(327, 415);
        buttonDeleteDialog.Name = "buttonDeleteDialog";
        buttonDeleteDialog.Size = new System.Drawing.Size(102, 26);
        buttonDeleteDialog.TabIndex = 9;
        buttonDeleteDialog.Text = "Удалить диалог";
        buttonDeleteDialog.UseVisualStyleBackColor = false;
        buttonDeleteDialog.Click += buttonDeleteDialog_Click;
        // 
        // label20
        // 
        label20.Location = new System.Drawing.Point(364, 172);
        label20.Name = "label20";
        label20.Size = new System.Drawing.Size(68, 22);
        label20.TabIndex = 12;
        label20.Text = "Audio";
        label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // textBoxAudio
        // 
        textBoxAudio.Location = new System.Drawing.Point(438, 171);
        textBoxAudio.Name = "textBoxAudio";
        textBoxAudio.Size = new System.Drawing.Size(147, 23);
        textBoxAudio.TabIndex = 11;
        // 
        // EditorForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonDeleteDialog);
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
        pagePreference.PerformLayout();
        pageSteps.ResumeLayout(false);
        dialogStepManage.ResumeLayout(false);
        dialogStepManage.PerformLayout();
        dialogStepPreference.ResumeLayout(false);
        dialogStepPreference.PerformLayout();
        pageChoice.ResumeLayout(false);
        pageChoice.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.TextBox textBoxAudio;

    private System.Windows.Forms.TextBox textBoxDelay;

    private System.Windows.Forms.Label label19;

    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox textBoxCutscene;

    private System.Windows.Forms.Button buttonSaveChoice;

    private System.Windows.Forms.Button buttonChoiceRemove;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Button buttonChoiceAdd;
    private System.Windows.Forms.ComboBox comboBoxChoice;

    private System.Windows.Forms.TextBox textBoxQuestionEn;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.CheckBox checkBoxChoiceMoreRead;
    private System.Windows.Forms.ComboBox comboBoxBranchesToChoice;

    private System.Windows.Forms.TextBox textBoxQuestionRu;

    private System.Windows.Forms.Button buttonChoice;
    private System.Windows.Forms.GroupBox pageChoice;

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox textBoxBigPicture;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox textBoxAddNote;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox textBoxChangeRelationship;

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBoxAddItem;

    private System.Windows.Forms.TextBox textBoxNewDialog;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxLocationSpawn;
    private System.Windows.Forms.TextBox textBoxNewLocation;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.CheckBox checkBoxBlockAllMenu;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button buttonRemoveStep;
    private System.Windows.Forms.Button buttonRemoveBranch;
    private System.Windows.Forms.Button buttonNextStep;
    private System.Windows.Forms.Button buttonLastStep;
    private System.Windows.Forms.Button buttonDeleteDialog;

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