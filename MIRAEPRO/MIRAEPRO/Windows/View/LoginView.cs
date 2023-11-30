using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Frame;
using MIRAEPRO.Manager;
using MIRAEPRO.Windows.Pop;

namespace MIRAEPRO.Windows.View
{
    public partial class LoginView : MasterView
    {        
        public LoginView()
        {
            InitializeComponent();
            //tbox_id.Text = "TEST";
            //tbox_pwd.Text = "123";
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }
        private void LoginProcess()
        {
            string login_id = tbox_id.Text;
            string login_pwd = tbox_pwd.Text;
            DataTable db_member = App.Instance().DBManager.ReadMember(login_id, login_pwd);
            if (db_member != null)
            {
                if (db_member.Rows.Count > 0)
                {
                    DataRow row = db_member.Rows[0];
                    App.Instance().parent_id = Convert.ToString(row["id"]);
                    //string pwd = Convert.ToString(row["password"]);
                    int chk_pwd = Convert.ToInt32(row["chk_pwd"]);
                    if (chk_pwd != 1)
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다.");

                    }
                    else
                    {
                        MessageBox.Show("로그인 성공하셨습니다.");
                        if (db_member.Rows.Count > 1)
                        {
                            //DataRow row = db_member.Rows[0];
                            App.Instance().parent_id = Convert.ToString(row["id"]);
                            StudentSelectPop studentSelectPop = new StudentSelectPop();
                            studentSelectPop.ShowPop(ePopMode.None);
                            App.Instance().MainForm.IniLogin();
                        }
                        else if (db_member.Rows.Count == 1)
                        {
                            DataTable dt = App.Instance().DBManager.ReadSelectStudent(login_id);
                            if (dt != null)
                            {
                                DataRow dr = dt.Rows[0];
                                App.Instance().student_id = Convert.ToString(dr["member_id"]);
                            }
                        }
                        App.Instance().MainForm.OkLogin();
                    }
                }
                else
                {
                    MessageBox.Show("상담을 먼저 진행해주세요.");
                }
            }
            else
            {
                MessageBox.Show("로그인 할 수 없습니다.");
            }
        }
        private void btn_regmember_Click(object sender, EventArgs e)
        {
            RegMemberPop reg_pop = new RegMemberPop();
            reg_pop.ShowPop(ePopMode.Add);
        }
        private void tbox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }
        private void tbox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }
        private void LoginView_Load(object sender, EventArgs e)
        {
            tbox_id.Select();
        }
        private void LoginView_VisibleChanged(object sender, EventArgs e)
        {
            tbox_id.Text = "";
            tbox_pwd.Text = "";
        }
    }
}
