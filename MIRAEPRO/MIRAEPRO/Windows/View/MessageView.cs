using Lib.Frame;
using MIRAEPRO.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIRAEPRO.Windows.View
{
    public partial class MessageView : MasterView
    {
        public MessageView()
        {
            InitializeComponent();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
        }
        private void btn_send_Click(object sender, EventArgs e)
        {            
            string sendmsg = tbox_sendmsg.Text;
            DateTime dateTime = DateTime.Now;
            DataRow dr = App.Instance().DBManager.SearchMessage(dateTime);
            if(dr == null )
            {
                int result = App.Instance().DBManager.AddMessage(sendmsg, dateTime);
                if (result > 0)
                {
                    MessageBox.Show("등록 성공");
                }
                else
                {
                    MessageBox.Show("등록 실패");
                }
            }
            else
            {
                int result = App.Instance().DBManager.ModifyMessage(sendmsg, dateTime);
                if (result > 0)
                {
                    MessageBox.Show("등록 성공");
                }
                else
                {
                    MessageBox.Show("등록 실패");
                }
            }
            tbox_sendmsg.Text = "";
        }
    }
}
