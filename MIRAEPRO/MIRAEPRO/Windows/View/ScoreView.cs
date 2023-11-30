using Lib.Frame;
using Lib.Util;
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
    public partial class ScoreView : MasterView
    {
        public override void RefreshView()
        {
            dset_score.Clear();
            Initialize();
        }
        public ScoreView()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            cbox_name.SelectedIndex = 0;
            cbox_testname.SelectedIndex = 0;

            DateTime date = DateTime.Now;
            dtp_start.Value = new DateTime(date.Year, date.Month - 1, date.Day);
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
            dset_score.Clear();
            Initialize();
        }
        private void cbox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbox_name.SelectedIndex == 0)
            {
                panel6.Visible = false;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = true;
            }
            else
            {
                panel6.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
                panel10.Visible = false;
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            switch(cbox_name.SelectedIndex)
            {
                case 0:
                    //시간별
                    Date();
                    break;
                case 1:
                    //과목별
                    TestName();
                    break;
                default:
                    break;
            }
        }
        private void Date()
        {
            DateTime start_date = dtp_start.Value;
            DateTime end_date = dtp_end.Value;
            DataTable dt = App.Instance().DBManager.SearchScore(start_date, end_date);
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
            }
            dgv_main.CurrentCell = null;
        }
        private void TestName()
        {
            int kind = cbox_testname.SelectedIndex;
            DataTable dt = App.Instance().DBManager.SearchScore(kind);
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
            }
            dgv_main.CurrentCell = null;
        }
    }
}
