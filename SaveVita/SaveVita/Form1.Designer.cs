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
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_mahlzeit = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.gbx_profile = new System.Windows.Forms.GroupBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pbx_pp = new System.Windows.Forms.PictureBox();
            this.lbl_weightt = new System.Windows.Forms.Label();
            this.lbl_heightt = new System.Windows.Forms.Label();
            this.lbl_aget = new System.Windows.Forms.Label();
            this.lbl_namet = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btn_anywhere = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx_new = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_carbonhydrate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_kj = new System.Windows.Forms.NumericUpDown();
            this.lbl_foodt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_confirmfood = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbx_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_new.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kj)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            this.btn_profil.Text = "Show profile";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Visible = false;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
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
            this.btn_mahlzeit.Text = "Register meal";
            this.btn_mahlzeit.UseVisualStyleBackColor = true;
            this.btn_mahlzeit.Visible = false;
            this.btn_mahlzeit.Click += new System.EventHandler(this.btn_mahlzeit_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_menu.Font = new System.Drawing.Font("Papyrus", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_menu.Location = new System.Drawing.Point(0, 736);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(961, 155);
            this.btn_menu.TabIndex = 6;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Visible = false;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbx_profile
            // 
            this.gbx_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_profile.Controls.Add(this.lbl_weight);
            this.gbx_profile.Controls.Add(this.lbl_height);
            this.gbx_profile.Controls.Add(this.lbl_age);
            this.gbx_profile.Controls.Add(this.lbl_name);
            this.gbx_profile.Controls.Add(this.pbx_pp);
            this.gbx_profile.Controls.Add(this.lbl_weightt);
            this.gbx_profile.Controls.Add(this.lbl_heightt);
            this.gbx_profile.Controls.Add(this.lbl_aget);
            this.gbx_profile.Controls.Add(this.lbl_namet);
            this.gbx_profile.Location = new System.Drawing.Point(0, 0);
            this.gbx_profile.Name = "gbx_profile";
            this.gbx_profile.Size = new System.Drawing.Size(961, 891);
            this.gbx_profile.TabIndex = 7;
            this.gbx_profile.TabStop = false;
            this.gbx_profile.Text = "Profile information";
            this.gbx_profile.Visible = false;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(494, 465);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(50, 51);
            this.lbl_weight.TabIndex = 8;
            this.lbl_weight.Text = "....";
            this.lbl_weight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(494, 338);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(50, 51);
            this.lbl_height.TabIndex = 7;
            this.lbl_height.Text = "....";
            this.lbl_height.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(494, 213);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(50, 51);
            this.lbl_age.TabIndex = 6;
            this.lbl_age.Text = "....";
            this.lbl_age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(494, 95);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 51);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "....";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbx_pp
            // 
            this.pbx_pp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_pp.Image = global::SaveVita.Properties.Resources.umriss_mann;
            this.pbx_pp.Location = new System.Drawing.Point(455, 38);
            this.pbx_pp.Name = "pbx_pp";
            this.pbx_pp.Size = new System.Drawing.Size(479, 285);
            this.pbx_pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_pp.TabIndex = 4;
            this.pbx_pp.TabStop = false;
            // 
            // lbl_weightt
            // 
            this.lbl_weightt.AutoSize = true;
            this.lbl_weightt.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weightt.Location = new System.Drawing.Point(79, 465);
            this.lbl_weightt.Name = "lbl_weightt";
            this.lbl_weightt.Size = new System.Drawing.Size(118, 51);
            this.lbl_weightt.TabIndex = 3;
            this.lbl_weightt.Text = "weight:";
            // 
            // lbl_heightt
            // 
            this.lbl_heightt.AutoSize = true;
            this.lbl_heightt.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heightt.Location = new System.Drawing.Point(79, 338);
            this.lbl_heightt.Name = "lbl_heightt";
            this.lbl_heightt.Size = new System.Drawing.Size(115, 51);
            this.lbl_heightt.TabIndex = 2;
            this.lbl_heightt.Text = "height:";
            this.lbl_heightt.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_aget
            // 
            this.lbl_aget.AutoSize = true;
            this.lbl_aget.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aget.Location = new System.Drawing.Point(79, 213);
            this.lbl_aget.Name = "lbl_aget";
            this.lbl_aget.Size = new System.Drawing.Size(77, 51);
            this.lbl_aget.TabIndex = 1;
            this.lbl_aget.Text = "age:";
            // 
            // lbl_namet
            // 
            this.lbl_namet.AutoSize = true;
            this.lbl_namet.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namet.Location = new System.Drawing.Point(79, 95);
            this.lbl_namet.Name = "lbl_namet";
            this.lbl_namet.Size = new System.Drawing.Size(98, 51);
            this.lbl_namet.TabIndex = 0;
            this.lbl_namet.Text = "name:";
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
            // gbx_new
            // 
            this.gbx_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_new.Controls.Add(this.btn_cancel);
            this.gbx_new.Controls.Add(this.btn_confirmfood);
            this.gbx_new.Controls.Add(this.numericUpDown1);
            this.gbx_new.Controls.Add(this.lbl_carbonhydrate);
            this.gbx_new.Controls.Add(this.label1);
            this.gbx_new.Controls.Add(this.num_kj);
            this.gbx_new.Controls.Add(this.lbl_foodt);
            this.gbx_new.Controls.Add(this.textBox1);
            this.gbx_new.Location = new System.Drawing.Point(310, 1);
            this.gbx_new.Name = "gbx_new";
            this.gbx_new.Size = new System.Drawing.Size(388, 819);
            this.gbx_new.TabIndex = 10;
            this.gbx_new.TabStop = false;
            this.gbx_new.Text = "New Meal";
            this.gbx_new.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(163, 272);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(169, 58);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lbl_carbonhydrate
            // 
            this.lbl_carbonhydrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_carbonhydrate.AutoSize = true;
            this.lbl_carbonhydrate.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carbonhydrate.Location = new System.Drawing.Point(53, 279);
            this.lbl_carbonhydrate.Name = "lbl_carbonhydrate";
            this.lbl_carbonhydrate.Size = new System.Drawing.Size(226, 51);
            this.lbl_carbonhydrate.TabIndex = 4;
            this.lbl_carbonhydrate.Text = "carbohydrates:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "kj:";
            // 
            // num_kj
            // 
            this.num_kj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_kj.DecimalPlaces = 2;
            this.num_kj.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_kj.Location = new System.Drawing.Point(163, 184);
            this.num_kj.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_kj.Name = "num_kj";
            this.num_kj.Size = new System.Drawing.Size(169, 58);
            this.num_kj.TabIndex = 2;
            // 
            // lbl_foodt
            // 
            this.lbl_foodt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_foodt.AutoSize = true;
            this.lbl_foodt.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foodt.Location = new System.Drawing.Point(53, 104);
            this.lbl_foodt.Name = "lbl_foodt";
            this.lbl_foodt.Size = new System.Drawing.Size(97, 51);
            this.lbl_foodt.TabIndex = 1;
            this.lbl_foodt.Text = "food:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 58);
            this.textBox1.TabIndex = 0;
            // 
            // btn_confirmfood
            // 
            this.btn_confirmfood.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirmfood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_confirmfood.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmfood.Location = new System.Drawing.Point(3, 748);
            this.btn_confirmfood.Name = "btn_confirmfood";
            this.btn_confirmfood.Size = new System.Drawing.Size(382, 68);
            this.btn_confirmfood.TabIndex = 6;
            this.btn_confirmfood.Text = "Confirm";
            this.btn_confirmfood.UseVisualStyleBackColor = true;
            this.btn_confirmfood.Click += new System.EventHandler(this.btn_confirmfood_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cancel.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(3, 680);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(382, 68);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 891);
            this.Controls.Add(this.gbx_new);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.gbx_profile);
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
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveVita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_profile.ResumeLayout(false);
            this.gbx_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_new.ResumeLayout(false);
            this.gbx_new.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kj)).EndInit();
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
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.GroupBox gbx_profile;
        private System.Windows.Forms.PictureBox pbx_pp;
        private System.Windows.Forms.Label lbl_weightt;
        private System.Windows.Forms.Label lbl_heightt;
        private System.Windows.Forms.Label lbl_aget;
        private System.Windows.Forms.Label lbl_namet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox gbx_new;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_carbonhydrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_kj;
        private System.Windows.Forms.Label lbl_foodt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirmfood;
    }
}

