using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = true;
            pictureBox5.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        public void logincontrol()
        {
            if (loginss.Text == "123" && textBox2.Text == "123")
            {
                main form = new main();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = false;
            pictureBox5.Visible = false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(223, 225, 230);
            loginss.BackColor = Color.FromArgb(223, 225, 230);
            panel3.BackColor = Color.FromArgb(209, 217, 215);
            textBox2.BackColor = Color.FromArgb(209, 217, 215);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(223, 225, 230);
            textBox2.BackColor = Color.FromArgb(223, 225, 230);
            panel2.BackColor = Color.FromArgb(209, 217, 215);
            loginss.BackColor = Color.FromArgb(209, 217, 215);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(218, 226, 234);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(218, 226, 234);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(209, 217, 216);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(209, 217, 216);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logincontrol();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox7;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logincontrol();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logincontrol();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
