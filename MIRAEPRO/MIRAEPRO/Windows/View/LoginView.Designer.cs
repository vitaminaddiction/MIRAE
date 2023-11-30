namespace MIRAEPRO.Windows.View
{
    partial class LoginView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbox_pwd = new System.Windows.Forms.TextBox();
            this.btn_regmember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼매직체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(430, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼매직체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(430, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbox_id
            // 
            this.tbox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_id.BackColor = System.Drawing.SystemColors.Control;
            this.tbox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_id.Font = new System.Drawing.Font("KBIZ한마음고딕 B", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_id.Location = new System.Drawing.Point(431, 168);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(248, 21);
            this.tbox_id.TabIndex = 1;
            this.tbox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_id_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.SystemColors.Info;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_login.Location = new System.Drawing.Point(387, 377);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(168, 42);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(433, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(433, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 1);
            this.panel3.TabIndex = 8;
            // 
            // tbox_pwd
            // 
            this.tbox_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_pwd.BackColor = System.Drawing.SystemColors.Control;
            this.tbox_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_pwd.Font = new System.Drawing.Font("KBIZ한마음고딕 B", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_pwd.Location = new System.Drawing.Point(431, 278);
            this.tbox_pwd.Name = "tbox_pwd";
            this.tbox_pwd.PasswordChar = '*';
            this.tbox_pwd.Size = new System.Drawing.Size(248, 21);
            this.tbox_pwd.TabIndex = 2;
            this.tbox_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_pwd_KeyDown);
            // 
            // btn_regmember
            // 
            this.btn_regmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_regmember.BackColor = System.Drawing.SystemColors.Info;
            this.btn_regmember.FlatAppearance.BorderSize = 0;
            this.btn_regmember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regmember.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_regmember.Location = new System.Drawing.Point(595, 377);
            this.btn_regmember.Name = "btn_regmember";
            this.btn_regmember.Size = new System.Drawing.Size(168, 42);
            this.btn_regmember.TabIndex = 4;
            this.btn_regmember.Text = "회원 가입 및 상담 신청";
            this.btn_regmember.UseVisualStyleBackColor = false;
            this.btn_regmember.Click += new System.EventHandler(this.btn_regmember_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 544);
            this.Controls.Add(this.btn_regmember);
            this.Controls.Add(this.tbox_pwd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginView_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbox_pwd;
        private System.Windows.Forms.Button btn_regmember;
    }
}