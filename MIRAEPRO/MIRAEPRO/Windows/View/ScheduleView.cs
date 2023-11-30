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

namespace MIRAEPRO.Windows.View
{
    public partial class ScheduleView : MasterView
    {
        private System.Windows.Forms.Label[,] labels = new System.Windows.Forms.Label[7, 7];
        private DateTime currentDate;
        private Dictionary<DateTime, string> event_date = new Dictionary<DateTime, string>();
        public ScheduleView()
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
            UpdateCalendar(currentDate);            
        }
        private void UpdateCalendar(DateTime date)
        {     
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime start_date = new DateTime(date.Year, date.Month, 1);
            DateTime end_date = new DateTime(date.Year, date.Month, daysInMonth);
            DataTable dt = App.Instance().DBManager.Searchschedule(start_date, end_date);
            foreach (DataRow row in dt.Rows)
            {
                DateTime date_key = DateTime.Parse(row["schedule_date"].ToString());
                //DateTime date = Convert.ToDateTime(row["schedule_date"]);
                string eventName = row["name"].ToString();
                event_date[date_key] = eventName;
            }
            int startDay = (int)new DateTime(date.Year, date.Month, 1).DayOfWeek;
            label1.Text = date.Year.ToString() + " 년 " + date.Month.ToString() + " 월";
            int day = 1;
            for (int row = 1; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 1 && col < startDay)
                    {
                        labels[row, col].Text = "";
                    }
                    else if (day <= daysInMonth)
                    {
                        System.Windows.Forms.Label _CurrentLabel = labels[row, col];
                        _CurrentLabel.Text = day.ToString();
                        labels[row, col].BackColor = SystemColors.Control;
                        if (day == DateTime.Today.Day && date.Month == DateTime.Today.Month && date.Year == DateTime.Today.Year)
                        {
                            labels[row, col].BackColor = SystemColors.Info;
                        }

                        labels[row, col].ForeColor = System.Drawing.Color.Black;                        
                        //labels[row, col].ForeColor = (day == DateTime.Today.Day && date.Month == DateTime.Today.Month) ? System.Drawing.Color.Red : System.Drawing.Color.Black;

                        DateTime current_Date = new DateTime(date.Year, date.Month, day);
                        if (event_date.TryGetValue(current_Date, out string eventName))
                        {
                            labels[row, col].Text += "\r\n\r\n" + eventName;
                            labels[row, col].ForeColor = System.Drawing.Color.Red;
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
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            UpdateCalendar(currentDate);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            UpdateCalendar(currentDate);
        }

        /*private void btn_select_Click(object sender, EventArgs e)
        {

            DateTime dateNow = DateTime.Now;
            DateTime start_date = new DateTime(dateNow.Year, dateNow.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(dateNow.Year, dateNow.Month);
            DateTime end_date = new DateTime(dateNow.Year, dateNow.Month, daysInMonth);
            DataTable dt = App.Instance().DBManager.Searchschedule(start_date, end_date);
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = DateTime.Parse(row["schedule_date"].ToString());
                //DateTime date = Convert.ToDateTime(row["schedule_date"]);
                string eventName = row["name"].ToString();
                eventDataMap[date] = eventName;
            }
            UpdateCalendar(currentDate);
        }*/
    }
}
