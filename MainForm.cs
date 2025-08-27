using System.Drawing;
using System.Windows.Forms;

namespace WinCounter
{
    public class MainForm : Form
    {
        public MainForm()
        {
            Text = "Compteur";
            ClientSize = new Size(400, 220);
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}