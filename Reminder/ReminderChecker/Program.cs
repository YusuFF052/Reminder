using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReminderChecker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string envdata, canremind;
            void readdotenv()
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamReader sr = new StreamReader(path + @"\ReminderByIllusDev\Config.env"))
                {
                    envdata = sr.ReadToEnd();
                    canremind = envdata.Split('=')[2].Split(',')[0];
                }
            }
            try
            {
                bool wait10min = true;
                string appfolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                List<string> toRemove = new List<string>();
                while (true)
                {

                    readdotenv();
                    if(canremind == "true")
                    {
                        JObject o1 = JObject.Parse(File.ReadAllText(path + @"\ReminderByIllusDev\ReminderData.json"));
                        DateTime today = DateTime.Parse(DateTime.Today.ToString().Split(' ')[0]);
                        sortjson();

                        void sortjson()
                        {
                            var sortedProperties = o1.Properties()
                                .OrderBy(p => DateTime.Parse(p.Value["Tarih"].ToString().Split('-')[0]))
                                .ThenBy(p => p.Value["Tarih"].ToString().Split('-')[1])
                                .ToList();
                            JObject sortedJsonObject = new JObject();
                            foreach (var property in sortedProperties)
                            {
                                sortedJsonObject.Add(property.Name, property.Value);
                            }
                            using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\ReminderData.json", false))
                            {
                                wrtr.WriteLine(sortedJsonObject);
                            }
                        }
                        foreach (var key in o1.Properties())
                        {
                            DateTime reminderDate = DateTime.Parse(key.Value["Tarih"].ToString().Split('-')[0]);
                            string reminderTime = key.Value["Tarih"].ToString().Split('-')[1];
                            string reminderName = key.Name;
                            readdotenv();
                            if ((reminderDate - today).Days <= 3)
                            {
                                if (reminderDate == today)
                                {
                                    wait10min = true;
                                    using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\Data.txt", false))
                                    {

                                        wrtr.WriteLine($"Konu={key.Name},TarihveSaat=0 {key.Value["Tarih"].ToString().Split('-')[1]}");
                                    }
                                    Process.Start(AppDomain.CurrentDomain.BaseDirectory+ "Notification.exe");

                                    if (wait10min)
                                    {
                                        await Task.Delay(TimeSpan.FromMinutes(10));
                                    }
                                }
                                else if (reminderDate > today)
                                {
                                    wait10min = true;
                                    using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\Data.txt", false))
                                    {
                                        wrtr.WriteLine($"Konu={key.Name},TarihveSaat={(reminderDate - today).ToString().Split('.')[0]} {key.Value["Tarih"].ToString().Split('-')[1]}");
                                    }
                                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Notification.exe");

                                    if (wait10min)
                                    {
                                        await Task.Delay(TimeSpan.FromMinutes(10));
                                    }
                                }
                                else if (reminderDate < today)
                                {
                                    wait10min = false;
                                    toRemove.Add(reminderName);
                                }
                            }
                            else
                            {

                            }
                        }
                        foreach (string name in toRemove)
                        {
                            o1.Remove(name);
                            using (StreamWriter wrtr = new StreamWriter(path + @"\ReminderByIllusDev\ReminderData.json", false))
                            {
                                wrtr.WriteLine(o1);
                            }
                        }
                        toRemove.Clear();
                    }
                    else
                    {
                        wait10min = false;
                        using (StreamWriter sw = new StreamWriter(path + "\\debug.txt", false))
                        {
                            sw.WriteLine(canremind);
                        }
                    }
                    await Task.Delay(10000);
                }
            }
            catch (Exception ex)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter sw= new StreamWriter(path + "\\error.txt", false))
                {
                    sw.WriteLine("ERROR:"+ex.Message);
                    sw.WriteLine("FUNCTION:"+ ex.StackTrace);
                    sw.WriteLine("PATH:"+Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
                }
               
            }
        }
    }
}