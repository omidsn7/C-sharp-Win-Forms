using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleATM
{
    public partial class loginATM : Form
    {
        private Point point;
        private bool mousedown;
        public loginATM()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            point.X = e.X;
            point.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                SetDesktopLocation(MousePosition.X - point.X, MousePosition.Y - point.Y);
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            mainformATM mainformATM = new mainformATM();
            mainformATM.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_login.Enabled = false;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           if (txt_password.Text.Length >= 4)
            {
                btn_login.Enabled = true;
            }
           else if (txt_password.Text.Length < 4)
            {
                btn_login.Enabled = false;
            }
        }
    }
}
