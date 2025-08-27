using System.Drawing;
using System.Windows.Forms;

namespace WinCounter
{

    public class MainForm : Form
    {
        private Label labelCount;
        public MainForm()
        {
            Text = "Compteur";
            ClientSize = new Size(400, 220);
            StartPosition = FormStartPosition.CenterScreen;

            labelCount = new Label
            {
                Dock = DockStyle.Top,
                Height = 100,
                Font = new Font(Font.FontFamily, 36, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "0"
            };
            Controls.Add(labelCount);
        }
    }
}