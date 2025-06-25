using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notification
{
    
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }
        int fh;
        int sayac = 0;
        int simdikiyukseklik;
        string envdata, lang;


        void readdotenv()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamReader sr = new StreamReader(path + @"\ReminderByIllusDev\Config.env"))
            {
                envdata = sr.ReadToEnd();
                lang = envdata.Split('=')[1].Split(',')[0];
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Animator_Tick(object sender, EventArgs e)
        {
            sayac += 2;
            if (sayac >= fh)
            {
                Animator.Stop();
            }
            else
            {
                this.Top = simdikiyukseklik - sayac;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            readdotenv();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string kalangün = "";
            string saat = "";
            string konu = "";
            string veri = "";
            pictureBox1.Image = Properties.Resources.information_info_1565;
            this.TopMost = true;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(screenWidth - formWidth, (screenHeight - formHeight) + formHeight);
            simdikiyukseklik = this.Top;
            fh = formHeight;
            using (StreamReader reader = new StreamReader(path + @"\ReminderByIllusDev\Data.txt"))
            {

                veri = reader.ReadLine().ToString();
                kalangün = veri.Split('=')[2].Split(' ')[0].ToString();
                saat = veri.Split('=')[2].Split(' ')[1].ToString();
                konu = veri.Split('=')[1].Split(',')[0].ToString();


            }
            if (lang == "tr")
            {
                lblReminder.Text = "HATIRLATMA";
                if (konu.Length >= 30)
                {
                    lblText.Text = $"{konu} \n {kalangün} gün sonra saat {saat} de";

                }
                else
                {
                    lblText.Text = $"{konu} {kalangün} gün sonra saat {saat} de";
                }
            }
            else
            {
                lblReminder.Text = "REMINDER";
                if (konu.Length >= 30)
                {
                    lblText.Text = $"{konu} \n {kalangün} day later at {saat}";

                }
                else
                {
                    lblText.Text = $"{konu} {kalangün} day later at {saat}";
                }
            }
        }
    }
}
