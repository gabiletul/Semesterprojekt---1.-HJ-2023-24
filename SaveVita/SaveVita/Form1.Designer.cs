namespace SaveVita
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_anywhere = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_mahlzeit = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SaveVita.Properties.Resources.load;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 891);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_anywhere
            // 
            this.btn_anywhere.AutoSize = true;
            this.btn_anywhere.BackColor = System.Drawing.Color.Transparent;
            this.btn_anywhere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_anywhere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_anywhere.Image = global::SaveVita.Properties.Resources.Continue_gif;
            this.btn_anywhere.Location = new System.Drawing.Point(0, 0);
            this.btn_anywhere.Name = "btn_anywhere";
            this.btn_anywhere.Size = new System.Drawing.Size(961, 891);
            this.btn_anywhere.TabIndex = 2;
            this.btn_anywhere.UseVisualStyleBackColor = false;
            this.btn_anywhere.Visible = false;
            this.btn_anywhere.Click += new System.EventHandler(this.btn_anywhere_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profil.Font = new System.Drawing.Font("Papyrus", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_profil.Location = new System.Drawing.Point(0, 0);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(961, 155);
            this.btn_profil.TabIndex = 3;
            this.btn_profil.Text = "Profil anzeigen";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Visible = false;
            // 
            // btn_mahlzeit
            // 
            this.btn_mahlzeit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mahlzeit.Font = new System.Drawing.Font("Papyrus", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mahlzeit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_mahlzeit.Location = new System.Drawing.Point(0, 155);
            this.btn_mahlzeit.Name = "btn_mahlzeit";
            this.btn_mahlzeit.Size = new System.Drawing.Size(961, 155);
            this.btn_mahlzeit.TabIndex = 4;
            this.btn_mahlzeit.Text = "Mahlzeit eintragen";
            this.btn_mahlzeit.UseVisualStyleBackColor = true;
            this.btn_mahlzeit.Visible = false;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_logo.Image = global::SaveVita.Properties.Resources.SaveVita_Logo;
            this.pbx_logo.Location = new System.Drawing.Point(722, 735);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(239, 130);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 5;
            this.pbx_logo.TabStop = false;
            this.pbx_logo.Visible = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 891);
            this.Controls.Add(this.pbx_logo);
            this.Controls.Add(this.btn_mahlzeit);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_anywhere);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveVita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_anywhere;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_mahlzeit;
        private System.Windows.Forms.PictureBox pbx_logo;
    }
}

