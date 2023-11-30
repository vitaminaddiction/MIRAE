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

namespace MIRAEPRO.Windows.Pop
{
    public partial class StudentSelectPop : MasterPop
    {
        public StudentSelectPop()
        {
            InitializeComponent();            
        }
        private void Initialize()
        {
            DataTable dt = App.Instance().DBManager.ReadSelectStudent(App.Instance().parent_id);
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_ss, dt);                
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            DataRow dp_row = GridAssist.SelectedRow(dgv_ss);
            App.Instance().student_id = dp_row["member_id"].ToString();
            //MessageBox.Show(App.Instance().student_id);
            App.Instance().MainForm.RefreshViews();
            MessageBox.Show(dp_row["name"].ToString() + "이/가 선택 되었습니다.");
            DialogResult = DialogResult.OK;
        }
        private void StudentSelectPop_Shown(object sender, EventArgs e)
        {
            Initialize();
        }
        private void dgv_ss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dp_row = GridAssist.SelectedRow(dgv_ss);
            App.Instance().student_id = dp_row["member_id"].ToString();
            //MessageBox.Show(App.Instance().student_id);
            App.Instance().MainForm.RefreshViews();
            MessageBox.Show(dp_row["name"].ToString() + "이/가 선택 되었습니다.");
            DialogResult = DialogResult.OK;
        }
    }
}