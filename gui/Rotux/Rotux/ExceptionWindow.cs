using System.Windows.Forms;

namespace Rotux
{
    public partial class ExceptionWindow : Form
    {
        public ExceptionWindow(string e)
        {
            InitializeComponent();
            errortext.Text = e;
        }
    }
}
