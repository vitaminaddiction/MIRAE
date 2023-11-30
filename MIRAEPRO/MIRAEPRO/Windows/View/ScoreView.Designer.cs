namespace MIRAEPRO.Windows.View
{
    partial class ScoreView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbox_testname = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbox_name = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.testnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koreanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dset_score = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 85);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_menu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_menu.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu.Location = new System.Drawing.Point(397, 13);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(378, 59);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "돌아가기";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 28);
            this.panel2.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtp_end);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(716, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(4);
            this.panel10.Size = new System.Drawing.Size(179, 28);
            this.panel10.TabIndex = 6;
            // 
            // dtp_end
            // 
            this.dtp_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_end.Location = new System.Drawing.Point(4, 4);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(171, 21);
            this.dtp_end.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_select);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(996, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(4);
            this.panel9.Size = new System.Drawing.Size(179, 28);
            this.panel9.TabIndex = 5;
            // 
            // btn_select
            // 
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_select.Location = new System.Drawing.Point(4, 4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(171, 20);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(537, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(4);
            this.panel8.Size = new System.Drawing.Size(179, 28);
            this.panel8.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtp_start);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(358, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4);
            this.panel7.Size = new System.Drawing.Size(179, 28);
            this.panel7.TabIndex = 3;
            // 
            // dtp_start
            // 
            this.dtp_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_start.Location = new System.Drawing.Point(4, 4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(171, 21);
            this.dtp_start.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbox_testname);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(179, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(179, 28);
            this.panel6.TabIndex = 2;
            // 
            // cbox_testname
            // 
            this.cbox_testname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_testname.FormattingEnabled = true;
            this.cbox_testname.Items.AddRange(new object[] {
            "평가원",
            "사설"});
            this.cbox_testname.Location = new System.Drawing.Point(4, 4);
            this.cbox_testname.Name = "cbox_testname";
            this.cbox_testname.Size = new System.Drawing.Size(171, 20);
            this.cbox_testname.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(179, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 28);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbox_name);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(179, 28);
            this.panel4.TabIndex = 0;
            // 
            // cbox_name
            // 
            this.cbox_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_name.FormattingEnabled = true;
            this.cbox_name.Items.AddRange(new object[] {
            "시간별",
            "시험별"});
            this.cbox_name.Location = new System.Drawing.Point(4, 4);
            this.cbox_name.Name = "cbox_name";
            this.cbox_name.Size = new System.Drawing.Size(171, 20);
            this.cbox_name.TabIndex = 0;
            this.cbox_name.SelectedIndexChanged += new System.EventHandler(this.cbox_name_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_main);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 478);
            this.panel3.TabIndex = 3;
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.AutoGenerateColumns = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testnameDataGridViewTextBoxColumn,
            this.datetestDataGridViewTextBoxColumn,
            this.stdnameDataGridViewTextBoxColumn,
            this.koreanDataGridViewTextBoxColumn,
            this.mathDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.historyDataGridViewTextBoxColumn,
            this.socialDataGridViewTextBoxColumn,
            this.scienceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgv_main.DataMember = "scorebydate";
            this.dgv_main.DataSource = this.dset_score;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(0, 0);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.RowTemplate.Height = 23;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(1175, 478);
            this.dgv_main.TabIndex = 0;
            // 
            // testnameDataGridViewTextBoxColumn
            // 
            this.testnameDataGridViewTextBoxColumn.DataPropertyName = "test_name";
            this.testnameDataGridViewTextBoxColumn.HeaderText = "시험명";
            this.testnameDataGridViewTextBoxColumn.Name = "testnameDataGridViewTextBoxColumn";
            this.testnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetestDataGridViewTextBoxColumn
            // 
            this.datetestDataGridViewTextBoxColumn.DataPropertyName = "date_test";
            this.datetestDataGridViewTextBoxColumn.HeaderText = "일시";
            this.datetestDataGridViewTextBoxColumn.Name = "datetestDataGridViewTextBoxColumn";
            this.datetestDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetestDataGridViewTextBoxColumn.Width = 200;
            // 
            // stdnameDataGridViewTextBoxColumn
            // 
            this.stdnameDataGridViewTextBoxColumn.DataPropertyName = "std_name";
            this.stdnameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.stdnameDataGridViewTextBoxColumn.Name = "stdnameDataGridViewTextBoxColumn";
            this.stdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koreanDataGridViewTextBoxColumn
            // 
            this.koreanDataGridViewTextBoxColumn.DataPropertyName = "korean";
            this.koreanDataGridViewTextBoxColumn.HeaderText = "언어";
            this.koreanDataGridViewTextBoxColumn.Name = "koreanDataGridViewTextBoxColumn";
            this.koreanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mathDataGridViewTextBoxColumn
            // 
            this.mathDataGridViewTextBoxColumn.DataPropertyName = "math";
            this.mathDataGridViewTextBoxColumn.HeaderText = "수리";
            this.mathDataGridViewTextBoxColumn.Name = "mathDataGridViewTextBoxColumn";
            this.mathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "english";
            this.englishDataGridViewTextBoxColumn.HeaderText = "외국어";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            this.englishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historyDataGridViewTextBoxColumn
            // 
            this.historyDataGridViewTextBoxColumn.DataPropertyName = "history";
            this.historyDataGridViewTextBoxColumn.HeaderText = "국사";
            this.historyDataGridViewTextBoxColumn.Name = "historyDataGridViewTextBoxColumn";
            this.historyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socialDataGridViewTextBoxColumn
            // 
            this.socialDataGridViewTextBoxColumn.DataPropertyName = "social";
            this.socialDataGridViewTextBoxColumn.HeaderText = "사회탐구";
            this.socialDataGridViewTextBoxColumn.Name = "socialDataGridViewTextBoxColumn";
            this.socialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scienceDataGridViewTextBoxColumn
            // 
            this.scienceDataGridViewTextBoxColumn.DataPropertyName = "science";
            this.scienceDataGridViewTextBoxColumn.HeaderText = "과학탐구";
            this.scienceDataGridViewTextBoxColumn.Name = "scienceDataGridViewTextBoxColumn";
            this.scienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "총점";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dset_score
            // 
            this.dset_score.DataSetName = "NewDataSet";
            this.dset_score.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.dataTable1.TableName = "scorebydate";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "test_name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "date_test";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "std_name";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "korean";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "math";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "english";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "history";
            this.dataColumn7.DataType = typeof(int);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "social";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "science";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "total";
            this.dataColumn10.DataType = typeof(int);
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScoreView";
            this.Text = "ScoreView";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.ComboBox cbox_testname;
        private System.Windows.Forms.ComboBox cbox_name;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Data.DataSet dset_score;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn testnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koreanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}