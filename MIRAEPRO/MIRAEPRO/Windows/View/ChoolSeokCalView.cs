using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Frame;
using MIRAEPRO.Manager;
using MIRAEPRO.Manager.ChoolSeok;
using MIRAEPRO.Windows.Pop;

namespace MIRAEPRO.Windows.View
{    
    public partial class ChoolSeokCalView : MasterView
    {
        private System.Windows.Forms.Label[,] labels = new System.Windows.Forms.Label[7, 7];
        private DateTime currentDate;
        private Dictionary<DateTime, string> event_date = new Dictionary<DateTime, string>();
        public override void RefreshView()
        {
            currentDate = DateTime.Today;
            UpdateCalendar(currentDate);
        }
        public ChoolSeokCalView()
        {
            InitializeComponent();
            InitializeCalendar();
        }
        private void InitializeCalendar()
        {
            currentDate = DateTime.Today;

            labels = new System.Windows.Forms.Label[,]
            {
                { labelSun, labelMon, labelTue, labelWed, labelThu, labelFri, labelSat },
                { label65, label66, label67, label68, label69, label70, label71 },
                { label72, label73, label74, label75, label76, label77, label78 },
                { label79, label80, label81, label82, label83, label84, label85 },
                { label86, label87, label88, label89, label90, label91, label92 },
                { label93, label94, label95, label96, label97, label98, label99 },
                { label100, label101, label102, label103, label104, label105, label106 }
            };
            for (int row = 1; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    labels[row, col].DoubleClick += new EventHandler(Label_DoubleClick);
                }
            }
            UpdateCalendar(currentDate);
        }
        private void UpdateCalendar(DateTime date)
        {
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime start_date = new DateTime(date.Year, date.Month, 1);
            DateTime end_date = new DateTime(date.Year, date.Month, daysInMonth);
            DataTable dt = App.Instance().DBManager.ChoolSeokChk(start_date, end_date);
            int startDay = (int)new DateTime(date.Year, date.Month, 1).DayOfWeek;
            label1.Text = date.Year.ToString() + " 년 " + date.Month.ToString() + " 월";
            int day = 1;

            for (int row = 1; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    labels[row, col].BackColor = SystemColors.Control;
                    labels[row, col].ForeColor = System.Drawing.Color.Black;
                    if (row == 1 && col < startDay)
                    {
                        labels[row, col].Text = "";
                    }
                    else if (day <= daysInMonth)
                    {                        
                        labels[row, col].Text = day.ToString();
                        foreach (DataRow row_dt in dt.Rows)
                        {                            
                            if (new DateTime(date.Year, date.Month, day) == Convert.ToDateTime(row_dt["temp_cal"]))
                            {
                                //ClassChool classChool = new ClassChool(Convert.ToDateTime(row_dt["datetime_in"]), Convert.ToDateTime(row_dt["datetime_out"]), Convert.ToString(row_dt["name"]));
                                labels[row, col].Tag = row_dt;
                                if (row_dt["choolchk"] != DBNull.Value)
                                {
                                    string Key = row_dt["choolchk"].ToString();
                                    switch (Key)
                                    {
                                        case "출석":
                                            labels[row, col].BackColor = Color.LightBlue;
                                            break;
                                        case "결석":
                                            labels[row, col].BackColor = Color.LightPink;
                                            break;
                                        case "지각":
                                            labels[row, col].BackColor = Color.LightSeaGreen;
                                            break;
                                        case "조퇴":
                                            labels[row, col].BackColor = Color.LightSalmon;
                                            break;
                                        default:
                                            break;
                                            //throw new Exception();
                                    }
                                }

                                if (row_dt["sch_name"] != DBNull.Value)
                                {
                                    if (row_dt["sch_name"].ToString().Contains("모의고사"))
                                    {
                                        labels[row, col].Text += "\r\n\r\n" + row_dt["sch_name"].ToString();
                                    }
                                    else
                                    {
                                        labels[row, col].Text += "\r\n\r\n" + row_dt["sch_name"].ToString();
                                        labels[row, col].ForeColor = System.Drawing.Color.Red;
                                    }
                                }
                            }
                        }
                        if (day == DateTime.Today.Day && date.Month == DateTime.Today.Month && date.Year == DateTime.Today.Year)
                        {
                            labels[row, col].BackColor = SystemColors.Info;
                        }

                        if (col == 0 || col == 6)
                        {
                            labels[row, col].ForeColor = System.Drawing.Color.Red;
                        }
                        day++;
                    }
                    else
                    {
                        labels[row, col].Text = "";
                    }
                }
            }

            labels[0, 0].Text = "일";
            labels[0, 1].Text = "월";
            labels[0, 2].Text = "화";
            labels[0, 3].Text = "수";
            labels[0, 4].Text = "목";
            labels[0, 5].Text = "금";
            labels[0, 6].Text = "토";
        }
        private void NewView_Shown(object sender, EventArgs e)
        {
            UpdateCalendar(currentDate);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            UpdateCalendar(currentDate);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            UpdateCalendar(currentDate);
        }
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label clickedLabel = sender as System.Windows.Forms.Label;
            if (clickedLabel != null && clickedLabel.Text != "")
            {
                ChooldatePop chooldatePop = new ChooldatePop(clickedLabel.Tag as DataRow);
                chooldatePop.ShowPop(ePopMode.None);
            }
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
            App.Instance().MainForm.RefreshViews();
        }
    }

}
