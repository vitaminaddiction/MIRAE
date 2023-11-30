using MIRAEPRO.Lib.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace MIRAEPRO.Manager {
    class DBManager {
        private OracleAssist m_OracleAssist;
        public void SetConnectInfo(string aAddr, int aPort, string aId, string aPwd, string aDataBase) {
            m_OracleAssist = new OracleAssist(aAddr, aPort, aId, aPwd, aDataBase);
        }
        //4000자 이상 문자열 ToClob으로 처리하기
        public string MakeToClobQuery(string aSrc) {
            return MakeToClobQuery(aSrc, 4000);
        }
        public string MakeToClobQuery(string aSrc, int aBlock) {
            string _result = "";
            if (aSrc == null || aSrc.Length == 0) {
                _result = "''";
            }
            else {
                int _len = aSrc.Length;
                int _count = (_len + aBlock - 1) / aBlock;
                for (int _idx = 0; _idx < _count; _idx++) {
                    if (_result.Length > 0) { _result += "||"; }
                    int _start = _idx * aBlock;
                    int _size = _len - _start;
                    if (_size > aBlock) { _size = aBlock; }
                    _result += string.Format(" TO_CLOB('{0}') "
                        , aSrc.Substring(_start, _size));

                }
            }
            return _result;
        }
        //DB member 함수
        public DataTable ReadMember(string aId, string aPwd)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();

            if (_Connection == null)
            {
                return null;
            }
            else
            {
                string strFormat = "SELECT id, password, membergroup_code, case when password = '{1}' then 1 else 0 end chk_pwd, membergroup_code " +                    
                                    "FROM member m " +
                                    "JOIN parent p ON m.id = p.member_id " +
                                    "JOIN student s ON s.parent_id = p.member_id " +
                                    "WHERE id = '{0}' ";
                
                string strQuery = string.Format(strFormat, aId, aPwd);
                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "member");
            }
            return dt;
        }
        public DataTable ReadMember(string aId)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if(_Connection == null)
            {
                return null;
            }
            else
            {
                string strQuery = string.Format("SELECT id " +
                                                "FROM member " +
                                                "WHERE id = '{0}' ", aId);

                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "member");
            }
            return dt;
        }
        public DataTable ReadSelectStudent(string parent_id)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();

            if (_Connection == null)
            {
                return null;
            }
            else
            {
                string strFormat = "SELECT s.name, s.member_id, s.gender, s.contact, s.address " +
                                    "FROM member m " +
                                    "JOIN parent p ON m.id = p.member_id " +
                                    "JOIN student s ON s.parent_id = p.member_id " +
                                    "WHERE id = '{0}' ";

                string strQuery = string.Format(strFormat, parent_id);
                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "member");
            }
            return dt;
        }
        public DataRow ReadInfo(string parent_id, string student_id)
        {
            DataTable dt = null;
            DataRow dr = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else
            {
                string strQuery = string.Format("SELECT p.member_id Pid, p.name Pname, p.contact Pcontact, p.email Pemail, s.member_id Sid, s.name Sname, s.gender Sgender, s.contact Scontact, s.address Saddr, s.date_register, s.picture " +
                                                "FROM member m " +
                                                "JOIN parent p ON p.member_id = m.id " +
                                                "JOIN student s ON p.member_id = s.parent_id " +
                                                "WHERE p.member_id = '{0}' and s.member_id = '{1}' ", parent_id, student_id);

                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "member");
                if(dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                }
            }
            return dr;
        }
        //DB 회원가입(Memeber, Parent, Waiting)
        public int AddMember(string pId, string pPwd, string pName, string pContact, string pEmail, string sId, string sPwd, string sName, string sGender, string sContact, string sAddr, DateTime sRegDate, string sScore, string sPic)
        {
            ArrayList QueryArray = new ArrayList();
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if( _Connection == null )
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("INSERT INTO member ( id, password, membergroup_code ) " +
                                                 "VALUES ('{0}', '{1}', 3 ) ", pId, pPwd );
                QueryArray.Add( strQuery );

                strQuery = string.Format("INSERT INTO member ( id, password, membergroup_code ) " +
                                          "VALUES ( '{0}', '{1}', 5 ) ", sId, sPwd);
                QueryArray.Add( strQuery );

                strQuery = string.Format("INSERT INTO parent ( member_id, name, contact, email )" +
                                          "VALUES ( '{0}', '{1}', '{2}', '{3}' ) ", pId, pName, pContact, pEmail);
                QueryArray.Add( strQuery );

                strQuery = string.Format("INSERT INTO waiting (member_id, step, score, name, gender, contact, address, picture, parent_id, tutor_id) " +
                                          "VALUES ( '{0}', '상담', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', NULL)  ", sId, sScore, sName, sGender, sContact, sAddr, MakeToClobQuery(sPic), pId);
                QueryArray.Add( strQuery );

                result = m_OracleAssist.ExcuteArrayQuery( QueryArray );
            }
            return result;            
        }
        public int AddMember(string sId, string sPwd, string sName, string sGender, string sContact, string sAddr, DateTime sRegDate, string sScore, string sPic)
        {
            ArrayList QueryArray = new ArrayList();
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("INSERT INTO member ( id, password, membergroup_code ) VALUES ( '{0}', '{1}', 5 ) ", sId, sPwd);
                QueryArray.Add(strQuery);

                strQuery = string.Format("INSERT INTO waiting (member_id, step, score, name, gender, contact, address, picture, parent_id, tutor_id) " +
                                          "VALUES ( '{0}', '상담', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', NULL)  ", sId, sScore, sName, sGender, sContact, sAddr, MakeToClobQuery(sPic), App.Instance().parent_id);
                QueryArray.Add(strQuery);

                result = m_OracleAssist.ExcuteArrayQuery(QueryArray);
            }
            return result;
        }
        public int ModifyMember(string pId, string pPwd, string pName, string pContact, string pEmail, string sId, string sPwd, string sName, string sGender, string sContact, string sAddr, string sPic)
        {
            ArrayList QueryArray = new ArrayList();
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if(_Connection == null)
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("UPDATE member SET id = '{0}', password = '{1}' WHERE id = '{2}' ", pId, pPwd, App.Instance().parent_id);
                QueryArray.Add( strQuery );

                strQuery = string.Format("UPDATE member SET id = '{0}', password = '{1}' WHERE id = '{2}' ", sId, sPwd, App.Instance().student_id);
                QueryArray.Add( strQuery );

                strQuery = string.Format("UPDATE parent SET member_id = '{0}', name = '{1}', contact = '{2}', email = '{3}' WHERE member_id = '{4}' ", pId, pName, pContact, pEmail, App.Instance().parent_id);
                QueryArray.Add( strQuery );

                strQuery = string.Format("UPDATE student SET member_id = '{0}', name = '{1}', gender = '{2}', contact = '{3}', address = '{4}', picture = {5} WHERE member_id = '{6}' "
                                          , sId, sName, sGender, sContact, sAddr, MakeToClobQuery(sPic), App.Instance().student_id);
                QueryArray.Add( strQuery );

                result = m_OracleAssist.ExcuteArrayQuery(QueryArray);
            }
            return result;            
        }
        //DB 출석 함수
        public DataTable ChoolSeokChk(DateTime start_time, DateTime end_time)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if(_Connection != null )
            {
                string strQuery = string.Format("WITH calendar AS" +
                                                "(" +
                                                "SELECT TO_DATE('{1}','YYYY-MM-DD') + (ROWNUM -1) AS TEMP_CAL " +
                                                "FROM DUAL d " +
                                                "CONNECT BY LEVEL <= (TO_DATE('{2}','YYYY-MM-DD') - TO_DATE('{1}','YYYY-MM-DD') + 1) " +
                                                ") " +
                                                "SELECT temp_cal, s.name, h.name h_name , c.student_id, datetime_in, datetime_out, sch.name sch_name, " +
                                                "CASE WHEN temp_cal > sysdate THEN null " +
                                                "WHEN to_char(temp_cal, 'D') IN (1, 7) THEN null " +
                                                "WHEN sch.name NOT LIKE '%모의고사%' THEN null " +
                                                "WHEN datetime_in < to_date(to_char(datetime_in, 'YYYY-MM-DD') || '08:00:00', 'YYYY-MM-DD HH24:MI:SS') AND datetime_out > to_date(to_char(datetime_out, 'YYYY-MM-DD') || '18:00:00', 'YYYY-MM-DD HH24:MI:SS') THEN '출석' " +
                                                "WHEN datetime_in > to_date(to_char(datetime_in, 'YYYY-MM-DD') || '08:00:00', 'YYYY-MM-DD HH24:MI:SS') AND datetime_out > to_date(to_char(datetime_out, 'YYYY-MM-DD') || '18:00:00', 'YYYY-MM-DD HH24:MI:SS') THEN '지각' " +
                                                "WHEN datetime_out is null AND datetime_in is null THEN '결석' " +
                                                "WHEN datetime_out is null THEN '수업중' " +
                                                "ELSE '조퇴' END AS choolchk " +
                                                "FROM calendar " +
                                                "LEFT JOIN choolseok c ON TO_CHAR(c.datetime_in, 'YYYY-MM-DD') = temp_cal AND c.student_id = '{0}' " +
                                                "LEFT JOIN student s ON s.member_id = c.student_id " +
                                                "LEFT JOIN hakgeup h ON h.code = s.hakgeup_code " +
                                                "LEFT JOIN schedule sch ON sch.schedule_date = temp_cal " +
                                                "ORDER BY temp_cal", App.Instance().student_id, start_time.ToString("yyyy-MM-dd"), end_time.ToString("yyyy-MM-dd"));
                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "student");
            }
            return dt;
        }
        //DB 성적 함수
        public DataTable SearchScore(DateTime start_date, DateTime end_date)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection != null)
            {
                string strQuery = string.Format("SELECT s.name test_name, date_test, std.name std_name, korean, math, english, history, social, science, " +
                                                "(nvl(korean,0) + nvl(math,0) + nvl(english,0) + nvl(history,0) + nvl(social,0) + nvl(science,0)) total " +
                                                "FROM score s " +
                                                "JOIN student std ON std.member_id = s.student_id " +
                                                "WHERE std.member_id = '{0}' and date_test BETWEEN '{1}' AND '{2}' ", App.Instance().student_id, start_date.ToString("yyyy-MM-dd"), end_date.ToString("yyyy-MM-dd") );
                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "score");
            }
            return dt;
        }
        public DataTable SearchScore(int kind)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection != null)
            {
                string strQuery = string.Format("SELECT s.name test_name, date_test, std.name std_name, korean, math, english, history, social, science, " +
                                                "(nvl(korean,0) + nvl(math,0) + nvl(english,0) + nvl(history,0) + nvl(social,0) + nvl(science,0)) total " +
                                                "FROM score s " +
                                                "JOIN student std ON std.member_id = s.student_id " +
                                                "WHERE std.member_id = '{0}' ", App.Instance().student_id);
                if(kind == 0)
                {
                    strQuery += string.Format("and s.name = '평가원' ");
                }
                else
                {
                    strQuery += string.Format("and s.name = '사설' ");
                }

                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "score");
            }
            return dt;
        }
        //DB 일정 함수
        public DataTable Searchschedule(DateTime start_time, DateTime end_time)
        {
            DataTable dt = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection != null)
            {
                string strQuery = string.Format("SELECT schedule_date, name " +
                                                "FROM schedule " +
                                                "WHERE  schedule_date BETWEEN '{0}' AND '{1}' ", start_time.ToString("yyyy-MM-dd"), end_time.ToString("yyyy-MM-dd"));

                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "schedule");
            }
            return dt;
        }
        //DB 수강료 함수
        public DataTable SearchPay()
        {
            DataTable dt = null;
            DbConnection _Connenction = m_OracleAssist.NewConnection();
            if( _Connenction != null )
            {
                string strQuery = string.Format("SELECT name, member_id, contact, payorder, 800000 - pay_amount amount " +
                                                "FROM pay p " +
                                                "JOIN student s ON p.student_id = s.member_id " +
                                                "WHERE member_id = '{0}' " +
                                                "ORDER BY payorder ", App.Instance().student_id);
                dt = m_OracleAssist.SelectQuery(_Connenction, strQuery, "Pay");
            }
            return dt;
        }
        public int AddPay(int month, int amount)
        {
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if(_Connection == null)
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("INSERT INTO pay (student_id, payorder, pay_amount) VALUES ('{0}', {1}, {2} ) ", App.Instance().student_id, month, amount);
                result = m_OracleAssist.ExcuteQuery( strQuery );
            }
            return result;
        }
        public int ModifyPay(int month, int amount)
        {
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("UPDATE pay SET pay_amount = {0} WHERE payorder = {1} ", amount, month);

                result = m_OracleAssist.ExcuteQuery(strQuery);
            }
            return result;
        }
        //DB 코스 함수
        public DataTable SearchCourse()
        {
            DataTable dt = null;
            DbConnection _Connenction = m_OracleAssist.NewConnection();
            if (_Connenction != null)
            {
                string strQuery = string.Format("SELECT h.name h_name, CASE WHEN c.weekday = 1 THEN 'Sun' " +
                                                                                          "WHEN c.weekday = 2 THEN 'Mon' " +
                                                                                          "WHEN c.weekday = 3 THEN 'Tue' " +
                                                                                          "WHEN c.weekday = 4 THEN 'Wed' " +
                                                                                          "WHEN c.weekday = 5 THEN 'Thu' " +
                                                                                          "when c.weekday = 6 THEN 'Fri' " +
                                                                                          "when c.weekday = 7 or c.weekday = 0 THEN 'Say' else NULL END weekday, " +
                                                       "c.gyosi gyosi, t.name t_name, c.name sub " +
                                                "FROM course c " +
                                                "JOIN hakgeup h ON h.code = c.hakgeup_code " +
                                                "JOIN tutor t ON t.member_id = c.tutor_id " +
                                                "JOIN student s ON s.hakgeup_code = h.code " +
                                                "WHERE s.member_id = '{0}' ", App.Instance().student_id);

                dt = m_OracleAssist.SelectQuery(_Connenction, strQuery, "Course");
            }
            return dt;            
        }
        public DataRow SearchTutor()
        {
            DataTable dt = null;
            DataRow dr = null;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                return null;
            }
            else 
            {
                string strQuery = string.Format("SELECT t.name, t.gender, t.contact, t.address, t.subject, t.picture " +
                                                "FROM tutor t " +
                                                "JOIN hakgeup h ON t.member_id = h.tutor_id " +
                                                "JOIN student s ON s.hakgeup_code = h.code " +
                                                "WHERE s.member_id = '{0}' ", App.Instance().student_id);

                dt = m_OracleAssist.SelectQuery(_Connection, strQuery, "tutor");
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                }
            }
            return dr;
        }
        //DB 메세지 함수
        public DataRow SearchMessage(DateTime dateTime)
        {
            DataTable dt = null;
            DataRow dr = null;
            DbConnection _Connenction = m_OracleAssist.NewConnection();
            if (_Connenction != null)
            {
                string strQuery = string.Format("SELECT student_id, parent_id, message, date_register " +
                                                "FROM message " +
                                                "WHERE parent_id = '{0}' and date_register BETWEEN '{1}' AND '{2}' ", App.Instance().parent_id, dateTime.ToString("yyyy-MM-dd"), dateTime.ToString("yyyy-MM-dd"));

                dt = m_OracleAssist.SelectQuery(_Connenction, strQuery, "message");
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                }
            }
            return dr;
        }
        public int AddMessage(string sendmsg, DateTime dateTime)
        {
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                result = -999;
            }
            else
            {                
                    string strQuery = string.Format("INSERT INTO message (student_id, parent_id, message, date_register)" +
                                                    "VALUES ('{0}', '{1}', '{2}', '{3}' ) ", App.Instance().student_id, App.Instance().parent_id, sendmsg, dateTime.ToString("yyyy-MM-dd"));

                    result = m_OracleAssist.ExcuteQuery(strQuery);
            }
            return result;
        }
        public int ModifyMessage(string sendmsg, DateTime dateTime)
        {
            int result = 0;
            DbConnection _Connection = m_OracleAssist.NewConnection();
            if (_Connection == null)
            {
                result = -999;
            }
            else
            {
                string strQuery = string.Format("UPDATE message SET message = '{0}' WHERE date_register = '{1}' ", sendmsg, dateTime.ToString("yyyy-MM-dd"));

                result = m_OracleAssist.ExcuteQuery(strQuery);
            }
            return result;
        }
        public DataRow ReadStudent(string student_id)
        {
            DataTable dt = null;
            DataRow dr = null;
            DbConnection _Connenction = m_OracleAssist.NewConnection();
            if (_Connenction != null)
            {
                string strQuery = string.Format("SELECT s.name, s.member_id, h.name h_name " +
                                                "FROM student s " +
                                                "JOIN hakgeup h ON h.code = s.hakgeup_code " +
                                                "WHERE member_id = '{0}' ", student_id);

                dt = m_OracleAssist.SelectQuery(_Connenction, strQuery, "student");
                if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                }
            }
            return dr;
        }
    }
}
