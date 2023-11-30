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
using MIRAEPRO.Windows.View;

namespace MIRAEPRO.Windows.View
{
    public partial class MainMenuView : MasterView
    {
        public MainMenuView()
        {
            InitializeComponent();
        }
        private void btn_choolseok_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(ChoolSeokCalView));
        }
        private void btn_score_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(ScoreView));
        }
        private void btn_class_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(HakGeupView));
            App.Instance().MainForm.RefreshViews();
        }
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(ScheduleView));
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(PayView));
        }
        private void btn_message_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MessageView));
        }
        private void btn_web_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(WebView));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            App.Instance().MainForm.ShowView(typeof(ChoolSeokView));
        }
        private void panel31_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2.Visible = true;
        }
    }
}
