using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Custom_Dialog
{
    public partial class Form1 : Form
    {
        private GraphicsPath pathRegion = new GraphicsPath(FillMode.Winding);
        private GraphicsPath pathBorder;
        Point pMousePosition = Point.Empty;
        private object resources;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            label5.Image = Custom_Dialog.Properties.Resources.Custom_Confirm1;

            //button1.Focus();
            panel3.Select();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            label2.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            label2.ForeColor = System.Drawing.Color.Black;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            label2.ForeColor = System.Drawing.Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
        }

            private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Confirm");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Confirm & Close");
            this.Close();
        }

        private void panel3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("F5 Press");
            }
            if (Control.ModifierKeys == Keys.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Shift + F5 Press");
            }
        }

        private void KeyDown_Event(object sender, PreviewKeyDownEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("F5 Press");
            }
            if (Control.ModifierKeys == Keys.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Shift + F5 Press");
            }
        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyDown_Event(sender, e);
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyDown_Event(sender, e);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyDown_Event(sender, e);
        }


        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyDown_Event(sender, e);
        }

        private void button2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyDown_Event(sender, e);
        }
    }
}
