using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPrinter.Objects
{
    public class ServerSettings
    {
        public string Server { get; set; }
        public int ServerPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int TimeOut { get; set; }
        public bool Ssl { get; set; }
        public int Interval { get; set; }
        public string key { get; set; }
    }
}
