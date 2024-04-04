namespace Metin_Doğrulama_Yedek5
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnirsaliye = new turkkeplogin.RJButton();
            this.btnfatura = new turkkeplogin.RJButton();
            this.btnara = new turkkeplogin.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Red;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-5, 21);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(692, 72);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(78, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 57);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(162, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÜRKKEP XML VERİ OKUMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(281, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // btnirsaliye
            // 
            this.btnirsaliye.BackColor = System.Drawing.Color.Red;
            this.btnirsaliye.FlatAppearance.BorderSize = 0;
            this.btnirsaliye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirsaliye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnirsaliye.ForeColor = System.Drawing.Color.White;
            this.btnirsaliye.Location = new System.Drawing.Point(360, 167);
            this.btnirsaliye.Margin = new System.Windows.Forms.Padding(2);
            this.btnirsaliye.Name = "btnirsaliye";
            this.btnirsaliye.Size = new System.Drawing.Size(86, 58);
            this.btnirsaliye.TabIndex = 16;
            this.btnirsaliye.Text = "İrsaliye";
            this.btnirsaliye.UseVisualStyleBackColor = false;
            this.btnirsaliye.Click += new System.EventHandler(this.btnirsaliye_Click_1);
            // 
            // btnfatura
            // 
            this.btnfatura.BackColor = System.Drawing.Color.Red;
            this.btnfatura.FlatAppearance.BorderSize = 0;
            this.btnfatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnfatura.ForeColor = System.Drawing.Color.White;
            this.btnfatura.Location = new System.Drawing.Point(239, 167);
            this.btnfatura.Margin = new System.Windows.Forms.Padding(2);
            this.btnfatura.Name = "btnfatura";
            this.btnfatura.Size = new System.Drawing.Size(86, 58);
            this.btnfatura.TabIndex = 15;
            this.btnfatura.Text = "Fatura";
            this.btnfatura.UseVisualStyleBackColor = false;
            this.btnfatura.Click += new System.EventHandler(this.btnfatura_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Red;
            this.btnara.FlatAppearance.BorderSize = 0;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnara.ForeColor = System.Drawing.Color.White;
            this.btnara.Location = new System.Drawing.Point(284, 266);
            this.btnara.Margin = new System.Windows.Forms.Padding(2);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(116, 58);
            this.btnara.TabIndex = 9;
            this.btnara.Text = "Dosya Yolu";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 410);
            this.Controls.Add(this.btnirsaliye);
            this.Controls.Add(this.btnfatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private turkkeplogin.RJButton btnara;
        private System.Windows.Forms.Label label4;
        private turkkeplogin.RJButton btnfatura;
        private turkkeplogin.RJButton btnirsaliye;
    }
}