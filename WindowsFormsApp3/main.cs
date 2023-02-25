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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] musteri1 = { "Arda", "Kaplan", "24563417325", "Erkek", "ODA1", "500", "24.01.2023", "27.01.2023" };
            string[] musteri2 = { "Aslı", "Deniz", "13452643412", "Kadın", "ODA2", "700", "26.01.2023", "30.01.2023", };
            ListViewItem m1 = new ListViewItem(musteri1);
            ListViewItem m2 = new ListViewItem(musteri2);
            listView1.Items.Add(m1);
            listView1.Items.Add(m2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button3.Text;
            button3.BackColor = Color.Yellow;
            if(button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }

        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(209, 217, 216);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(218, 226, 234);
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(209, 217, 216);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(218, 226, 234);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color deneme = button4.BackColor = Color.White;
            maskedTextBox8.Text = button4.Text;
            button4.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button5.Text;
            button5.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button6.Text;
            button6.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button7.Text;
            button7.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button8.Text;
            button8.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button9.Text;
            button9.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                    if (maskedTextBox8.Text == "ODA1")
                    {
                        button1.BackColor = Color.FromArgb(91, 30, 27);
                        button1.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA2")
                    {
                        button2.BackColor = Color.FromArgb(91, 30, 27);
                        button2.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA3")
                    {
                        button3.BackColor = Color.FromArgb(91, 30, 27);
                        button3.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA4")
                    {
                        button4.BackColor = Color.FromArgb(91, 30, 27);
                        button4.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA5")
                    {
                        button5.BackColor = Color.FromArgb(91, 30, 27);
                        button5.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA6")
                    {
                        button6.BackColor = Color.FromArgb(91, 30, 27);
                        button6.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA7")
                    {
                        button7.BackColor = Color.FromArgb(91, 30, 27);
                        button7.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA8")
                    {
                        button8.BackColor = Color.FromArgb(91, 30, 27);
                        button8.Enabled = false;
                    }
                    if (maskedTextBox8.Text == "ODA9")
                    {
                        button9.BackColor = Color.FromArgb(91, 30, 27);
                        button9.Enabled = false;
                    }
                    string ad = maskedTextBox1.Text;
                    string soyad = maskedTextBox2.Text;
                    string tc = maskedTextBox3.Text;
                    string cinsiyet = comboBox1.SelectedItem.ToString();
                    string secilioda = maskedTextBox8.Text;
                    string ucret = maskedTextBox7.Text;
                    string giris = dateTimePicker1.Text.ToString();
                    string cikis = dateTimePicker2.Text.ToString();
                    string[] yenimusteri = { ad, soyad, tc, cinsiyet, secilioda, ucret, giris, cikis };
                    ListViewItem yeni = new ListViewItem(yenimusteri);
                    listView1.Items.Add(yeni);
            }
            catch
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

             
        }

        private void button12_Click(object sender, EventArgs e)
        {        
            try
            {
                string deneme = listView1.CheckedItems[0].SubItems[4].Text.ToString();
                listView1.Items.Remove(listView1.CheckedItems[0]);
                if(deneme == button1.Text)
                {
                    button1.BackColor = Color.FromArgb(0, 192, 0);
                    button1.Enabled = true;
                }
                if (deneme == button2.Text)
                {
                    button2.BackColor = Color.FromArgb(0, 192, 0);
                    button2.Enabled = true;
                }
                if (deneme == button3.Text)
                {
                    button3.BackColor = Color.FromArgb(0, 192, 0);
                    button3.Enabled = true;
                }
                if (deneme == button4.Text)
                {
                    button4.BackColor = Color.FromArgb(0, 192, 0);
                    button4.Enabled = true;
                }
                if (deneme == button5.Text)
                {
                    button5.BackColor = Color.FromArgb(0, 192, 0);
                    button5.Enabled = true;
                }
                if (deneme == button6.Text)
                {
                    button6.BackColor = Color.FromArgb(0, 192, 0);
                    button6.Enabled = true;
                }
                if (deneme == button7.Text)
                {
                    button7.BackColor = Color.FromArgb(0, 192, 0);
                    button7.Enabled = true;
                }
                if (deneme == button8.Text)
                {
                    button8.BackColor = Color.FromArgb(0, 192, 0);
                    button8.Enabled = true;
                }
                if (deneme == button9.Text)
                {
                    button9.BackColor = Color.FromArgb(0, 192, 0);
                    button9.Enabled = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seçim yapmadan silemezsin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button5.BackColor = Color.FromArgb(0, 192, 0);
            button6.BackColor = Color.FromArgb(0, 192, 0);
            button7.BackColor = Color.FromArgb(0, 192, 0);
            button8.BackColor = Color.FromArgb(0, 192, 0);
            button9.BackColor = Color.FromArgb(0, 192, 0);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button2.Text;
            button2.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox8.Text = button1.Text;
            button1.BackColor = Color.Yellow;
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button5.BackColor == Color.Yellow)
            {
                button5.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button6.BackColor == Color.Yellow)
            {
                button6.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button7.BackColor == Color.Yellow)
            {
                button7.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button8.BackColor == Color.Yellow)
            {
                button8.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (button9.BackColor == Color.Yellow)
            {
                button9.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
