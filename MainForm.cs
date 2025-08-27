using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WinCounter
{

    public class MainForm : Form
    {
        private Label labelCount;
        private Button btnPlusOne;
        private Button btnReset;
        private static readonly string AppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinCounter");
        private static readonly string CountFile = Path.Combine(AppFolder, "count.txt");

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

            btnReset = new Button
            {
                Text = "Réinitialiser",
                Width = 120,
                Height = 40,
                Left = 230,
                Top = 120,
                TabIndex = 1
            };
            btnReset.Click += (_, __) =>
            {
                count = 0;
                UpdateView();
            };
            Controls.Add(btnReset);

            AcceptButton = btnPlusOne;
            CancelButton = btnReset;
            LoadCount();
            UpdateView();
            this.FormClosing += (_, __) => SaveCount();

        }

        private void UpdateView()
        {
            labelCount.Text = count.ToString();
        }
        private void LoadCount()
        {
            try
            {
                if (!File.Exists(CountFile)) return;
                var text = File.ReadAllText(CountFile).Trim();
                if (int.TryParse(text, out var value))
                    count = value;
            }
            catch
            {

            }
        }

        private void SaveCount()
        {
            try
            {
                Directory.CreateDirectory(AppFolder);
                File.WriteAllText(CountFile, count.ToString());
            }
            catch
            {

            }
        }
    }
}