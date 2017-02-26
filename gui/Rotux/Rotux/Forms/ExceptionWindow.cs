using System.Windows.Forms;

namespace Rotux.Forms
{
    partial class ExceptionWindow : Form
    {
        public ExceptionWindow(string e)
        {

            InitializeComponent();
            errortext.Text = e;
        }
    }
}
