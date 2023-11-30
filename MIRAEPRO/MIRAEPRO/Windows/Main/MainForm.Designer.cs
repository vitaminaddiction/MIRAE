namespace MIRAEPRO
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.정보열람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_reg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtn_info = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtn_setuppop = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_ViewSpace = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보열람ToolStripMenuItem,
            this.환경설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_logout});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // mbtn_logout
            // 
            this.mbtn_logout.Name = "mbtn_logout";
            this.mbtn_logout.Size = new System.Drawing.Size(122, 22);
            this.mbtn_logout.Text = "로그아웃";
            this.mbtn_logout.Click += new System.EventHandler(this.mbtn_logout_Click);
            // 
            // 정보열람ToolStripMenuItem
            // 
            this.정보열람ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_add,
            this.mbtn_reg,
            this.toolStripMenuItem1,
            this.mbtn_info});
            this.정보열람ToolStripMenuItem.Name = "정보열람ToolStripMenuItem";
            this.정보열람ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보열람ToolStripMenuItem.Text = "편집";
            // 
            // mbtn_add
            // 
            this.mbtn_add.Name = "mbtn_add";
            this.mbtn_add.Size = new System.Drawing.Size(154, 22);
            this.mbtn_add.Text = "학생 추가";
            this.mbtn_add.Click += new System.EventHandler(this.mbtn_add_Click);
            // 
            // mbtn_reg
            // 
            this.mbtn_reg.Name = "mbtn_reg";
            this.mbtn_reg.Size = new System.Drawing.Size(154, 22);
            this.mbtn_reg.Text = "등록 학생 선택";
            this.mbtn_reg.Visible = false;
            this.mbtn_reg.Click += new System.EventHandler(this.mbtn_reg_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // mbtn_info
            // 
            this.mbtn_info.Name = "mbtn_info";
            this.mbtn_info.Size = new System.Drawing.Size(154, 22);
            this.mbtn_info.Text = "개인정보";
            this.mbtn_info.Click += new System.EventHandler(this.mbtn_info_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_setuppop});
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.환경설정ToolStripMenuItem.Text = "도구";
            this.환경설정ToolStripMenuItem.Visible = false;
            // 
            // mbtn_setuppop
            // 
            this.mbtn_setuppop.Name = "mbtn_setuppop";
            this.mbtn_setuppop.Size = new System.Drawing.Size(180, 22);
            this.mbtn_setuppop.Text = "환경설정";
            this.mbtn_setuppop.Click += new System.EventHandler(this.mbtn_setuppop_Click);
            // 
            // dgv_ViewSpace
            // 
            this.dgv_ViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ViewSpace.Location = new System.Drawing.Point(0, 24);
            this.dgv_ViewSpace.Name = "dgv_ViewSpace";
            this.dgv_ViewSpace.RowTemplate.Height = 23;
            this.dgv_ViewSpace.Size = new System.Drawing.Size(1405, 543);
            this.dgv_ViewSpace.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 567);
            this.Controls.Add(this.dgv_ViewSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatcherProgram";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보열람ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtn_reg;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mbtn_logout;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_ViewSpace;
        private System.Windows.Forms.ToolStripMenuItem mbtn_setuppop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbtn_info;
        private System.Windows.Forms.ToolStripMenuItem mbtn_add;
    }
}

