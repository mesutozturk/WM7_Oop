using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int Count = 16;
        private List<bool> _mineStatus = new();
        private Color _color = Color.Gray, _colorBomb = Color.Tomato, _colorFree = Color.LimeGreen;

        private void yeniOyunToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            flp1.Controls.Clear();
            _mineStatus = new();
            Random rnd = new();
            for (int i = 0; i < Count; i++)
            {
                bool durum = rnd.Next() % 2 == 0;
                _mineStatus.Add(durum);

                Button btn = new Button()
                {
                    Name = $"btn_{i + 1}",
                    Text = "X",
                    Size = new Size(135, 97),
                    BackColor = _color,
                    Tag = i
                };
                btn.Click += Btn_Click;
                flp1.Controls.Add(btn);
            }
            //Linq 
            this.Text = $"Bomba Sayısı: {_mineStatus.Count(x => x)}";
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            int index = Convert.ToInt32(selectedButton.Tag);
            if (_mineStatus[index])
            {
                selectedButton.BackColor = _colorBomb;
                MessageBox.Show("Bitti");
            }
            else
            {
                selectedButton.BackColor = _colorFree;
            }
        }
    }
}
