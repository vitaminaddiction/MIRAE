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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MIRAEPRO.Windows.View
{
    public partial class PayView : MasterView
    {
        public override void RefreshView()
        {
            dset_pay.Clear();
        }
        public PayView()
        {
            InitializeComponent();
            PanelVisible();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
            dset_pay.Clear();
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            DataTable dt = App.Instance().DBManager.SearchPay();        
            if(dt != null)
            {
                GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
            }            
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (cbox_nextmonth.Checked)
            {
                int amount;
                try
                {
                    amount = Convert.ToInt32(tbox_pay.Text.Replace(",",""));
                }
                catch 
                {
                    MessageBox.Show("잘 못 입력하셨습니다.");
                    return;
                }
                int month = dgv_main.Rows.Count + 1;
                if(amount <= 800000)
                {
                    int result = App.Instance().DBManager.AddPay(month, amount);
                    if (result > 0)
                    {
                        MessageBox.Show("납부 완료");
                        DataTable dt = App.Instance().DBManager.SearchPay();
                        if (dt != null)
                        {
                            GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
                        }
                        cbox_nextmonth.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("납부 실패");
                    }
                }
                else
                {
                    MessageBox.Show("금액을 초과했습니다.");
                }
                
            }
            else
            {
                DataRow dp_row = GridAssist.SelectedRow(dgv_main);
                int month = Convert.ToInt32(dp_row["payorder"]);
                int amount; 
                try
                {
                    amount = Convert.ToInt32(tbox_pay.Text.Replace(",","")) + (800000 - Convert.ToInt32(dp_row["amount"]));
                }
                catch 
                {
                    MessageBox.Show("잘 못 입력하셨습니다.");
                    return;
                }
                if (Convert.ToInt32(tbox_pay.Text.Replace(",","")) <= Convert.ToInt32(dp_row["amount"]))
                {
                    int result = App.Instance().DBManager.ModifyPay(month, amount);
                    if (result > 0)
                    {
                        MessageBox.Show("납부 완료");
                        DataTable dt = App.Instance().DBManager.SearchPay();
                        if (dt != null)
                        {
                            GridAssist.SetAuto_GridView_FromSourceTable(dgv_main, dt);
                        }
                    }
                    else
                    {
                        MessageBox.Show("납부 실패");
                    }
                }
                else
                {
                    MessageBox.Show("금액을 초과했습니다.");
                }
            }
        }
        private void PanelVisible()
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel8.Visible = true;
            label2.Visible = true;
            cbox_nextmonth.Visible = true;
        }
        private void dgv_main_SelectionChanged(object sender, EventArgs e)
        {
            AmountText();
        }
        private void cbox_nextmonth_CheckedChanged(object sender, EventArgs e)
        {
            AmountText();
        }
        private void AmountText()
        {
            if (cbox_nextmonth.Checked)
            {
                tbox_pay.Text = "800000";
            }
            else
            {
                DataRow dr = GridAssist.SelectedRow(dgv_main);
                try
                {
                    if (dr != null)
                    {
                        tbox_pay.Text = Convert.ToString(dr["amount"]);
                    }
                    else
                    {
                        tbox_pay.Text = "0";
                    }
                }
                catch
                {
                    tbox_pay.Text = "0";
                }
            }
        }
        private void tbox_pay_TextChanged(object sender, EventArgs e)
        {
            if (tbox_pay.Text.Length > 0)
            {
                // 텍스트박스의 텍스트를 숫자로 변환
                if (decimal.TryParse(tbox_pay.Text, out decimal value))
                {
                    // 숫자를 화폐 단위 콤마 형식으로 변환하여 다시 텍스트박스에 표시
                    tbox_pay.Text = string.Format("{0:N0}", value);
                    tbox_pay.SelectionStart = tbox_pay.Text.Length; // 커서 위치를 텍스트 끝으로 이동
                }
            }
        }
    }
}
