namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nev = new System.Windows.Forms.TextBox();
            this.ujHobbi = new System.Windows.Forms.TextBox();
            this.szulDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hozzaad = new System.Windows.Forms.Button();
            this.Mentes = new System.Windows.Forms.Button();
            this.Betoltes = new System.Windows.Forms.Button();
            this.Hobbik = new System.Windows.Forms.ListBox();
            this.fiu = new System.Windows.Forms.RadioButton();
            this.lany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(126, 22);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 22);
            this.nev.TabIndex = 0;
            // 
            // ujHobbi
            // 
            this.ujHobbi.Location = new System.Drawing.Point(281, 165);
            this.ujHobbi.Name = "ujHobbi";
            this.ujHobbi.Size = new System.Drawing.Size(120, 22);
            this.ujHobbi.TabIndex = 1;
            // 
            // szulDate
            // 
            this.szulDate.Location = new System.Drawing.Point(126, 68);
            this.szulDate.Name = "szulDate";
            this.szulDate.Size = new System.Drawing.Size(100, 22);
            this.szulDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kedvenc hobbi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Szül. dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "új hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nem:";
            // 
            // Hozzaad
            // 
            this.Hozzaad.BackColor = System.Drawing.Color.DarkBlue;
            this.Hozzaad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hozzaad.Location = new System.Drawing.Point(281, 193);
            this.Hozzaad.Name = "Hozzaad";
            this.Hozzaad.Size = new System.Drawing.Size(120, 36);
            this.Hozzaad.TabIndex = 8;
            this.Hozzaad.Text = "Hozzáad";
            this.Hozzaad.UseVisualStyleBackColor = false;
            this.Hozzaad.Click += new System.EventHandler(this.Hozzaad_Click);
            // 
            // Mentes
            // 
            this.Mentes.BackColor = System.Drawing.Color.DarkGreen;
            this.Mentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mentes.Location = new System.Drawing.Point(12, 165);
            this.Mentes.Name = "Mentes";
            this.Mentes.Size = new System.Drawing.Size(95, 35);
            this.Mentes.TabIndex = 9;
            this.Mentes.Text = "Mentés";
            this.Mentes.UseVisualStyleBackColor = false;
            this.Mentes.Click += new System.EventHandler(this.Mentes_Click);
            // 
            // Betoltes
            // 
            this.Betoltes.BackColor = System.Drawing.Color.DarkOrchid;
            this.Betoltes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Betoltes.Location = new System.Drawing.Point(142, 165);
            this.Betoltes.Name = "Betoltes";
            this.Betoltes.Size = new System.Drawing.Size(93, 35);
            this.Betoltes.TabIndex = 10;
            this.Betoltes.Text = "Betöltés";
            this.Betoltes.UseVisualStyleBackColor = false;
            this.Betoltes.Click += new System.EventHandler(this.Betoltes_Click);
            // 
            // Hobbik
            // 
            this.Hobbik.FormattingEnabled = true;
            this.Hobbik.ItemHeight = 16;
            this.Hobbik.Location = new System.Drawing.Point(281, 42);
            this.Hobbik.Name = "Hobbik";
            this.Hobbik.Size = new System.Drawing.Size(120, 84);
            this.Hobbik.TabIndex = 11;
            // 
            // fiu
            // 
            this.fiu.AutoSize = true;
            this.fiu.Location = new System.Drawing.Point(126, 123);
            this.fiu.Name = "fiu";
            this.fiu.Size = new System.Drawing.Size(37, 21);
            this.fiu.TabIndex = 12;
            this.fiu.TabStop = true;
            this.fiu.Text = "F";
            this.fiu.UseVisualStyleBackColor = true;
            // 
            // lany
            // 
            this.lany.AutoSize = true;
            this.lany.Location = new System.Drawing.Point(187, 123);
            this.lany.Name = "lany";
            this.lany.Size = new System.Drawing.Size(39, 21);
            this.lany.TabIndex = 13;
            this.lany.TabStop = true;
            this.lany.Text = "N";
            this.lany.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(415, 290);
            this.Controls.Add(this.lany);
            this.Controls.Add(this.fiu);
            this.Controls.Add(this.Hobbik);
            this.Controls.Add(this.Betoltes);
            this.Controls.Add(this.Mentes);
            this.Controls.Add(this.Hozzaad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szulDate);
            this.Controls.Add(this.ujHobbi);
            this.Controls.Add(this.nev);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisztrációs Alkalmazás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox ujHobbi;
        private System.Windows.Forms.TextBox szulDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Hozzaad;
        private System.Windows.Forms.Button Mentes;
        private System.Windows.Forms.Button Betoltes;
        private System.Windows.Forms.ListBox Hobbik;
        private System.Windows.Forms.RadioButton fiu;
        private System.Windows.Forms.RadioButton lany;
    }
}

