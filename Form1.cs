using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKUniProgTask
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        Brush brush;
        int radius;
        int midX;
        int midY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            brush = (Brush)Brushes.Gray;
            pen = new Pen(Color.Black);
            radius = 150;
            midX = this.Size.Width / 2;
            midY = this.Size.Height / 2;
            string mTxtBox = "";
            for (int i = 0; i < 30; i++)
            {
                mTxtBox += "(Rings : " + i + " input num: " + ((i * 8) + 1).ToString() + ')';
            }
            MultTextBox.Text = mTxtBox;
        }

        private void DrawWafer(int numDots)
        {
            // Draws and fills in the graphic representing our wafer.
            DrawClass.DrawCircle(graphics, pen, midX, midY, radius);
            DrawClass.FillCircle(graphics, brush, midX, midY, radius);

            // Draws the test points for the wafer.
            DrawClass.DrawDots(numDots, graphics, (Brush)Brushes.Black, pen, midX, midY, radius);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Takes the user's input and tests to make sure that 1. it is an integet and 2. it represents (int * 8) + 1.
            string intext = UserInText.Text;
            if(int.TryParse(intext, out int result))
            {
                if((result - 1) % 8 == 0)
                {
                    // Disable unneeded text boxes and button.
                    InstructTextBox.Enabled = InstructTextBox.Visible = false;
                    button1.Enabled = button1.Visible = false;
                    UserInText.Enabled = UserInText.Visible = false;
                    MultTextBox.Enabled = MultTextBox.Visible = false;
                    DrawWafer(result);
                }
                else
                {
                    InstructTextBox.Text = "Number must be (multiple of 8) + 1. Please try again.";
                }
            }
            else
            {
                InstructTextBox.Text = "Number must be an integer represented by (multiple of 8) + 1.";
            }
        }
        private void InstructTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
