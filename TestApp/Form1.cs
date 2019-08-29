using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Updated from other site!...");
            int row =6, col=7;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button day = new Button() {
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.FromArgb(30, 30, 30),
                        Width = 50,
                        Height = 50,
                        Left = j * 50,
                        Top = i * 50,
                        Text = i.ToString(),
                        ForeColor = Color.White
                    };
                    day.FlatAppearance.BorderColor = Color.Gray;
                    day.FlatAppearance.MouseDownBackColor = Color.AliceBlue;
                    panel1.Controls.Add(day);
                    if (i * j == 3)
                    {
                        day.ForeColor = Color.Blue;
                        day.BackColor = Color.Yellow;
                        day.Enabled = false;
                    }
                }
            }
        }
    }
}
