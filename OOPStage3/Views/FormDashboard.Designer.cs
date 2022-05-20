namespace OOPStage3.Views
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAvgMark = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.Hellolabel = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.labelEditUsers = new System.Windows.Forms.Label();
            this.labelShowGrades = new System.Windows.Forms.Label();
            this.labelShowGraphs = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Disciplines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotViewGrades = new OxyPlot.WindowsForms.PlotView();
            this.listBoxStaffNGrades = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.listBoxParents = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxNext);
            this.panel1.Controls.Add(this.pictureBoxBack);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelAvgMark);
            this.panel1.Controls.Add(this.labelGroup);
            this.panel1.Location = new System.Drawing.Point(711, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 188);
            this.panel1.TabIndex = 13;
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.Image = global::OOPStage3.Properties.Resources.right_arrow;
            this.pictureBoxNext.Location = new System.Drawing.Point(387, 144);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 16;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Visible = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click_1);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::OOPStage3.Properties.Resources.left_arrow;
            this.pictureBoxBack.Location = new System.Drawing.Point(329, 144);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 15;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Visible = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click_1);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(15, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 26);
            this.labelID.TabIndex = 5;
            // 
            // labelAvgMark
            // 
            this.labelAvgMark.AutoSize = true;
            this.labelAvgMark.BackColor = System.Drawing.Color.Transparent;
            this.labelAvgMark.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAvgMark.Location = new System.Drawing.Point(15, 98);
            this.labelAvgMark.Name = "labelAvgMark";
            this.labelAvgMark.Size = new System.Drawing.Size(0, 26);
            this.labelAvgMark.TabIndex = 4;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.BackColor = System.Drawing.Color.Transparent;
            this.labelGroup.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.Location = new System.Drawing.Point(15, 15);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(110, 26);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "This is test";
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.BackColor = System.Drawing.Color.Transparent;
            this.Hellolabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hellolabel.Location = new System.Drawing.Point(289, 27);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(64, 26);
            this.Hellolabel.TabIndex = 12;
            this.Hellolabel.Text = "label1";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNavigation.Controls.Add(this.labelEditUsers);
            this.panelNavigation.Controls.Add(this.labelShowGrades);
            this.panelNavigation.Controls.Add(this.labelShowGraphs);
            this.panelNavigation.Controls.Add(this.labelSettings);
            this.panelNavigation.Controls.Add(this.labelCalendar);
            this.panelNavigation.Controls.Add(this.pictureBox1);
            this.panelNavigation.Location = new System.Drawing.Point(-2, -3);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(264, 748);
            this.panelNavigation.TabIndex = 11;
            // 
            // labelEditUsers
            // 
            this.labelEditUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelEditUsers.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditUsers.Location = new System.Drawing.Point(3, 369);
            this.labelEditUsers.Name = "labelEditUsers";
            this.labelEditUsers.Size = new System.Drawing.Size(261, 41);
            this.labelEditUsers.TabIndex = 15;
            this.labelEditUsers.Text = "Edit Users";
            this.labelEditUsers.Visible = false;
            this.labelEditUsers.Click += new System.EventHandler(this.LabelEditUsers_Click_1);
            // 
            // labelShowGrades
            // 
            this.labelShowGrades.BackColor = System.Drawing.Color.Transparent;
            this.labelShowGrades.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShowGrades.Location = new System.Drawing.Point(3, 328);
            this.labelShowGrades.Name = "labelShowGrades";
            this.labelShowGrades.Size = new System.Drawing.Size(261, 41);
            this.labelShowGrades.TabIndex = 13;
            this.labelShowGrades.Text = "Show Grades";
            this.labelShowGrades.Visible = false;
            this.labelShowGrades.Click += new System.EventHandler(this.LabelShowGrades_Click_1);
            // 
            // labelShowGraphs
            // 
            this.labelShowGraphs.BackColor = System.Drawing.Color.Transparent;
            this.labelShowGraphs.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShowGraphs.Location = new System.Drawing.Point(3, 287);
            this.labelShowGraphs.Name = "labelShowGraphs";
            this.labelShowGraphs.Size = new System.Drawing.Size(261, 41);
            this.labelShowGraphs.TabIndex = 12;
            this.labelShowGraphs.Text = "Show Graphs";
            this.labelShowGraphs.Visible = false;
            this.labelShowGraphs.Click += new System.EventHandler(this.LabelShowGraphs_Click_1);
            // 
            // labelSettings
            // 
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSettings.Location = new System.Drawing.Point(3, 606);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(258, 41);
            this.labelSettings.TabIndex = 10;
            this.labelSettings.Text = "Settings";
            this.labelSettings.Click += new System.EventHandler(this.LabelSettings_Click);
            // 
            // labelCalendar
            // 
            this.labelCalendar.BackColor = System.Drawing.Color.Transparent;
            this.labelCalendar.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCalendar.Location = new System.Drawing.Point(3, 246);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(261, 41);
            this.labelCalendar.TabIndex = 8;
            this.labelCalendar.Text = "Calendar";
            this.labelCalendar.Click += new System.EventHandler(this.LabelCalendar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 263);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disciplines,
            this.firstSem,
            this.secondSem,
            this.last2});
            this.dataGridView1.Location = new System.Drawing.Point(268, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(893, 425);
            this.dataGridView1.TabIndex = 14;
            // 
            // Disciplines
            // 
            this.Disciplines.HeaderText = "Subject";
            this.Disciplines.Name = "Disciplines";
            this.Disciplines.Width = 200;
            // 
            // firstSem
            // 
            this.firstSem.HeaderText = "First Semester";
            this.firstSem.Name = "firstSem";
            this.firstSem.Width = 250;
            // 
            // secondSem
            // 
            this.secondSem.HeaderText = "Second Semester";
            this.secondSem.Name = "secondSem";
            this.secondSem.Width = 250;
            // 
            // last2
            // 
            this.last2.HeaderText = "Last Two Semesters";
            this.last2.Name = "last2";
            this.last2.Width = 150;
            // 
            // plotViewGrades
            // 
            this.plotViewGrades.BackColor = System.Drawing.Color.IndianRed;
            this.plotViewGrades.Location = new System.Drawing.Point(268, 226);
            this.plotViewGrades.Name = "plotViewGrades";
            this.plotViewGrades.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewGrades.Size = new System.Drawing.Size(893, 422);
            this.plotViewGrades.TabIndex = 15;
            this.plotViewGrades.Text = "plotView1";
            this.plotViewGrades.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewGrades.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewGrades.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // listBoxStaffNGrades
            // 
            this.listBoxStaffNGrades.BackColor = System.Drawing.Color.White;
            this.listBoxStaffNGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStaffNGrades.ForeColor = System.Drawing.Color.White;
            this.listBoxStaffNGrades.FormattingEnabled = true;
            this.listBoxStaffNGrades.ItemHeight = 15;
            this.listBoxStaffNGrades.Location = new System.Drawing.Point(268, 227);
            this.listBoxStaffNGrades.Name = "listBoxStaffNGrades";
            this.listBoxStaffNGrades.Size = new System.Drawing.Size(280, 420);
            this.listBoxStaffNGrades.TabIndex = 16;
            this.listBoxStaffNGrades.Visible = false;
            this.listBoxStaffNGrades.DoubleClick += new System.EventHandler(this.listBoxStaffNGrades_DoubleClick);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStudents.ForeColor = System.Drawing.Color.White;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 15;
            this.listBoxStudents.Location = new System.Drawing.Point(572, 227);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(280, 420);
            this.listBoxStudents.TabIndex = 17;
            this.listBoxStudents.Visible = false;
            this.listBoxStudents.DoubleClick += new System.EventHandler(this.listBoxStudents_DoubleClick);
            // 
            // listBoxParents
            // 
            this.listBoxParents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxParents.ForeColor = System.Drawing.Color.White;
            this.listBoxParents.FormattingEnabled = true;
            this.listBoxParents.ItemHeight = 15;
            this.listBoxParents.Location = new System.Drawing.Point(881, 227);
            this.listBoxParents.Name = "listBoxParents";
            this.listBoxParents.Size = new System.Drawing.Size(280, 420);
            this.listBoxParents.TabIndex = 18;
            this.listBoxParents.Visible = false;
            this.listBoxParents.DoubleClick += new System.EventHandler(this.listBoxParents_DoubleClick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 659);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hellolabel);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.listBoxParents);
            this.Controls.Add(this.listBoxStaffNGrades);
            this.Controls.Add(this.plotViewGrades);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        public System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAvgMark;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label Hellolabel;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label labelEditUsers;
        private System.Windows.Forms.Label labelShowGrades;
        private System.Windows.Forms.Label labelShowGraphs;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplines;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn last2;
        private OxyPlot.WindowsForms.PlotView plotViewGrades;
        private System.Windows.Forms.ListBox listBoxStaffNGrades;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ListBox listBoxParents;
    }
}