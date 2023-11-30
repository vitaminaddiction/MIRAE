using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIRAEPRO.Manager.ChoolSeok
{
    public class ClassChool
    {
        
            public DateTime datetime_in;
            public DateTime datetime_out;
            public string s_name;
            public ClassChool(DateTime 입실시간, DateTime 퇴실시간, string 학생이름)
            {
                this.datetime_in = 입실시간;
                this.datetime_out = 퇴실시간;
                this.s_name = 학생이름;
            }
        
    }
}
