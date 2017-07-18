using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogParser.GUI
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        public void setText(string inputString)
        {
            PreviewTextBox.Text = inputString;
        }

        public void clearTextBox()
        {
            PreviewTextBox.Clear();
        }

        public string getText()
        {
            return PreviewTextBox.Text;
        }

        public void setLinesCount(int number)
        {
            if(number>=0)
                StatusStripLabel.Text = string.Format("Строк: {0}", number);
            else
                StatusStripLabel.Text = string.Format("Строк: {0}", number - 1);
            
        }
        public int getLinesCount()
        {
            return PreviewTextBox.Lines.Count();
        }
    }
}
