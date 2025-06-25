namespace Notification
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Animator = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCustom1 = new ButtonCustom();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Animator
            // 
            this.Animator.Enabled = true;
            this.Animator.Interval = 1;
            this.Animator.Tick += new System.EventHandler(this.Animator_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notification.Properties.Resources.information_info_1565;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(395, 101);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(121, 37);
            this.buttonCustom1.TabIndex = 10;
            this.buttonCustom1.Text = "Okay";
            this.buttonCustom1.UseVisualStyleBackColor = false;
            this.buttonCustom1.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReminder.Location = new System.Drawing.Point(110, 31);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(140, 28);
            this.lblReminder.TabIndex = 11;
            this.lblReminder.Text = "REMINDER";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(12, 85);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(140, 28);
            this.lblText.TabIndex = 12;
            this.lblText.Text = "REMINDER";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(528, 150);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Animator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblText;
        private ButtonCustom buttonCustom1;
    }
}

