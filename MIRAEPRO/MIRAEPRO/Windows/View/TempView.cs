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
    public partial class TempView : MasterView
    {
        public class A
        {

        }
        public TempView()
        {
            InitializeComponent();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
        }
        private void btn_select_Click(object sender, EventArgs e)
        {            
            DateTime start_time = dtp_start.Value;
            DateTime end_time = dtp_end.Value;
            DataTable dt = App.Instance().DBManager.Searchschedule(start_time, end_time);
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
            }
        }
    }
}
