namespace WorkOut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.TrackButton = new System.Windows.Forms.Button();
            this.WorkoutButton = new System.Windows.Forms.Button();
            this.SplitsButton = new System.Windows.Forms.Button();
            this.WorkoutPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitsPanel = new System.Windows.Forms.Panel();
            this.AddSplitPanel = new System.Windows.Forms.Panel();
            this.DaysNumberAddSplitCB = new System.Windows.Forms.ComboBox();
            this.listBoxAddSplit = new System.Windows.Forms.ListBox();
            this.SaveWorkoutAddSplitBTN = new System.Windows.Forms.Button();
            this.CancelAddSplitBTN = new System.Windows.Forms.Button();
            this.SaveAddSplitBTN = new System.Windows.Forms.Button();
            this.ClearAddSplitBTN = new System.Windows.Forms.Button();
            this.WorkoutNameAddSplitTB = new System.Windows.Forms.TextBox();
            this.DayAddSplitCB = new System.Windows.Forms.ComboBox();
            this.SplitNameAddSplitTB = new System.Windows.Forms.TextBox();
            this.WorkoutNameAddSplitLBL = new System.Windows.Forms.Label();
            this.DayAddSplitLBL = new System.Windows.Forms.Label();
            this.DaysNumberAddSplitLBL = new System.Windows.Forms.Label();
            this.SplitNameAddSplitLBL = new System.Windows.Forms.Label();
            this.RemoveSplitButton = new System.Windows.Forms.Button();
            this.EditSplitButton = new System.Windows.Forms.Button();
            this.AddSplitButton = new System.Windows.Forms.Button();
            this.SplitsPanelLabel = new System.Windows.Forms.Label();
            this.TrackPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RemoveSplitPanel = new System.Windows.Forms.Panel();
            this.SplitsRemoveSplitLV = new System.Windows.Forms.ListView();
            this.DaysRemoveSplitLV = new System.Windows.Forms.ListView();
            this.SplitNameSplitsRemoveSplitLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DaysNumberSplitsRemoveSplitLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayDaysRemoveSplitLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkoutDaysRemoveSplitLV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteSplitRemoveSplitBTN = new System.Windows.Forms.Button();
            this.EditSplitPanel = new System.Windows.Forms.Panel();
            this.DaysNumberESCB = new System.Windows.Forms.ComboBox();
            this.WorkoutESLB = new System.Windows.Forms.ListBox();
            this.WorkoutNameESTB = new System.Windows.Forms.TextBox();
            this.DayESCB = new System.Windows.Forms.ComboBox();
            this.SplitNameESTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SplitsESLB = new System.Windows.Forms.ListBox();
            this.WorkoutPanel.SuspendLayout();
            this.SplitsPanel.SuspendLayout();
            this.AddSplitPanel.SuspendLayout();
            this.TrackPanel.SuspendLayout();
            this.RemoveSplitPanel.SuspendLayout();
            this.EditSplitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackButton
            // 
            this.TrackButton.Location = new System.Drawing.Point(2, 4);
            this.TrackButton.Name = "TrackButton";
            this.TrackButton.Size = new System.Drawing.Size(75, 23);
            this.TrackButton.TabIndex = 0;
            this.TrackButton.Text = "Track";
            this.TrackButton.UseVisualStyleBackColor = true;
            this.TrackButton.Click += new System.EventHandler(this.TrackButton_Click);
            // 
            // WorkoutButton
            // 
            this.WorkoutButton.Location = new System.Drawing.Point(83, 4);
            this.WorkoutButton.Name = "WorkoutButton";
            this.WorkoutButton.Size = new System.Drawing.Size(75, 23);
            this.WorkoutButton.TabIndex = 1;
            this.WorkoutButton.Text = "Work Out";
            this.WorkoutButton.UseVisualStyleBackColor = true;
            this.WorkoutButton.Click += new System.EventHandler(this.WorkoutButton_Click);
            // 
            // SplitsButton
            // 
            this.SplitsButton.Location = new System.Drawing.Point(164, 4);
            this.SplitsButton.Name = "SplitsButton";
            this.SplitsButton.Size = new System.Drawing.Size(75, 23);
            this.SplitsButton.TabIndex = 2;
            this.SplitsButton.Text = "Splits";
            this.SplitsButton.UseVisualStyleBackColor = true;
            this.SplitsButton.Click += new System.EventHandler(this.SplitsButton_Click);
            // 
            // WorkoutPanel
            // 
            this.WorkoutPanel.Controls.Add(this.label3);
            this.WorkoutPanel.Location = new System.Drawing.Point(505, 4);
            this.WorkoutPanel.Name = "WorkoutPanel";
            this.WorkoutPanel.Size = new System.Drawing.Size(133, 21);
            this.WorkoutPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "workout";
            // 
            // SplitsPanel
            // 
            this.SplitsPanel.Controls.Add(this.EditSplitPanel);
            this.SplitsPanel.Controls.Add(this.RemoveSplitPanel);
            this.SplitsPanel.Controls.Add(this.AddSplitPanel);
            this.SplitsPanel.Controls.Add(this.RemoveSplitButton);
            this.SplitsPanel.Controls.Add(this.EditSplitButton);
            this.SplitsPanel.Controls.Add(this.AddSplitButton);
            this.SplitsPanel.Controls.Add(this.SplitsPanelLabel);
            this.SplitsPanel.Location = new System.Drawing.Point(2, 31);
            this.SplitsPanel.Name = "SplitsPanel";
            this.SplitsPanel.Size = new System.Drawing.Size(784, 489);
            this.SplitsPanel.TabIndex = 4;
            this.SplitsPanel.Visible = false;
            // 
            // AddSplitPanel
            // 
            this.AddSplitPanel.Controls.Add(this.DaysNumberAddSplitCB);
            this.AddSplitPanel.Controls.Add(this.listBoxAddSplit);
            this.AddSplitPanel.Controls.Add(this.SaveWorkoutAddSplitBTN);
            this.AddSplitPanel.Controls.Add(this.CancelAddSplitBTN);
            this.AddSplitPanel.Controls.Add(this.SaveAddSplitBTN);
            this.AddSplitPanel.Controls.Add(this.ClearAddSplitBTN);
            this.AddSplitPanel.Controls.Add(this.WorkoutNameAddSplitTB);
            this.AddSplitPanel.Controls.Add(this.DayAddSplitCB);
            this.AddSplitPanel.Controls.Add(this.SplitNameAddSplitTB);
            this.AddSplitPanel.Controls.Add(this.WorkoutNameAddSplitLBL);
            this.AddSplitPanel.Controls.Add(this.DayAddSplitLBL);
            this.AddSplitPanel.Controls.Add(this.DaysNumberAddSplitLBL);
            this.AddSplitPanel.Controls.Add(this.SplitNameAddSplitLBL);
            this.AddSplitPanel.Location = new System.Drawing.Point(4, 33);
            this.AddSplitPanel.Name = "AddSplitPanel";
            this.AddSplitPanel.Size = new System.Drawing.Size(777, 453);
            this.AddSplitPanel.TabIndex = 10;
            // 
            // DaysNumberAddSplitCB
            // 
            this.DaysNumberAddSplitCB.FormattingEnabled = true;
            this.DaysNumberAddSplitCB.Location = new System.Drawing.Point(98, 44);
            this.DaysNumberAddSplitCB.Name = "DaysNumberAddSplitCB";
            this.DaysNumberAddSplitCB.Size = new System.Drawing.Size(66, 21);
            this.DaysNumberAddSplitCB.TabIndex = 14;
            this.DaysNumberAddSplitCB.SelectedIndexChanged += new System.EventHandler(this.DaysNumberAddSplitCB_SelectedIndexChanged);
            // 
            // listBoxAddSplit
            // 
            this.listBoxAddSplit.FormattingEnabled = true;
            this.listBoxAddSplit.Location = new System.Drawing.Point(98, 135);
            this.listBoxAddSplit.Name = "listBoxAddSplit";
            this.listBoxAddSplit.Size = new System.Drawing.Size(121, 212);
            this.listBoxAddSplit.TabIndex = 13;
            // 
            // SaveWorkoutAddSplitBTN
            // 
            this.SaveWorkoutAddSplitBTN.Location = new System.Drawing.Point(225, 107);
            this.SaveWorkoutAddSplitBTN.Name = "SaveWorkoutAddSplitBTN";
            this.SaveWorkoutAddSplitBTN.Size = new System.Drawing.Size(92, 23);
            this.SaveWorkoutAddSplitBTN.TabIndex = 12;
            this.SaveWorkoutAddSplitBTN.Text = "Save Workout";
            this.SaveWorkoutAddSplitBTN.UseVisualStyleBackColor = true;
            this.SaveWorkoutAddSplitBTN.Click += new System.EventHandler(this.SaveWorkoutAddSplitBTN_Click);
            // 
            // CancelAddSplitBTN
            // 
            this.CancelAddSplitBTN.Location = new System.Drawing.Point(696, 423);
            this.CancelAddSplitBTN.Name = "CancelAddSplitBTN";
            this.CancelAddSplitBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelAddSplitBTN.TabIndex = 10;
            this.CancelAddSplitBTN.Text = "Cancel";
            this.CancelAddSplitBTN.UseVisualStyleBackColor = true;
            this.CancelAddSplitBTN.Click += new System.EventHandler(this.CancelAddSplitBTN_Click_1);
            // 
            // SaveAddSplitBTN
            // 
            this.SaveAddSplitBTN.Location = new System.Drawing.Point(615, 423);
            this.SaveAddSplitBTN.Name = "SaveAddSplitBTN";
            this.SaveAddSplitBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveAddSplitBTN.TabIndex = 9;
            this.SaveAddSplitBTN.Text = "Save";
            this.SaveAddSplitBTN.UseVisualStyleBackColor = true;
            this.SaveAddSplitBTN.Click += new System.EventHandler(this.SaveAddSplitBTN_Click);
            // 
            // ClearAddSplitBTN
            // 
            this.ClearAddSplitBTN.Location = new System.Drawing.Point(5, 423);
            this.ClearAddSplitBTN.Name = "ClearAddSplitBTN";
            this.ClearAddSplitBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearAddSplitBTN.TabIndex = 8;
            this.ClearAddSplitBTN.Text = "Clear";
            this.ClearAddSplitBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClearAddSplitBTN.UseVisualStyleBackColor = true;
            this.ClearAddSplitBTN.Click += new System.EventHandler(this.ClearAddSplitBTN_Click);
            // 
            // WorkoutNameAddSplitTB
            // 
            this.WorkoutNameAddSplitTB.Location = new System.Drawing.Point(98, 109);
            this.WorkoutNameAddSplitTB.Name = "WorkoutNameAddSplitTB";
            this.WorkoutNameAddSplitTB.Size = new System.Drawing.Size(121, 20);
            this.WorkoutNameAddSplitTB.TabIndex = 7;
            // 
            // DayAddSplitCB
            // 
            this.DayAddSplitCB.FormattingEnabled = true;
            this.DayAddSplitCB.Location = new System.Drawing.Point(98, 76);
            this.DayAddSplitCB.Name = "DayAddSplitCB";
            this.DayAddSplitCB.Size = new System.Drawing.Size(66, 21);
            this.DayAddSplitCB.TabIndex = 6;
            this.DayAddSplitCB.SelectedIndexChanged += new System.EventHandler(this.DayAddSplitCB_SelectedIndexChanged);
            // 
            // SplitNameAddSplitTB
            // 
            this.SplitNameAddSplitTB.Location = new System.Drawing.Point(98, 12);
            this.SplitNameAddSplitTB.Name = "SplitNameAddSplitTB";
            this.SplitNameAddSplitTB.Size = new System.Drawing.Size(147, 20);
            this.SplitNameAddSplitTB.TabIndex = 4;
            // 
            // WorkoutNameAddSplitLBL
            // 
            this.WorkoutNameAddSplitLBL.AutoSize = true;
            this.WorkoutNameAddSplitLBL.Location = new System.Drawing.Point(6, 112);
            this.WorkoutNameAddSplitLBL.Name = "WorkoutNameAddSplitLBL";
            this.WorkoutNameAddSplitLBL.Size = new System.Drawing.Size(82, 13);
            this.WorkoutNameAddSplitLBL.TabIndex = 3;
            this.WorkoutNameAddSplitLBL.Text = "Workout Name:";
            // 
            // DayAddSplitLBL
            // 
            this.DayAddSplitLBL.AutoSize = true;
            this.DayAddSplitLBL.Location = new System.Drawing.Point(6, 79);
            this.DayAddSplitLBL.Name = "DayAddSplitLBL";
            this.DayAddSplitLBL.Size = new System.Drawing.Size(29, 13);
            this.DayAddSplitLBL.TabIndex = 2;
            this.DayAddSplitLBL.Text = "Day:";
            // 
            // DaysNumberAddSplitLBL
            // 
            this.DaysNumberAddSplitLBL.AutoSize = true;
            this.DaysNumberAddSplitLBL.Location = new System.Drawing.Point(6, 47);
            this.DaysNumberAddSplitLBL.Name = "DaysNumberAddSplitLBL";
            this.DaysNumberAddSplitLBL.Size = new System.Drawing.Size(74, 13);
            this.DaysNumberAddSplitLBL.TabIndex = 1;
            this.DaysNumberAddSplitLBL.Text = "Days Number:";
            // 
            // SplitNameAddSplitLBL
            // 
            this.SplitNameAddSplitLBL.AutoSize = true;
            this.SplitNameAddSplitLBL.Location = new System.Drawing.Point(6, 12);
            this.SplitNameAddSplitLBL.Name = "SplitNameAddSplitLBL";
            this.SplitNameAddSplitLBL.Size = new System.Drawing.Size(61, 13);
            this.SplitNameAddSplitLBL.TabIndex = 0;
            this.SplitNameAddSplitLBL.Text = "Split Name:";
            // 
            // RemoveSplitButton
            // 
            this.RemoveSplitButton.Location = new System.Drawing.Point(162, 3);
            this.RemoveSplitButton.Name = "RemoveSplitButton";
            this.RemoveSplitButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSplitButton.TabIndex = 9;
            this.RemoveSplitButton.Text = "RemoveSplit";
            this.RemoveSplitButton.UseVisualStyleBackColor = true;
            this.RemoveSplitButton.Click += new System.EventHandler(this.RemoveSplitButton_Click);
            // 
            // EditSplitButton
            // 
            this.EditSplitButton.Location = new System.Drawing.Point(81, 2);
            this.EditSplitButton.Name = "EditSplitButton";
            this.EditSplitButton.Size = new System.Drawing.Size(75, 23);
            this.EditSplitButton.TabIndex = 8;
            this.EditSplitButton.Text = "Edit Split";
            this.EditSplitButton.UseVisualStyleBackColor = true;
            this.EditSplitButton.Click += new System.EventHandler(this.EditSplitButton_Click);
            // 
            // AddSplitButton
            // 
            this.AddSplitButton.Location = new System.Drawing.Point(0, 3);
            this.AddSplitButton.Name = "AddSplitButton";
            this.AddSplitButton.Size = new System.Drawing.Size(75, 23);
            this.AddSplitButton.TabIndex = 6;
            this.AddSplitButton.Text = "Add Split";
            this.AddSplitButton.UseVisualStyleBackColor = true;
            this.AddSplitButton.Click += new System.EventHandler(this.AddSplitButton_Click);
            // 
            // SplitsPanelLabel
            // 
            this.SplitsPanelLabel.AutoSize = true;
            this.SplitsPanelLabel.Location = new System.Drawing.Point(713, 8);
            this.SplitsPanelLabel.Name = "SplitsPanelLabel";
            this.SplitsPanelLabel.Size = new System.Drawing.Size(62, 13);
            this.SplitsPanelLabel.TabIndex = 7;
            this.SplitsPanelLabel.Text = "Splits Panel";
            // 
            // TrackPanel
            // 
            this.TrackPanel.Controls.Add(this.label1);
            this.TrackPanel.Location = new System.Drawing.Point(687, 4);
            this.TrackPanel.Name = "TrackPanel";
            this.TrackPanel.Size = new System.Drawing.Size(67, 27);
            this.TrackPanel.TabIndex = 5;
            this.TrackPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Track";
            // 
            // RemoveSplitPanel
            // 
            this.RemoveSplitPanel.Controls.Add(this.DeleteSplitRemoveSplitBTN);
            this.RemoveSplitPanel.Controls.Add(this.DaysRemoveSplitLV);
            this.RemoveSplitPanel.Controls.Add(this.SplitsRemoveSplitLV);
            this.RemoveSplitPanel.Location = new System.Drawing.Point(3, 31);
            this.RemoveSplitPanel.Name = "RemoveSplitPanel";
            this.RemoveSplitPanel.Size = new System.Drawing.Size(777, 453);
            this.RemoveSplitPanel.TabIndex = 15;
            this.RemoveSplitPanel.Visible = false;
            // 
            // SplitsRemoveSplitLV
            // 
            this.SplitsRemoveSplitLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SplitNameSplitsRemoveSplitLV,
            this.DaysNumberSplitsRemoveSplitLV});
            this.SplitsRemoveSplitLV.HideSelection = false;
            this.SplitsRemoveSplitLV.Location = new System.Drawing.Point(8, 29);
            this.SplitsRemoveSplitLV.MultiSelect = false;
            this.SplitsRemoveSplitLV.Name = "SplitsRemoveSplitLV";
            this.SplitsRemoveSplitLV.Size = new System.Drawing.Size(255, 303);
            this.SplitsRemoveSplitLV.TabIndex = 0;
            this.SplitsRemoveSplitLV.UseCompatibleStateImageBehavior = false;
            this.SplitsRemoveSplitLV.View = System.Windows.Forms.View.Details;
            this.SplitsRemoveSplitLV.SelectedIndexChanged += new System.EventHandler(this.SplitsRemoveSplitLV_SelectedIndexChanged);
            // 
            // DaysRemoveSplitLV
            // 
            this.DaysRemoveSplitLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayDaysRemoveSplitLV,
            this.WorkoutDaysRemoveSplitLV});
            this.DaysRemoveSplitLV.HideSelection = false;
            this.DaysRemoveSplitLV.Location = new System.Drawing.Point(269, 29);
            this.DaysRemoveSplitLV.Name = "DaysRemoveSplitLV";
            this.DaysRemoveSplitLV.Size = new System.Drawing.Size(494, 303);
            this.DaysRemoveSplitLV.TabIndex = 1;
            this.DaysRemoveSplitLV.UseCompatibleStateImageBehavior = false;
            this.DaysRemoveSplitLV.View = System.Windows.Forms.View.Details;
            // 
            // SplitNameSplitsRemoveSplitLV
            // 
            this.SplitNameSplitsRemoveSplitLV.Text = "Split Name";
            this.SplitNameSplitsRemoveSplitLV.Width = 200;
            // 
            // DaysNumberSplitsRemoveSplitLV
            // 
            this.DaysNumberSplitsRemoveSplitLV.Text = "Days";
            this.DaysNumberSplitsRemoveSplitLV.Width = 45;
            // 
            // DayDaysRemoveSplitLV
            // 
            this.DayDaysRemoveSplitLV.Text = "Day";
            this.DayDaysRemoveSplitLV.Width = 40;
            // 
            // WorkoutDaysRemoveSplitLV
            // 
            this.WorkoutDaysRemoveSplitLV.Text = "Workouts";
            this.WorkoutDaysRemoveSplitLV.Width = 450;
            // 
            // DeleteSplitRemoveSplitBTN
            // 
            this.DeleteSplitRemoveSplitBTN.Location = new System.Drawing.Point(688, 338);
            this.DeleteSplitRemoveSplitBTN.Name = "DeleteSplitRemoveSplitBTN";
            this.DeleteSplitRemoveSplitBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteSplitRemoveSplitBTN.TabIndex = 2;
            this.DeleteSplitRemoveSplitBTN.Text = "Delete Split";
            this.DeleteSplitRemoveSplitBTN.UseVisualStyleBackColor = true;
            this.DeleteSplitRemoveSplitBTN.Click += new System.EventHandler(this.DeleteSplitRemoveSplitBTN_Click);
            // 
            // EditSplitPanel
            // 
            this.EditSplitPanel.Controls.Add(this.SplitsESLB);
            this.EditSplitPanel.Controls.Add(this.DaysNumberESCB);
            this.EditSplitPanel.Controls.Add(this.WorkoutESLB);
            this.EditSplitPanel.Controls.Add(this.WorkoutNameESTB);
            this.EditSplitPanel.Controls.Add(this.DayESCB);
            this.EditSplitPanel.Controls.Add(this.SplitNameESTB);
            this.EditSplitPanel.Controls.Add(this.label2);
            this.EditSplitPanel.Controls.Add(this.label4);
            this.EditSplitPanel.Controls.Add(this.label5);
            this.EditSplitPanel.Controls.Add(this.label6);
            this.EditSplitPanel.Location = new System.Drawing.Point(1, 28);
            this.EditSplitPanel.Name = "EditSplitPanel";
            this.EditSplitPanel.Size = new System.Drawing.Size(780, 453);
            this.EditSplitPanel.TabIndex = 3;
            this.EditSplitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EditSplitPanel_Paint);
            // 
            // DaysNumberESCB
            // 
            this.DaysNumberESCB.FormattingEnabled = true;
            this.DaysNumberESCB.Location = new System.Drawing.Point(296, 38);
            this.DaysNumberESCB.Name = "DaysNumberESCB";
            this.DaysNumberESCB.Size = new System.Drawing.Size(66, 21);
            this.DaysNumberESCB.TabIndex = 23;
            // 
            // WorkoutESLB
            // 
            this.WorkoutESLB.FormattingEnabled = true;
            this.WorkoutESLB.Location = new System.Drawing.Point(296, 129);
            this.WorkoutESLB.Name = "WorkoutESLB";
            this.WorkoutESLB.Size = new System.Drawing.Size(121, 212);
            this.WorkoutESLB.TabIndex = 22;
            // 
            // WorkoutNameESTB
            // 
            this.WorkoutNameESTB.Location = new System.Drawing.Point(296, 103);
            this.WorkoutNameESTB.Name = "WorkoutNameESTB";
            this.WorkoutNameESTB.Size = new System.Drawing.Size(121, 20);
            this.WorkoutNameESTB.TabIndex = 21;
            // 
            // DayESCB
            // 
            this.DayESCB.FormattingEnabled = true;
            this.DayESCB.Location = new System.Drawing.Point(296, 70);
            this.DayESCB.Name = "DayESCB";
            this.DayESCB.Size = new System.Drawing.Size(66, 21);
            this.DayESCB.TabIndex = 20;
            // 
            // SplitNameESTB
            // 
            this.SplitNameESTB.Location = new System.Drawing.Point(296, 6);
            this.SplitNameESTB.Name = "SplitNameESTB";
            this.SplitNameESTB.Size = new System.Drawing.Size(147, 20);
            this.SplitNameESTB.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Workout Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Days Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Split Name:";
            // 
            // SplitsESLB
            // 
            this.SplitsESLB.FormattingEnabled = true;
            this.SplitsESLB.Location = new System.Drawing.Point(6, 7);
            this.SplitsESLB.Name = "SplitsESLB";
            this.SplitsESLB.Size = new System.Drawing.Size(192, 446);
            this.SplitsESLB.TabIndex = 24;
            this.SplitsESLB.SelectedIndexChanged += new System.EventHandler(this.SplitsESLB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 522);
            this.Controls.Add(this.SplitsPanel);
            this.Controls.Add(this.TrackPanel);
            this.Controls.Add(this.WorkoutPanel);
            this.Controls.Add(this.SplitsButton);
            this.Controls.Add(this.WorkoutButton);
            this.Controls.Add(this.TrackButton);
            this.MaximumSize = new System.Drawing.Size(805, 561);
            this.MinimumSize = new System.Drawing.Size(805, 561);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WorkoutPanel.ResumeLayout(false);
            this.WorkoutPanel.PerformLayout();
            this.SplitsPanel.ResumeLayout(false);
            this.SplitsPanel.PerformLayout();
            this.AddSplitPanel.ResumeLayout(false);
            this.AddSplitPanel.PerformLayout();
            this.TrackPanel.ResumeLayout(false);
            this.TrackPanel.PerformLayout();
            this.RemoveSplitPanel.ResumeLayout(false);
            this.EditSplitPanel.ResumeLayout(false);
            this.EditSplitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrackButton;
        private System.Windows.Forms.Button WorkoutButton;
        private System.Windows.Forms.Button SplitsButton;
        private System.Windows.Forms.Panel WorkoutPanel;
        private System.Windows.Forms.Panel SplitsPanel;
        private System.Windows.Forms.Panel TrackPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SplitsPanelLabel;
        private System.Windows.Forms.Button RemoveSplitButton;
        private System.Windows.Forms.Button EditSplitButton;
        private System.Windows.Forms.Button AddSplitButton;
        private System.Windows.Forms.Panel AddSplitPanel;
        private System.Windows.Forms.Button CancelAddSplitBTN;
        private System.Windows.Forms.Button SaveAddSplitBTN;
        private System.Windows.Forms.Button ClearAddSplitBTN;
        private System.Windows.Forms.TextBox WorkoutNameAddSplitTB;
        private System.Windows.Forms.ComboBox DayAddSplitCB;
        private System.Windows.Forms.TextBox SplitNameAddSplitTB;
        private System.Windows.Forms.Label WorkoutNameAddSplitLBL;
        private System.Windows.Forms.Label DayAddSplitLBL;
        private System.Windows.Forms.Label DaysNumberAddSplitLBL;
        private System.Windows.Forms.Label SplitNameAddSplitLBL;
        private System.Windows.Forms.Button SaveWorkoutAddSplitBTN;
        private System.Windows.Forms.ListBox listBoxAddSplit;
        private System.Windows.Forms.ComboBox DaysNumberAddSplitCB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel RemoveSplitPanel;
        private System.Windows.Forms.ListView DaysRemoveSplitLV;
        private System.Windows.Forms.ListView SplitsRemoveSplitLV;
        private System.Windows.Forms.ColumnHeader SplitNameSplitsRemoveSplitLV;
        private System.Windows.Forms.ColumnHeader DaysNumberSplitsRemoveSplitLV;
        private System.Windows.Forms.ColumnHeader DayDaysRemoveSplitLV;
        private System.Windows.Forms.ColumnHeader WorkoutDaysRemoveSplitLV;
        private System.Windows.Forms.Button DeleteSplitRemoveSplitBTN;
        private System.Windows.Forms.Panel EditSplitPanel;
        private System.Windows.Forms.ComboBox DaysNumberESCB;
        private System.Windows.Forms.ListBox WorkoutESLB;
        private System.Windows.Forms.TextBox WorkoutNameESTB;
        private System.Windows.Forms.ComboBox DayESCB;
        private System.Windows.Forms.TextBox SplitNameESTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox SplitsESLB;
    }
}

