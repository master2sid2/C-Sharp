using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogParser.Base
{
    static class FileInputStram
    {
        private static List<string> inList = new List<string>();

        public static List<string> ControlInList
        {
            get { return inList; }
            set { inList = value; }
        }
    }
}
