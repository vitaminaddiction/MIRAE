namespace MIRAEPRO.Windows.View
{
    partial class ChoolSeokView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.dset_chool = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.이름 = new System.Data.DataColumn();
            this.아이디 = new System.Data.DataColumn();
            this.학급 = new System.Data.DataColumn();
            this.입실시간 = new System.Data.DataColumn();
            this.퇴실시간 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.tempcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choolchkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_attendance = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_chool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 85);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1299, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(439, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "돌아가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 28);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28938F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel11, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_select);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1113, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(183, 22);
            this.panel11.TabIndex = 7;
            // 
            // btn_select
            // 
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_select.Location = new System.Drawing.Point(0, 0);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(183, 22);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtp_end);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(373, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 22);
            this.panel6.TabIndex = 2;
            // 
            // dtp_end
            // 
            this.dtp_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_end.Location = new System.Drawing.Point(0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(179, 21);
            this.dtp_end.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(188, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 22);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtp_start);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 22);
            this.panel4.TabIndex = 0;
            // 
            // dtp_start
            // 
            this.dtp_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_start.Location = new System.Drawing.Point(0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(179, 21);
            this.dtp_start.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_main);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 492);
            this.panel3.TabIndex = 2;
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
            this.tempcalDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hnameDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.datetimeinDataGridViewTextBoxColumn,
            this.datetimeoutDataGridViewTextBoxColumn,
            this.schnameDataGridViewTextBoxColumn,
            this.choolchkDataGridViewTextBoxColumn});
            this.dgv_main.DataMember = "ChoolSeok";
            this.dgv_main.DataSource = this.dset_chool;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(0, 0);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.RowTemplate.Height = 23;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(1299, 492);
            this.dgv_main.TabIndex = 0;
            // 
            // dset_chool
            // 
            this.dset_chool.DataSetName = "NewDataSet";
            this.dset_chool.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.이름,
            this.아이디,
            this.학급,
            this.입실시간,
            this.퇴실시간,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "ChoolSeok";
            // 
            // 이름
            // 
            this.이름.ColumnName = "temp_cal";
            this.이름.DataType = typeof(System.DateTime);
            // 
            // 아이디
            // 
            this.아이디.ColumnName = "name";
            // 
            // 학급
            // 
            this.학급.ColumnName = "h_name";
            // 
            // 입실시간
            // 
            this.입실시간.ColumnName = "student_id";
            // 
            // 퇴실시간
            // 
            this.퇴실시간.ColumnName = "datetime_in";
            this.퇴실시간.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "datetime_out";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "sch_name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "choolchk";
            // 
            // tempcalDataGridViewTextBoxColumn
            // 
            this.tempcalDataGridViewTextBoxColumn.DataPropertyName = "temp_cal";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.tempcalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tempcalDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.tempcalDataGridViewTextBoxColumn.Name = "tempcalDataGridViewTextBoxColumn";
            this.tempcalDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempcalDataGridViewTextBoxColumn.Width = 250;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hnameDataGridViewTextBoxColumn
            // 
            this.hnameDataGridViewTextBoxColumn.DataPropertyName = "h_name";
            this.hnameDataGridViewTextBoxColumn.HeaderText = "학급명";
            this.hnameDataGridViewTextBoxColumn.Name = "hnameDataGridViewTextBoxColumn";
            this.hnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "아이디";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeinDataGridViewTextBoxColumn
            // 
            this.datetimeinDataGridViewTextBoxColumn.DataPropertyName = "datetime_in";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.datetimeinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.datetimeinDataGridViewTextBoxColumn.HeaderText = "입실시간";
            this.datetimeinDataGridViewTextBoxColumn.Name = "datetimeinDataGridViewTextBoxColumn";
            this.datetimeinDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeinDataGridViewTextBoxColumn.Width = 150;
            // 
            // datetimeoutDataGridViewTextBoxColumn
            // 
            this.datetimeoutDataGridViewTextBoxColumn.DataPropertyName = "datetime_out";
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.datetimeoutDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.datetimeoutDataGridViewTextBoxColumn.HeaderText = "퇴실시간";
            this.datetimeoutDataGridViewTextBoxColumn.Name = "datetimeoutDataGridViewTextBoxColumn";
            this.datetimeoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeoutDataGridViewTextBoxColumn.Width = 150;
            // 
            // schnameDataGridViewTextBoxColumn
            // 
            this.schnameDataGridViewTextBoxColumn.DataPropertyName = "sch_name";
            this.schnameDataGridViewTextBoxColumn.HeaderText = "행사명";
            this.schnameDataGridViewTextBoxColumn.Name = "schnameDataGridViewTextBoxColumn";
            this.schnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // choolchkDataGridViewTextBoxColumn
            // 
            this.choolchkDataGridViewTextBoxColumn.DataPropertyName = "choolchk";
            this.choolchkDataGridViewTextBoxColumn.HeaderText = "출결";
            this.choolchkDataGridViewTextBoxColumn.Name = "choolchkDataGridViewTextBoxColumn";
            this.choolchkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_attendance);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(558, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(179, 22);
            this.panel7.TabIndex = 8;
            // 
            // label_attendance
            // 
            this.label_attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_attendance.Location = new System.Drawing.Point(0, 0);
            this.label_attendance.Name = "label_attendance";
            this.label_attendance.Size = new System.Drawing.Size(179, 22);
            this.label_attendance.TabIndex = 0;
            this.label_attendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoolSeokView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChoolSeokView";
            this.Text = "ChoolSeokView";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_chool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Data.DataSet dset_chool;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn 이름;
        private System.Data.DataColumn 아이디;
        private System.Data.DataColumn 학급;
        private System.Data.DataColumn 입실시간;
        private System.Data.DataColumn 퇴실시간;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn choolchkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_attendance;
    }
}