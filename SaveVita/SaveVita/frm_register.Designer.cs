namespace SaveVita
{
    partial class frm_register
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
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_vorname = new System.Windows.Forms.TextBox();
            this.lbl_vname = new System.Windows.Forms.Label();
            this.dtp_gebdat = new System.Windows.Forms.DateTimePicker();
            this.lbl_nname = new System.Windows.Forms.Label();
            this.lbl_gebdat = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_nachname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.rb_f = new System.Windows.Forms.RadioButton();
            this.btn_loginfrm = new System.Windows.Forms.Button();
            this.gbx_register = new System.Windows.Forms.GroupBox();
            this.cbx_stayloggedr = new System.Windows.Forms.CheckBox();
            this.lbl_passwordconf = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_passwordconf = new System.Windows.Forms.TextBox();
            this.txt_passwordreg = new System.Windows.Forms.TextBox();
            this.gbx_login = new System.Windows.Forms.GroupBox();
            this.cbx_staylogged = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_passwordlog = new System.Windows.Forms.TextBox();
            this.txt_emaillog = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.num_weight = new System.Windows.Forms.NumericUpDown();
            this.num_height = new System.Windows.Forms.NumericUpDown();
            this.gbx_register.SuspendLayout();
            this.gbx_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_register.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Olive;
            this.btn_register.Location = new System.Drawing.Point(347, 596);
            this.btn_register.Margin = new System.Windows.Forms.Padding(6);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(249, 77);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Olive;
            this.btn_cancel.Location = new System.Drawing.Point(69, 596);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(231, 77);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_vorname
            // 
            this.txt_vorname.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vorname.Location = new System.Drawing.Point(299, 25);
            this.txt_vorname.Margin = new System.Windows.Forms.Padding(6);
            this.txt_vorname.Name = "txt_vorname";
            this.txt_vorname.Size = new System.Drawing.Size(335, 46);
            this.txt_vorname.TabIndex = 2;
            this.txt_vorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_vorname.TextChanged += new System.EventHandler(this.txt_vorname_TextChanged);
            // 
            // lbl_vname
            // 
            this.lbl_vname.AutoSize = true;
            this.lbl_vname.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vname.Location = new System.Drawing.Point(28, 34);
            this.lbl_vname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_vname.Name = "lbl_vname";
            this.lbl_vname.Size = new System.Drawing.Size(145, 31);
            this.lbl_vname.TabIndex = 3;
            this.lbl_vname.Text = "First name:";
            // 
            // dtp_gebdat
            // 
            this.dtp_gebdat.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_gebdat.Location = new System.Drawing.Point(297, 173);
            this.dtp_gebdat.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_gebdat.Name = "dtp_gebdat";
            this.dtp_gebdat.Size = new System.Drawing.Size(335, 46);
            this.dtp_gebdat.TabIndex = 5;
            this.dtp_gebdat.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_nname
            // 
            this.lbl_nname.AutoSize = true;
            this.lbl_nname.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nname.Location = new System.Drawing.Point(28, 82);
            this.lbl_nname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nname.Name = "lbl_nname";
            this.lbl_nname.Size = new System.Drawing.Size(169, 31);
            this.lbl_nname.TabIndex = 6;
            this.lbl_nname.Text = "Second name:";
            // 
            // lbl_gebdat
            // 
            this.lbl_gebdat.AutoSize = true;
            this.lbl_gebdat.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gebdat.Location = new System.Drawing.Point(28, 182);
            this.lbl_gebdat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gebdat.Name = "lbl_gebdat";
            this.lbl_gebdat.Size = new System.Drawing.Size(181, 31);
            this.lbl_gebdat.TabIndex = 8;
            this.lbl_gebdat.Text = "Date of Birth:";
            this.lbl_gebdat.Click += new System.EventHandler(this.lbl_gebdat_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(28, 235);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(94, 31);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "E-Mail:";
            // 
            // txt_nachname
            // 
            this.txt_nachname.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nachname.Location = new System.Drawing.Point(299, 79);
            this.txt_nachname.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nachname.Name = "txt_nachname";
            this.txt_nachname.Size = new System.Drawing.Size(335, 46);
            this.txt_nachname.TabIndex = 10;
            this.txt_nachname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_nachname.TextChanged += new System.EventHandler(this.txt_nachname_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(297, 232);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(335, 46);
            this.txt_email.TabIndex = 11;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(28, 131);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(90, 31);
            this.lbl_gender.TabIndex = 12;
            this.lbl_gender.Text = "Gender";
            // 
            // rb_m
            // 
            this.rb_m.AutoSize = true;
            this.rb_m.Checked = true;
            this.rb_m.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_m.Location = new System.Drawing.Point(329, 129);
            this.rb_m.Margin = new System.Windows.Forms.Padding(6);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(87, 35);
            this.rb_m.TabIndex = 13;
            this.rb_m.TabStop = true;
            this.rb_m.Text = "Male";
            this.rb_m.UseVisualStyleBackColor = true;
            this.rb_m.CheckedChanged += new System.EventHandler(this.rb_m_CheckedChanged);
            // 
            // rb_f
            // 
            this.rb_f.AutoSize = true;
            this.rb_f.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_f.Location = new System.Drawing.Point(509, 127);
            this.rb_f.Margin = new System.Windows.Forms.Padding(6);
            this.rb_f.Name = "rb_f";
            this.rb_f.Size = new System.Drawing.Size(111, 35);
            this.rb_f.TabIndex = 14;
            this.rb_f.Text = "Female";
            this.rb_f.UseVisualStyleBackColor = true;
            this.rb_f.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_loginfrm
            // 
            this.btn_loginfrm.Location = new System.Drawing.Point(136, 705);
            this.btn_loginfrm.Margin = new System.Windows.Forms.Padding(6);
            this.btn_loginfrm.Name = "btn_loginfrm";
            this.btn_loginfrm.Size = new System.Drawing.Size(365, 47);
            this.btn_loginfrm.TabIndex = 15;
            this.btn_loginfrm.Text = "already registered? Login";
            this.btn_loginfrm.UseVisualStyleBackColor = true;
            this.btn_loginfrm.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbx_register
            // 
            this.gbx_register.Controls.Add(this.num_height);
            this.gbx_register.Controls.Add(this.num_weight);
            this.gbx_register.Controls.Add(this.lbl_height);
            this.gbx_register.Controls.Add(this.lbl_weight);
            this.gbx_register.Controls.Add(this.cbx_stayloggedr);
            this.gbx_register.Controls.Add(this.lbl_passwordconf);
            this.gbx_register.Controls.Add(this.lbl_password);
            this.gbx_register.Controls.Add(this.txt_passwordconf);
            this.gbx_register.Controls.Add(this.txt_passwordreg);
            this.gbx_register.Controls.Add(this.btn_loginfrm);
            this.gbx_register.Controls.Add(this.rb_f);
            this.gbx_register.Controls.Add(this.rb_m);
            this.gbx_register.Controls.Add(this.lbl_gender);
            this.gbx_register.Controls.Add(this.txt_email);
            this.gbx_register.Controls.Add(this.txt_nachname);
            this.gbx_register.Controls.Add(this.lbl_email);
            this.gbx_register.Controls.Add(this.lbl_gebdat);
            this.gbx_register.Controls.Add(this.lbl_nname);
            this.gbx_register.Controls.Add(this.dtp_gebdat);
            this.gbx_register.Controls.Add(this.lbl_vname);
            this.gbx_register.Controls.Add(this.txt_vorname);
            this.gbx_register.Controls.Add(this.btn_cancel);
            this.gbx_register.Controls.Add(this.btn_register);
            this.gbx_register.Location = new System.Drawing.Point(22, 12);
            this.gbx_register.Name = "gbx_register";
            this.gbx_register.Size = new System.Drawing.Size(643, 761);
            this.gbx_register.TabIndex = 16;
            this.gbx_register.TabStop = false;
            this.gbx_register.Text = "Register";
            this.gbx_register.Enter += new System.EventHandler(this.gbx_register_Enter);
            // 
            // cbx_stayloggedr
            // 
            this.cbx_stayloggedr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_stayloggedr.AutoSize = true;
            this.cbx_stayloggedr.Location = new System.Drawing.Point(218, 546);
            this.cbx_stayloggedr.Name = "cbx_stayloggedr";
            this.cbx_stayloggedr.Size = new System.Drawing.Size(198, 35);
            this.cbx_stayloggedr.TabIndex = 20;
            this.cbx_stayloggedr.Text = "Stay logged in";
            this.cbx_stayloggedr.UseVisualStyleBackColor = true;
            // 
            // lbl_passwordconf
            // 
            this.lbl_passwordconf.AutoSize = true;
            this.lbl_passwordconf.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordconf.Location = new System.Drawing.Point(28, 357);
            this.lbl_passwordconf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_passwordconf.Name = "lbl_passwordconf";
            this.lbl_passwordconf.Size = new System.Drawing.Size(224, 31);
            this.lbl_passwordconf.TabIndex = 19;
            this.lbl_passwordconf.Text = "Confirm Password:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(28, 295);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(125, 31);
            this.lbl_password.TabIndex = 18;
            this.lbl_password.Text = "Password:";
            // 
            // txt_passwordconf
            // 
            this.txt_passwordconf.Location = new System.Drawing.Point(297, 354);
            this.txt_passwordconf.Name = "txt_passwordconf";
            this.txt_passwordconf.Size = new System.Drawing.Size(335, 46);
            this.txt_passwordconf.TabIndex = 17;
            this.txt_passwordconf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_passwordreg
            // 
            this.txt_passwordreg.Location = new System.Drawing.Point(297, 292);
            this.txt_passwordreg.Name = "txt_passwordreg";
            this.txt_passwordreg.Size = new System.Drawing.Size(335, 46);
            this.txt_passwordreg.TabIndex = 16;
            this.txt_passwordreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbx_login
            // 
            this.gbx_login.Controls.Add(this.cbx_staylogged);
            this.gbx_login.Controls.Add(this.btn_back);
            this.gbx_login.Controls.Add(this.txt_passwordlog);
            this.gbx_login.Controls.Add(this.txt_emaillog);
            this.gbx_login.Controls.Add(this.btn_login);
            this.gbx_login.Location = new System.Drawing.Point(22, 12);
            this.gbx_login.Name = "gbx_login";
            this.gbx_login.Size = new System.Drawing.Size(643, 587);
            this.gbx_login.TabIndex = 17;
            this.gbx_login.TabStop = false;
            this.gbx_login.Text = "Login";
            this.gbx_login.Enter += new System.EventHandler(this.gbx_login_Enter);
            // 
            // cbx_staylogged
            // 
            this.cbx_staylogged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_staylogged.AutoSize = true;
            this.cbx_staylogged.Location = new System.Drawing.Point(200, 348);
            this.cbx_staylogged.Name = "cbx_staylogged";
            this.cbx_staylogged.Size = new System.Drawing.Size(198, 35);
            this.cbx_staylogged.TabIndex = 4;
            this.cbx_staylogged.Text = "Stay logged in";
            this.cbx_staylogged.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_back.Location = new System.Drawing.Point(94, 391);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(206, 69);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_passwordlog
            // 
            this.txt_passwordlog.Location = new System.Drawing.Point(136, 285);
            this.txt_passwordlog.Name = "txt_passwordlog";
            this.txt_passwordlog.Size = new System.Drawing.Size(359, 46);
            this.txt_passwordlog.TabIndex = 2;
            this.txt_passwordlog.Text = "Password";
            this.txt_passwordlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_emaillog
            // 
            this.txt_emaillog.Location = new System.Drawing.Point(136, 216);
            this.txt_emaillog.Name = "txt_emaillog";
            this.txt_emaillog.Size = new System.Drawing.Size(359, 46);
            this.txt_emaillog.TabIndex = 1;
            this.txt_emaillog.Text = "E-Mail";
            this.txt_emaillog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_login.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_login.Location = new System.Drawing.Point(329, 391);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(206, 69);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.Location = new System.Drawing.Point(28, 412);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(125, 39);
            this.lbl_weight.TabIndex = 22;
            this.lbl_weight.Text = "Weight:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(28, 478);
            this.lbl_height.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(95, 31);
            this.lbl_height.TabIndex = 24;
            this.lbl_height.Text = "Height:";
            // 
            // num_weight
            // 
            this.num_weight.DecimalPlaces = 1;
            this.num_weight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_weight.Location = new System.Drawing.Point(297, 414);
            this.num_weight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_weight.Name = "num_weight";
            this.num_weight.Size = new System.Drawing.Size(335, 46);
            this.num_weight.TabIndex = 25;
            this.num_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_height
            // 
            this.num_height.Location = new System.Drawing.Point(297, 478);
            this.num_height.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_height.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.num_height.Name = "num_height";
            this.num_height.Size = new System.Drawing.Size(335, 46);
            this.num_height.TabIndex = 26;
            this.num_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_height.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 785);
            this.Controls.Add(this.gbx_register);
            this.Controls.Add(this.gbx_login);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_register";
            this.Text = "frm_register";
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.gbx_register.ResumeLayout(false);
            this.gbx_register.PerformLayout();
            this.gbx_login.ResumeLayout(false);
            this.gbx_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_vorname;
        private System.Windows.Forms.Label lbl_vname;
        private System.Windows.Forms.DateTimePicker dtp_gebdat;
        private System.Windows.Forms.Label lbl_nname;
        private System.Windows.Forms.Label lbl_gebdat;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nachname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.RadioButton rb_m;
        private System.Windows.Forms.RadioButton rb_f;
        private System.Windows.Forms.Button btn_loginfrm;
        private System.Windows.Forms.GroupBox gbx_register;
        private System.Windows.Forms.GroupBox gbx_login;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_passwordlog;
        private System.Windows.Forms.TextBox txt_emaillog;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_passwordconf;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_passwordconf;
        private System.Windows.Forms.TextBox txt_passwordreg;
        private System.Windows.Forms.CheckBox cbx_staylogged;
        private System.Windows.Forms.CheckBox cbx_stayloggedr;
        private System.Windows.Forms.NumericUpDown num_height;
        private System.Windows.Forms.NumericUpDown num_weight;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_weight;
    }
}