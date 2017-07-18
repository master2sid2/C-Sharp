
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

        public static bool RegisterCheckBox { get; set; }

        public static bool InverseCheckBox { get; set; }
    }
}
