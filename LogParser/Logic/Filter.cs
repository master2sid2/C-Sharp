using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogParser.Base;
using LogParser.GUI;

namespace LogParser.Logic
{
    static class Filter
    {
        private static TextBox previewBox;
        private static StringBuilder fillLine = new StringBuilder();
        public static void setFilter(PreviewForm preview, string inputString)
        {
            fillLine.Clear();
            if (!StateElements.RegisterCheckBox && !StateElements.InverseCheckBox)
            {
                RegisteredFilter(inputString);
            }
            else if (StateElements.RegisterCheckBox && !StateElements.InverseCheckBox)
            {
                foreach (var element in FileInputStram.ControlInList)
                {
                    if (element.Contains(inputString))
                    {
                        fillLine.AppendLine(element);
                    }
                }
            }
            else if (StateElements.RegisterCheckBox && StateElements.InverseCheckBox)
            {
                foreach (var element in FileInputStram.ControlInList)
                {
                    if (!element.Contains(inputString))
                    {
                        fillLine.AppendLine(element);
                    }
                }
            }
            else if (!StateElements.RegisterCheckBox && StateElements.InverseCheckBox)
            {
                InversedFilter(inputString);
                
            }
            preview.setText(fillLine.ToString());
            LinesCounter(preview);
        }
        private static void RegisteredFilter(string str)
        {
            fillLine.Clear();
            foreach (var element in FileInputStram.ControlInList)
            {
                if (element.ToLower().Contains(str.ToLower()))
                {
                    fillLine.AppendLine(element);
                }
            }
        }

        private static void InversedFilter(string str)
        {
            fillLine.Clear();
            foreach (var element in FileInputStram.ControlInList)
            {
                if (!element.ToLower().Contains(str.ToLower()))
                {
                    fillLine.AppendLine(element);
                }
            }
        }

        public static string getFilteredText()
        {
            return fillLine.ToString();
        }

        public static void LinesCounter(PreviewForm preview)
        {
            preview.setLinesCount(preview.PreviewTextBox.Lines.Where(line => !String.IsNullOrWhiteSpace(line)).Count());
        }
    }
}
