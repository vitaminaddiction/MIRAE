using Lib.Frame;
using MIRAEPRO.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIRAEPRO.Windows.View
{
    public partial class WebView : MasterView
    {
        public WebView()
        {
            InitializeComponent();
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            App.Instance().MainForm.ShowView(typeof(MainMenuView));
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 크롬 브라우저 실행 파일 경로
                string chromeExePath = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";

                // 실행할 URL
                string url = "https://www.adiga.kr/EgovPageLink.do?link=EipMain"; // 원하는 웹 페이지 URL로 대체

                // 크롬 브라우저 실행
                Process.Start(chromeExePath, url);
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show("크롬 브라우저를 실행하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 크롬 브라우저 실행 파일 경로
                string chromeExePath = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";

                // 실행할 URL
                string url = "https://www.dge.go.kr/main/main.do"; // 원하는 웹 페이지 URL로 대체

                // 크롬 브라우저 실행
                Process.Start(chromeExePath, url);
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show("크롬 브라우저를 실행하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 크롬 브라우저 실행 파일 경로
                string chromeExePath = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";

                // 실행할 URL
                string url = "https://www.neis.go.kr/nxuiPortal/index.html"; // 원하는 웹 페이지 URL로 대체

                // 크롬 브라우저 실행
                Process.Start(chromeExePath, url);
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show("크롬 브라우저를 실행하는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
