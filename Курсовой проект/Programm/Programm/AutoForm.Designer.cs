namespace Programm
{
    partial class AutoForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(62, 101);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(176, 32);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Ползователь";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(65, 148);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(112, 32);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Пароль";
            // 
            // tBUser
            // 
            this.tBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBUser.Location = new System.Drawing.Point(261, 103);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(255, 35);
            this.tBUser.TabIndex = 2;
            // 
            // tBPass
            // 
            this.tBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPass.Location = new System.Drawing.Point(261, 148);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(255, 35);
            this.tBPass.TabIndex = 3;
            this.tBPass.UseSystemPasswordChar = true;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Lime;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(261, 199);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(113, 49);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Войти";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(405, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 78);
            this.panel1.TabIndex = 7;
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(590, 271);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

