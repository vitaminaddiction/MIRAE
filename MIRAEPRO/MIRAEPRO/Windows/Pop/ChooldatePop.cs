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

namespace MIRAEPRO.Windows.Pop
{
    public partial class ChooldatePop : MasterPop
    {
        DataRow m_row = null;
        public ChooldatePop(DataRow row)
        {
            InitializeComponent();
            m_row = row;
            InitializePop(m_row);
        }
        private void InitializePop(DataRow row)
        {
            DataRow dr = App.Instance().DBManager.ReadStudent(App.Instance().student_id);
            label_name.Text = dr["name"].ToString();
            label_id.Text = dr["member_id"].ToString();
            label_h_name.Text = dr["h_name"].ToString();

            DateTime temp_cal = (DateTime)row["temp_cal"];
            try
            {
                DateTime datetime_in = (DateTime)row["datetime_in"];
                label_datetime_in.Text = datetime_in.ToString("tt hh:mm:ss");
            }
            catch
            {

            }
            try
            {
                DateTime datetime_out = (DateTime)row["datetime_out"];
                label_datetime_out.Text = datetime_out.ToString("tt hh:mm:ss");
            }
            catch
            {

            }
            label_cal.Text = temp_cal.ToString("yyyy-MM-dd");
            label_sch_name.Text = Convert.ToString(row["sch_name"]);
            label_choolchk.Text = row["choolchk"].ToString();
            

            //try
            //{
            //    DateTime temp_cal = (DateTime)row["temp_cal"];
            //    DateTime datetime_in = (DateTime)row["datetime_in"];
            //    DateTime datetime_out = (DateTime)row["datetime_out"];
            //    label_cal.Text = temp_cal.ToString("yyyy-MM-dd");
            //    label_name.Text = row["name"].ToString();
            //    label_h_name.Text = row["h_name"].ToString();
            //    label_id.Text = row["student_id"].ToString();
            //    label_datetime_in.Text = datetime_in.ToString("tt hh:mm:ss");
            //    label_datetime_out.Text = datetime_out.ToString("tt hh:mm:ss");
            //    label_sch_name.Text = Convert.ToString(row["sch_name"]);
            //    label_choolchk.Text = row["choolchk"].ToString();
            //}
            //catch 
            //{
            //    if (row["choolchk"] != DBNull.Value)
            //    {
            //        label_name.Text = App.Instance().student_name;
            //        label_choolchk.Text = row["choolchk"].ToString();
            //    }
            //}
        }
    }
}
