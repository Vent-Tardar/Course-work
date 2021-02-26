namespace Programm
{
    partial class adfmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.week = new System.Windows.Forms.Button();
            this.SeeMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Lime;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(195, 408);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(398, 74);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.Lime;
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(195, 301);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(398, 74);
            this.Report.TabIndex = 16;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // week
            // 
            this.week.BackColor = System.Drawing.Color.Lime;
            this.week.FlatAppearance.BorderSize = 0;
            this.week.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.week.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.week.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.week.Location = new System.Drawing.Point(195, 187);
            this.week.Name = "week";
            this.week.Size = new System.Drawing.Size(398, 74);
            this.week.TabIndex = 15;
            this.week.Text = "Выбор блюд";
            this.week.UseVisualStyleBackColor = false;
            this.week.Click += new System.EventHandler(this.week_Click);
            // 
            // SeeMenu
            // 
            this.SeeMenu.BackColor = System.Drawing.Color.Lime;
            this.SeeMenu.FlatAppearance.BorderSize = 0;
            this.SeeMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.SeeMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.SeeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeMenu.Location = new System.Drawing.Point(194, 78);
            this.SeeMenu.Name = "SeeMenu";
            this.SeeMenu.Size = new System.Drawing.Size(398, 74);
            this.SeeMenu.TabIndex = 14;
            this.SeeMenu.Text = "Просмотр меню";
            this.SeeMenu.UseVisualStyleBackColor = false;
            this.SeeMenu.Click += new System.EventHandler(this.SeeMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(-2, -31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 78);
            this.panel1.TabIndex = 13;
            // 
            // adfmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(803, 559);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.week);
            this.Controls.Add(this.SeeMenu);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adfmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button week;
        private System.Windows.Forms.Button SeeMenu;
        private System.Windows.Forms.Panel panel1;
    }
}