namespace MIRAEPRO.Windows.Pop
{
    partial class StudentSelectPop
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ss = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dset_ss = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_ss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btn_select);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(404, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(3);
            this.panel14.Size = new System.Drawing.Size(126, 71);
            this.panel14.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_select.Location = new System.Drawing.Point(3, 3);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(118, 63);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "선택";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv_ss);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 344);
            this.panel2.TabIndex = 1;
            // 
            // dgv_ss
            // 
            this.dgv_ss.AllowUserToAddRows = false;
            this.dgv_ss.AllowUserToDeleteRows = false;
            this.dgv_ss.AllowUserToResizeColumns = false;
            this.dgv_ss.AllowUserToResizeRows = false;
            this.dgv_ss.AutoGenerateColumns = false;
            this.dgv_ss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgv_ss.DataMember = "ss";
            this.dgv_ss.DataSource = this.dset_ss;
            this.dgv_ss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ss.Location = new System.Drawing.Point(0, 0);
            this.dgv_ss.MultiSelect = false;
            this.dgv_ss.Name = "dgv_ss";
            this.dgv_ss.ReadOnly = true;
            this.dgv_ss.RowHeadersWidth = 20;
            this.dgv_ss.RowTemplate.Height = 23;
            this.dgv_ss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ss.Size = new System.Drawing.Size(530, 342);
            this.dgv_ss.TabIndex = 1;
            this.dgv_ss.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ss_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "아이디";
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "성별";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "주소";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dset_ss
            // 
            this.dset_ss.DataSetName = "NewDataSet";
            this.dset_ss.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataTable1.TableName = "ss";
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
            this.dataColumn3.ColumnName = "gender";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "contact";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "address";
            // 
            // StudentSelectPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentSelectPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학생 선택";
            this.Shown += new System.EventHandler(this.StudentSelectPop_Shown);
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dset_ss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dgv_ss;
        private System.Data.DataSet dset_ss;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}