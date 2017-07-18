using System.Collections.Generic;

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
