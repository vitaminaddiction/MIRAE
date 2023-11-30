using Lib.Frame;
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
using MIRAEPRO.Manager;
using MIRAEPRO.Windows.Pop;

namespace MIRAEPRO
{
    public partial class MainForm : Form
    {
        List<MasterView> m_Views = new List<MasterView>();
        DBManager m_DBManager = null;
        SessionManager m_SsessionManer = null;

        public void RefreshViews()
        {
            foreach (MasterView view in m_Views)
            {
                view.RefreshView();
            }
        }
        public MainForm()
        {
            InitializeComponent();
            CreateObject();
            InitializeObject();
            LoginInitialize();
        }
        private void CreateObject()
        {
            m_DBManager = new DBManager();
            m_SsessionManer = new SessionManager();
        }        
        private void InitializeObject()
        {
            m_DBManager.SetConnectInfo("192.168.0.13", 1521, "MIRAEDB", "kb603", "xe");
         
            App.Instance().DBManager = m_DBManager;
            App.Instance().SessionManager = m_SsessionManer;
        }
        private void LoginInitialize()
        {
            App.Instance().MainForm = this;

            m_Views.Add(new LoginView());
            m_Views.Add(new MainMenuView());
            m_Views.Add(new ChoolSeokView());
            m_Views.Add(new ScoreView());
            m_Views.Add(new HakGeupView());
            m_Views.Add(new PayView());   
            m_Views.Add(new MessageView());
            m_Views.Add(new WebView());
            m_Views.Add(new ScheduleView());
            m_Views.Add(new ChoolSeokCalView());

            ShowView(typeof(LoginView));

            menuStrip1.Visible = false;
            mbtn_reg.Visible = false;
            //toolStrip1.Visible = false;
        }
        public void OkLogin()
        {
            menuStrip1.Visible = true;
            //toolStrip1.Visible = true;
            ShowView(typeof(MainMenuView));
        }
        public void IniLogin()
        {
            mbtn_reg.Visible = true;
        }
        public void ShowView(Type aType)
        {
            foreach (MasterView view in m_Views)
            {
                if (view.GetType() == aType)
                {
                    view.Parent = dgv_ViewSpace;
                    view.Dock = DockStyle.Fill;
                    view.Visible = true;
                }
                else
                {
                    view.Visible = false;
                }
            }
        }        
        private void mbtn_setuppop_Click(object sender, EventArgs e)
        {
            SetupPop setupPop = new SetupPop();
            setupPop.Show();
        }
        private void mbtn_reg_Click(object sender, EventArgs e)
        {
            StudentSelectPop studentSelectPop = new StudentSelectPop();
            studentSelectPop.ShowPop(ePopMode.None);
        }
        private void mbtn_logout_Click(object sender, EventArgs e)
        {
            LoginInitialize();
            App.Instance().parent_id = "";
            App.Instance().student_id = "";
        }
        private void mbtn_info_Click(object sender, EventArgs e)
        {
            RegMemberPop regMemberPop = new RegMemberPop();
            regMemberPop.ShowPop(ePopMode.Modify);
        }
        private void mbtn_add_Click(object sender, EventArgs e)
        {
            RegMemberPop regMemberPop = new RegMemberPop();
            regMemberPop.ShowPop(ePopMode.Add2);
        }
    }
}
