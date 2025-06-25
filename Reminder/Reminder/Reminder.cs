using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace Reminder
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }
        string selecteditem;
        string veri, kalangün, saat, konu;
        string lang, envdata, canremind;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void createdotenv()
        {
            if (File.Exists(path + @"\ReminderByIllusDev\Config.env")) { }
            else
            {
                using (StreamWriter sw = new StreamWriter(path + @"\ReminderByIllusDev\Config.env", false))
                {
                    sw.WriteLine("Lang=en,");
                    sw.WriteLine("CanRemind=true,");
                }
            }
        }

        void firstdatatxtfile()
        {
            if (!File.Exists(path + @"\ReminderByIllusDev\data.txt"))
            {
                using(StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\data.txt", false))
                {
                    wrtr.WriteLine("Konu=You were not reminded of anything,TarihveSaat=0 00.00");
                }
            }
        }
        void changeenglish() 
        {
            AddReminder.Text = "Add Reminder";
            RemoveReminder.Text = "Remove From Reminder";
            LastReminded.Text = "See Last Reminded";
            lblDate.Text = "Date Here!";
            lblText.Text = "Text Here!";
            lblLang.Text = "Languages";
            lblNotification.Text = "Notifications";
            lblTime.Text = "Time Here!";
            btnAdd.Text = "Add";
            lblOff.Text = "Off";
            lblOn.Text = "On";
            btnDelete.Text = "Delete";
            btnResfreshDelete.Text = "Refresh"; btnRefresh.Text = "Refresh";
        }
        void changeturkish() 
        {
            AddReminder.Text = "Hatırlatıcı Ekle";
            RemoveReminder.Text = "Hatırlatıcıdan Kaldır";
            LastReminded.Text = "Son Hatırlananı Gör";
            lblDate.Text = "Tarih Buraya!";
            lblText.Text = "Yazı Buraya!";
            lblLang.Text = "Diller";
            lblNotification.Text = "Bildirimler";
            btnAdd.Text = "Ekle";
            lblTime.Text = "Saat Buraya!";
            lblOff.Text = "Kapalı";
            lblOn.Text = "Açık";
            btnDelete.Text = "Sil";
            btnResfreshDelete.Text = "Yenile"; btnRefresh.Text = "Yenile";
        }
        void readdotenv()
        {
            using (StreamReader sr = new StreamReader(path + @"\ReminderByIllusDev\Config.env"))
            {
                envdata = sr.ReadToEnd();
                lang = envdata.Split('=')[1].Split(',')[0];
                canremind = envdata.Split('=')[2].Split(',')[0];
            }
        }
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk.GetValue("ReminderChecker") == null)
            {
                rk.SetValue("ReminderChecker", AppDomain.CurrentDomain.BaseDirectory + "ReminderChecker.exe");
                if (lang == "tr")
                {
                    MessageBox.Show("Yeniden Başlatmanız Gerek", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("you need to restart the computer", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { }
        }
        private void Reminder_Load(object sender, EventArgs e)
        {
            
            if(Directory.Exists(path + @"\ReminderByIllusDev")){}
            else
            {
                Directory.CreateDirectory(path + @"\ReminderByIllusDev");
            }
            this.AcceptButton = null;
            this.CancelButton = null;
            createdotenv();
            readdotenv();
            SetStartup();
            firstdatatxtfile();
            updatedeletedata(); updatelastreminded();
            
            if (canremind == "true")
            {
                Notification.Checked = true;
            }
            else
            {
                Notification.Checked = false;
            }
            if (lang == "tr")
            {
                Languages.SelectedIndex = 1;
                changeturkish();
            }
            else
            {
                Languages.SelectedIndex = 0;
                changeenglish();
            }
            this.Languages.SelectedIndexChanged += new System.EventHandler(this.Language_Changed);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + @"\ReminderByIllusDev\ReminderData.json"))
            {
                writejsondata();
            }
            else
            {
                Directory.CreateDirectory(path + @"\ReminderByIllusDev");
                using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\ReminderData.json", true))
                {
                    wrtr.WriteLine("{}");
                }
                writejsondata();
            }
        }
        void writejsondata()
        {
            JObject existingData = JObject.Parse(File.ReadAllText(path + @"\ReminderByIllusDev\ReminderData.json"));
            JObject newEntry = new JObject(
                new JProperty("Tarih", MC.SelectionStart.ToString().Split(' ')[0] + "-" + tbTime.Text));
            existingData[tbText.Text] = newEntry;
            File.WriteAllText(path + @"\ReminderByIllusDev\ReminderData.json", existingData.ToString());
        }
        private void AddReminder_Click(object sender, EventArgs e)
        {
            AddReminderPanel.Visible = true;
            DeleteReminderPanel.Visible = false;
            LastRemindedPanel.Visible = false;
        }
        private void RemoveReminder_Click(object sender, EventArgs e)
        {
            AddReminderPanel.Visible = false;
            DeleteReminderPanel.Visible = true;
            LastRemindedPanel.Visible = false;
        }
        private void LastReminded_Click(object sender, EventArgs e)
        {
            AddReminderPanel.Visible = false;
            DeleteReminderPanel.Visible = false;
            LastRemindedPanel.Visible = true;
        }
        private void btnResfreshDelete_Click(object sender, EventArgs e)
        {
            updatedeletedata();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                JObject o1 = JObject.Parse(File.ReadAllText(path + @"\ReminderByIllusDev\ReminderData.json"));
                selecteditem = listBox1.SelectedItem.ToString();
                foreach (var key in o1.Properties())
                {
                    if (key.Name == selecteditem)
                    {
                        o1.Remove(key.Name);
                        using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\ReminderData.json", false))
                        {
                            wrtr.WriteLine(o1);
                        }
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        break;
                    }
                    else { }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (Exception ex)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter sw = new StreamWriter(path + "\\error.txt", false))
                {
                    sw.WriteLine("Error:" + ex.Message);
                    sw.WriteLine("");
                    sw.WriteLine(ex.StackTrace);
                }
                MessageBox.Show($"Hata Detayları: {path + "\\error.txt"} de hata detaylarını inceleyin veya geliştiriciyle iletişime geçin.");
            }
        }
        private void Language_Changed(object sender, EventArgs e)
        {
            if(Languages.SelectedIndex == 1)
            {
                using (StreamWriter sw = new StreamWriter(path + @"\ReminderByIllusDev\Config.env", false))
                {
                    sw.WriteLine("Lang=tr,");
                    sw.WriteLine($"CanRemind={canremind},");
                }
                changeturkish();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path + @"\ReminderByIllusDev\Config.env", false))
                {
                    sw.WriteLine("Lang=en,");
                    sw.WriteLine($"CanRemind={canremind},");
                }
                changeenglish();
            }
        }
        private void Notification_Changed(object sender, EventArgs e)
        {
            if (Notification.Checked)
            {
                using (StreamWriter sw = new StreamWriter(path + @"\ReminderByIllusDev\Config.env", false))
                {
                    sw.WriteLine($"Lang={lang},");
                    sw.WriteLine("CanRemind=true,");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path + @"\ReminderByIllusDev\Config.env", false))
                {
                    sw.WriteLine($"Lang={lang},");
                    sw.WriteLine("CanRemind=false,");
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updatelastreminded();
        }
        void updatelastreminded()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamReader reader = new StreamReader(path + @"\ReminderByIllusDev\Data.txt"))
                {
                    veri = reader.ReadLine().ToString();
                    kalangün = veri.Split('=')[2].Split(' ')[0].ToString();
                    saat = veri.Split('=')[2].Split(' ')[1].ToString();
                    konu = veri.Split('=')[1].Split(',')[0].ToString();
                }
                if (lang == "tr")
                {
                    lblLastremindedText.Text = konu;
                    lblLastRemindedTime.Text = $"{kalangün} gün sonra saat {saat} de";
                }
                else
                {
                    lblLastremindedText.Text = konu;
                    lblLastRemindedTime.Text = $"{kalangün} day later at {saat}";
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null hatası aldınız! Eğer bir dosyadan yazı sildiyseniz hataya sebebiyet vermiş olabilir çözülmesi için 10 dakikada 1 olan hatırlatıcıyı bekleyin.");
            }
            catch (Exception ex)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter sw = new StreamWriter(path + "\\error.txt", false))
                {
                    sw.WriteLine("Error:" + ex.Message);
                    sw.WriteLine("");
                    sw.WriteLine(ex.StackTrace + "\n");
                    sw.WriteLine(ex);
                }
                MessageBox.Show($"Hata Detayları: {path + "\\error.txt"} de hata detaylarını inceleyin veya geliştiriciyle iletişime geçin.");
            }
        }
        void updatedeletedata()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                JObject o1 = JObject.Parse(File.ReadAllText(path + @"\ReminderByIllusDev\ReminderData.json"));
                listBox1.Items.Clear();
                foreach (var key in o1.Properties())
                {
                    listBox1.Items.Add(key.Name);
                }
                listBox1.Enabled = true;
            }
            catch 
            {
                listBox1.Enabled = false;
                if (lang == "tr")
                {
                    listBox1.Items.Clear(); listBox1.Items.Add("Birşeyler Bulunamadı");
                }
                else 
                {
                    listBox1.Items.Clear(); listBox1.Items.Add("Nothing Found");
                }
                
            }
        }
        private void SettingsOpenHover(object sender, EventArgs e)
        {
            Settings.Visible = true;
        }
        private void SettingsCloseLeave(object sender, EventArgs e)
        {
            Settings.Visible = false;
        }
        private void WarnControl(object sender, EventArgs e)
        {
            try
            {
                if (lang == "tr")
                {
                    if (tbText.Text.Length <= 45)
                    {
                        if (tbText.Text.Contains("=") || tbText.Text.Contains(","))
                        {
                            WarnText1.ForeColor = Color.Red;
                            WarnText1.Text = "Yazınız '=' ve ',' İçermemelidir!";
                            btnAdd.Enabled = false;
                        }
                        else
                        {
                            if (((tbTime.Text.Split('.')[0].Length == 2 && tbTime.Text.Split('.')[1].Length == 2) && (int.Parse(tbTime.Text.Split('.')[0]) <= 23 && int.Parse(tbTime.Text.Split('.')[1]) <= 59)) && tbTime.Text.Split('.').Length - 1 == 1)
                            {
                                WarnText2.Text = "";
                                if (string.IsNullOrEmpty(tbText.Text) || string.IsNullOrWhiteSpace(tbText.Text)) { btnAdd.Enabled = false; WarnText1.ForeColor = Color.Red; WarnText1.Text = "Lütfen Hatırlamak İstediğiniz Yazıyı Yazınız"; return; }
                                else { WarnText1.Text = ""; }
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                WarnText2.ForeColor = Color.Red;
                                WarnText2.Text = "Lütfen Saati Doğru Biçimde Giriniz. \n Örnek : 12.00 veya 08.00";
                                btnAdd.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        WarnText1.ForeColor = Color.Red;
                        WarnText1.Text = "Yazınız En Fazla 45 Karakter Uzunluğunda Olabilir!";
                        btnAdd.Enabled = false;
                    }
                }
                else
                {
                    if (tbText.Text.Length <= 45)
                    {
                        if (tbText.Text.Contains("=") || tbText.Text.Contains(","))
                        {
                            WarnText1.ForeColor = Color.Red;
                            WarnText1.Text = "your text must not contain ‘=’ and ','!";
                            btnAdd.Enabled = false;
                        }
                        else
                        {
                            if (((tbTime.Text.Split('.')[0].Length == 2 && tbTime.Text.Split('.')[1].Length == 2) && (int.Parse(tbTime.Text.Split('.')[0]) <= 23 && int.Parse(tbTime.Text.Split('.')[1]) <= 59)) && tbTime.Text.Split('.').Length - 1 == 1)
                            {
                                WarnText2.Text = "";
                                if (string.IsNullOrEmpty(tbText.Text) || string.IsNullOrWhiteSpace(tbText.Text)) { btnAdd.Enabled = false; WarnText1.ForeColor = Color.Red; WarnText1.Text = "Please write down the text you want to remember"; return; }
                                else { WarnText1.Text = ""; }
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                WarnText2.ForeColor = Color.Red;
                                WarnText2.Text = "Please enter the correct time. \n Example : 12.00 or 08.00";
                                btnAdd.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        WarnText1.ForeColor = Color.Red;
                        WarnText1.Text = "Your text can be up to 45 characters long!";
                        btnAdd.Enabled = false;
                    }
                }
            }
            catch { }
        }
    }
}