using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Lib.Frame;
using Lib.Util;
using MIRAEPRO.Manager;

namespace MIRAEPRO.Windows.View
{
    public partial class ChoolSeokView : MasterView
    {
        public override void RefreshView()
        {
            Initialize();
            dset_chool.Clear();
        }
        public ChoolSeokView()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            DateTime date = DateTime.Now;
            dtp_start.Value = date.AddMonths(-1);
            //new DateTime(date.Year, date.Month, 1);
            label_attendance.Text = "";
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
            //dgv_main.Columns.Clear();
            //((DataTable)dgv_main.DataSource).Rows.Clear();
            //dgv_main.Rows.Clear();
            /*if (dgv_main.DataSource != null)
            {
                dgv_main.DataSource = (dgv_main.DataSource as DataTable).Clone();
            }*/
            //dgv_main.DataSource = new BindingList<ChoolSeokView>();
            Initialize();
            dset_chool.Clear();
        }
        private void btn_select_Click(object sender, EventArgs e)
        {            
            DateTime start_time = dtp_start.Value;
            DateTime end_time = dtp_end.Value;
            DataTable dt = App.Instance().DBManager.ChoolSeokChk(start_time, end_time);
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
            }
            WeekDayChk(dgv_main);
            AttendanceRate(dgv_main);
            dgv_main.CurrentCell = null;
        }
        private void AttendanceRate(DataGridView dgv_main)
        {
            int total = 0;
            int attendanceday = 0;
            double attendanceRate = 0;
            if (dgv_main.Rows.Count > 0)
            {
                for (int row = 0; row < dgv_main.Rows.Count; row++)
                {
                    DataGridViewRow dataGridViewRow = dgv_main.Rows[row];

                    if (dataGridViewRow.DefaultCellStyle.BackColor == Color.White)
                    {
                        total++;
                    }
                    if (dataGridViewRow.Cells[7].Value.ToString() == "출석")
                    {
                        attendanceday++;
                        //dataGridViewRow.Cells[7].Style.BackColor = Color.Blue;
                    }
                }
                attendanceRate = ((double)attendanceday / (double)total) * 100;
            }
            label_attendance.Text = "기간 내 출석률 : " + attendanceRate.ToString("#") + "%";
            //MessageBox.Show(attendanceRate.ToString("#"));
        }
        private void WeekDayChk(DataGridView dgv_main)
        {
            for (int row = 0; row < dgv_main.Rows.Count; row++)
            {
                DataGridViewRow dataGridViewRow = dgv_main.Rows[row];
                DateTime currentDate = Convert.ToDateTime(dataGridViewRow.Cells[0].Value);
                dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.LightPink;
                    dataGridViewRow.Cells[7].Value = "";
                }
                if(currentDate > DateTime.Today)
                {
                    dataGridViewRow.Cells[7].Value = "";
                }
                if (dataGridViewRow.Cells[6].Value.ToString().Length > 0 && dataGridViewRow.Cells[6].Value.ToString().Contains("모의고사") == false)
                {
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.LightPink;
                    dataGridViewRow.Cells[7].Value = "";
                }
            }
        }
    }
}
