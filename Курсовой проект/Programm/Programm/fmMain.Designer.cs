namespace Programm
{
    partial class fmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeeMenu1 = new System.Windows.Forms.Button();
            this.week1 = new System.Windows.Forms.Button();
            this.Ref = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 78);
            this.panel1.TabIndex = 8;
            // 
            // SeeMenu1
            // 
            this.SeeMenu1.BackColor = System.Drawing.Color.Lime;
            this.SeeMenu1.FlatAppearance.BorderSize = 0;
            this.SeeMenu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.SeeMenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.SeeMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeMenu1.Location = new System.Drawing.Point(193, 108);
            this.SeeMenu1.Name = "SeeMenu1";
            this.SeeMenu1.Size = new System.Drawing.Size(398, 74);
            this.SeeMenu1.TabIndex = 9;
            this.SeeMenu1.Text = "Просмотр меню";
            this.SeeMenu1.UseVisualStyleBackColor = false;
            this.SeeMenu1.Click += new System.EventHandler(this.SeeMenu1_Click);
            // 
            // week1
            // 
            this.week1.BackColor = System.Drawing.Color.Lime;
            this.week1.FlatAppearance.BorderSize = 0;
            this.week1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.week1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.week1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.week1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.week1.Location = new System.Drawing.Point(194, 217);
            this.week1.Name = "week1";
            this.week1.Size = new System.Drawing.Size(398, 74);
            this.week1.TabIndex = 10;
            this.week1.Text = "Выбор блюд";
            this.week1.UseVisualStyleBackColor = false;
            this.week1.Click += new System.EventHandler(this.week1_Click);
            // 
            // Ref
            // 
            this.Ref.BackColor = System.Drawing.Color.Lime;
            this.Ref.FlatAppearance.BorderSize = 0;
            this.Ref.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Ref.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ref.Location = new System.Drawing.Point(194, 331);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(398, 74);
            this.Ref.TabIndex = 11;
            this.Ref.Text = "Справка";
            this.Ref.UseVisualStyleBackColor = false;
            this.Ref.Click += new System.EventHandler(this.Ref_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Lime;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(194, 438);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(398, 74);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(803, 559);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.week1);
            this.Controls.Add(this.SeeMenu1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель клиента";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SeeMenu1;
        private System.Windows.Forms.Button week1;
        private System.Windows.Forms.Button Ref;
        private System.Windows.Forms.Button Exit;
    }
}