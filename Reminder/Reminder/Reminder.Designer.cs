namespace Reminder
{
    partial class Reminder
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.AddReminder = new ButtonCustom();
            this.AddReminderPanel = new System.Windows.Forms.Panel();
            this.WarnText2 = new System.Windows.Forms.Label();
            this.WarnText1 = new System.Windows.Forms.Label();
            this.btnAdd = new ButtonCustom();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.MC = new System.Windows.Forms.MonthCalendar();
            this.lblText = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.RemoveReminder = new ButtonCustom();
            this.Settings = new System.Windows.Forms.Panel();
            this.Languages = new System.Windows.Forms.ComboBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.Notification = new ToggleButton.toggleButton();
            this.lblNotification = new System.Windows.Forms.Label();
            this.LastReminded = new ButtonCustom();
            this.DeleteReminderPanel = new System.Windows.Forms.Panel();
            this.btnResfreshDelete = new ButtonCustom();
            this.btnDelete = new ButtonCustom();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSettings = new ButtonCustom();
            this.LastRemindedPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new ButtonCustom();
            this.lblLastRemindedTime = new System.Windows.Forms.Label();
            this.lblLastremindedText = new System.Windows.Forms.Label();
            this.AddReminderPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.DeleteReminderPanel.SuspendLayout();
            this.LastRemindedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddReminder
            // 
            this.AddReminder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AddReminder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AddReminder, "AddReminder");
            this.AddReminder.ForeColor = System.Drawing.Color.White;
            this.AddReminder.Name = "AddReminder";
            this.AddReminder.TabStop = false;
            this.AddReminder.UseVisualStyleBackColor = false;
            this.AddReminder.Click += new System.EventHandler(this.AddReminder_Click);
            this.AddReminder.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // AddReminderPanel
            // 
            this.AddReminderPanel.Controls.Add(this.WarnText2);
            this.AddReminderPanel.Controls.Add(this.WarnText1);
            this.AddReminderPanel.Controls.Add(this.btnAdd);
            this.AddReminderPanel.Controls.Add(this.lblTime);
            this.AddReminderPanel.Controls.Add(this.lblDate);
            this.AddReminderPanel.Controls.Add(this.tbTime);
            this.AddReminderPanel.Controls.Add(this.MC);
            this.AddReminderPanel.Controls.Add(this.lblText);
            this.AddReminderPanel.Controls.Add(this.tbText);
            resources.ApplyResources(this.AddReminderPanel, "AddReminderPanel");
            this.AddReminderPanel.Name = "AddReminderPanel";
            this.AddReminderPanel.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // WarnText2
            // 
            resources.ApplyResources(this.WarnText2, "WarnText2");
            this.WarnText2.Name = "WarnText2";
            this.WarnText2.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // WarnText1
            // 
            resources.ApplyResources(this.WarnText1, "WarnText1");
            this.WarnText1.Name = "WarnText1";
            this.WarnText1.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            this.lblTime.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            this.lblDate.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // tbTime
            // 
            resources.ApplyResources(this.tbTime, "tbTime");
            this.tbTime.Name = "tbTime";
            this.tbTime.TextChanged += new System.EventHandler(this.WarnControl);
            this.tbTime.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // MC
            // 
            this.MC.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.MC, "MC");
            this.MC.ForeColor = System.Drawing.Color.White;
            this.MC.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.MC.Name = "MC";
            this.MC.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            this.lblText.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // tbText
            // 
            resources.ApplyResources(this.tbText, "tbText");
            this.tbText.Name = "tbText";
            this.tbText.TextChanged += new System.EventHandler(this.WarnControl);
            this.tbText.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // RemoveReminder
            // 
            this.RemoveReminder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RemoveReminder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.RemoveReminder, "RemoveReminder");
            this.RemoveReminder.ForeColor = System.Drawing.Color.White;
            this.RemoveReminder.Name = "RemoveReminder";
            this.RemoveReminder.TabStop = false;
            this.RemoveReminder.UseVisualStyleBackColor = false;
            this.RemoveReminder.Click += new System.EventHandler(this.RemoveReminder_Click);
            this.RemoveReminder.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.Languages);
            this.Settings.Controls.Add(this.lblLang);
            this.Settings.Controls.Add(this.lblOff);
            this.Settings.Controls.Add(this.lblOn);
            this.Settings.Controls.Add(this.Notification);
            this.Settings.Controls.Add(this.lblNotification);
            resources.ApplyResources(this.Settings, "Settings");
            this.Settings.Name = "Settings";
            this.Settings.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // Languages
            // 
            this.Languages.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.Languages, "Languages");
            this.Languages.FormattingEnabled = true;
            this.Languages.Items.AddRange(new object[] {
            resources.GetString("Languages.Items"),
            resources.GetString("Languages.Items1")});
            this.Languages.Name = "Languages";
            this.Languages.TabStop = false;
            this.Languages.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // lblLang
            // 
            resources.ApplyResources(this.lblLang, "lblLang");
            this.lblLang.Name = "lblLang";
            this.lblLang.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // lblOff
            // 
            resources.ApplyResources(this.lblOff, "lblOff");
            this.lblOff.Name = "lblOff";
            this.lblOff.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // lblOn
            // 
            resources.ApplyResources(this.lblOn, "lblOn");
            this.lblOn.Name = "lblOn";
            this.lblOn.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // Notification
            // 
            resources.ApplyResources(this.Notification, "Notification");
            this.Notification.Name = "Notification";
            this.Notification.TabStop = false;
            this.Notification.UseVisualStyleBackColor = true;
            this.Notification.CheckedChanged += new System.EventHandler(this.Notification_Changed);
            this.Notification.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // lblNotification
            // 
            resources.ApplyResources(this.lblNotification, "lblNotification");
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // LastReminded
            // 
            this.LastReminded.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LastReminded.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LastReminded, "LastReminded");
            this.LastReminded.ForeColor = System.Drawing.Color.White;
            this.LastReminded.Name = "LastReminded";
            this.LastReminded.TabStop = false;
            this.LastReminded.UseVisualStyleBackColor = false;
            this.LastReminded.Click += new System.EventHandler(this.LastReminded_Click);
            this.LastReminded.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // DeleteReminderPanel
            // 
            this.DeleteReminderPanel.Controls.Add(this.btnResfreshDelete);
            this.DeleteReminderPanel.Controls.Add(this.btnDelete);
            this.DeleteReminderPanel.Controls.Add(this.listBox1);
            resources.ApplyResources(this.DeleteReminderPanel, "DeleteReminderPanel");
            this.DeleteReminderPanel.Name = "DeleteReminderPanel";
            this.DeleteReminderPanel.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // btnResfreshDelete
            // 
            this.btnResfreshDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResfreshDelete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnResfreshDelete, "btnResfreshDelete");
            this.btnResfreshDelete.ForeColor = System.Drawing.Color.White;
            this.btnResfreshDelete.Name = "btnResfreshDelete";
            this.btnResfreshDelete.TabStop = false;
            this.btnResfreshDelete.UseVisualStyleBackColor = false;
            this.btnResfreshDelete.Click += new System.EventHandler(this.btnResfreshDelete_Click);
            this.btnResfreshDelete.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TabStop = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Reminder.Properties.Resources.settingscog_87317__1_;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabStop = false;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.MouseHover += new System.EventHandler(this.SettingsOpenHover);
            // 
            // LastRemindedPanel
            // 
            this.LastRemindedPanel.Controls.Add(this.btnRefresh);
            this.LastRemindedPanel.Controls.Add(this.lblLastRemindedTime);
            this.LastRemindedPanel.Controls.Add(this.lblLastremindedText);
            resources.ApplyResources(this.LastRemindedPanel, "LastRemindedPanel");
            this.LastRemindedPanel.Name = "LastRemindedPanel";
            this.LastRemindedPanel.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabStop = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // lblLastRemindedTime
            // 
            resources.ApplyResources(this.lblLastRemindedTime, "lblLastRemindedTime");
            this.lblLastRemindedTime.Name = "lblLastRemindedTime";
            this.lblLastRemindedTime.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // lblLastremindedText
            // 
            resources.ApplyResources(this.lblLastremindedText, "lblLastremindedText");
            this.lblLastremindedText.Name = "lblLastremindedText";
            this.lblLastremindedText.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            // 
            // Reminder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CausesValidation = false;
            this.Controls.Add(this.LastRemindedPanel);
            this.Controls.Add(this.DeleteReminderPanel);
            this.Controls.Add(this.LastReminded);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.RemoveReminder);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.AddReminderPanel);
            this.Controls.Add(this.AddReminder);
            this.MaximizeBox = false;
            this.Name = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.MouseHover += new System.EventHandler(this.SettingsCloseLeave);
            this.AddReminderPanel.ResumeLayout(false);
            this.AddReminderPanel.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.DeleteReminderPanel.ResumeLayout(false);
            this.LastRemindedPanel.ResumeLayout(false);
            this.LastRemindedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCustom buttonCustom1;
        private ButtonCustom AddReminder;
        private System.Windows.Forms.Panel AddReminderPanel;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.ComboBox Languages;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblOn;
        private ToggleButton.toggleButton Notification;
        private System.Windows.Forms.Label lblNotification;
        private ButtonCustom btnSettings;
        private ButtonCustom RemoveReminder;
        private ButtonCustom LastReminded;
        private System.Windows.Forms.MonthCalendar MC;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label WarnText2;
        private System.Windows.Forms.Label WarnText1;
        private System.Windows.Forms.Panel DeleteReminderPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel LastRemindedPanel;
        private System.Windows.Forms.Label lblLastRemindedTime;
        private System.Windows.Forms.Label lblLastremindedText;
        private ButtonCustom btnAdd;
        private ButtonCustom btnResfreshDelete;
        private ButtonCustom btnDelete;
        private ButtonCustom btnRefresh;
    }
}

