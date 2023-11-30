namespace MIRAEPRO.Windows.View
{
    partial class PayView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbox_pay = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_pay = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_nextmonth = new System.Windows.Forms.CheckBox();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dset_pay = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 85);
            this.panel1.TabIndex = 3;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1336, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_menu.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu.Location = new System.Drawing.Point(451, 13);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(432, 59);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "돌아가기";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 28);
            this.panel2.TabIndex = 5;
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
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbox_nextmonth, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1336, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbox_pay);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(193, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 22);
            this.panel4.TabIndex = 15;
            this.panel4.Visible = false;
            // 
            // tbox_pay
            // 
            this.tbox_pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_pay.Location = new System.Drawing.Point(0, 0);
            this.tbox_pay.Name = "tbox_pay";
            this.tbox_pay.Size = new System.Drawing.Size(184, 21);
            this.tbox_pay.TabIndex = 0;
            this.tbox_pay.TextChanged += new System.EventHandler(this.tbox_pay_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_pay);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(953, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 22);
            this.panel8.TabIndex = 13;
            this.panel8.Visible = false;
            // 
            // btn_pay
            // 
            this.btn_pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pay.Location = new System.Drawing.Point(0, 0);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(184, 22);
            this.btn_pay.TabIndex = 0;
            this.btn_pay.Text = "납부";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_select);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1143, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(190, 22);
            this.panel11.TabIndex = 7;
            // 
            // btn_select
            // 
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_select.Location = new System.Drawing.Point(0, 0);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(190, 22);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 22);
            this.panel3.TabIndex = 14;
            this.panel3.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "납부하실 금액";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(383, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "원";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbox_nextmonth
            // 
            this.cbox_nextmonth.AutoSize = true;
            this.cbox_nextmonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_nextmonth.Location = new System.Drawing.Point(573, 3);
            this.cbox_nextmonth.Name = "cbox_nextmonth";
            this.cbox_nextmonth.Size = new System.Drawing.Size(184, 22);
            this.cbox_nextmonth.TabIndex = 17;
            this.cbox_nextmonth.Text = "다음달";
            this.cbox_nextmonth.UseVisualStyleBackColor = true;
            this.cbox_nextmonth.CheckedChanged += new System.EventHandler(this.cbox_nextmonth_CheckedChanged);
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
            this.nameDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.payorderDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgv_main.DataMember = "pay";
            this.dgv_main.DataSource = this.dset_pay;
            this.dgv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_main.Location = new System.Drawing.Point(0, 28);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.RowTemplate.Height = 23;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(1336, 411);
            this.dgv_main.TabIndex = 6;
            this.dgv_main.SelectionChanged += new System.EventHandler(this.dgv_main_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "아이디";
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberidDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 200;
            // 
            // payorderDataGridViewTextBoxColumn
            // 
            this.payorderDataGridViewTextBoxColumn.DataPropertyName = "payorder";
            this.payorderDataGridViewTextBoxColumn.HeaderText = "회차";
            this.payorderDataGridViewTextBoxColumn.Name = "payorderDataGridViewTextBoxColumn";
            this.payorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.payorderDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "미납금";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 200;
            // 
            // dset_pay
            // 
            this.dset_pay.DataSetName = "NewDataSet";
            this.dset_pay.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.TableName = "pay";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "member_id";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "contact";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "payorder";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "amount";
            this.dataColumn5.DataType = typeof(int);
            // 
            // PayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 524);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PayView";
            this.Text = "PayView";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_pay;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Data.DataSet dset_pay;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Label label2;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.CheckBox cbox_nextmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}