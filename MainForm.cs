using System.Drawing;
using System.Windows.Forms;

namespace WinCounter
{

    public class MainForm : Form
    {
        private Label labelCount;
        private Button btnPlusOne;
        private int count = 0;
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

            btnPlusOne = new Button
            {
                Text = "+1",
                Width = 120,
                Height = 40,
                Left = 50,
                Top = 120,
                TabIndex = 0
            };

            btnPlusOne.Click += (_, __) =>
            {
                count++;
                UpdateView();
            };
            Controls.Add(btnPlusOne);

        }

        private void UpdateView()
        {
            labelCount.Text = count.ToString();
        }
    }
}