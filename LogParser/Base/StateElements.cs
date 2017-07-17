using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogParser.Base
{
    static class StateElements
    {
        private static bool VisiblePreviewWindows = true;

        public static bool PreviewWindowState
        {
            get { return VisiblePreviewWindows; }
            set { VisiblePreviewWindows = value; }
        }
    }
}
