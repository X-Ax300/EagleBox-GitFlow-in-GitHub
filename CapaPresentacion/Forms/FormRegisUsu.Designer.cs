namespace CapaPresentacion.Forms
{
    partial class FormRegisUsu
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.Passwordclient_Register_TBox = new ZBobb.AlphaBlendTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Nameclient_Register_TBox = new ZBobb.AlphaBlendTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IDclient_Register_TBox = new ZBobb.AlphaBlendTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mailclient_Register_TBox = new ZBobb.AlphaBlendTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Surnameclient_Register_TBox = new ZBobb.AlphaBlendTextBox();
            this.Fondo_Register_Panel = new System.Windows.Forms.Panel();
            this.Back_button_register = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Register_button_acceptar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox_Passoword = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_Gmail = new FontAwesome.Sharp.IconPictureBox();
            this.labelverificarmail = new System.Windows.Forms.Label();
            this.Fondo_Register_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Passoword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Gmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(13, 594);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 3);
            this.panel5.TabIndex = 21;
            // 
            // Passwordclient_Register_TBox
            // 
            this.Passwordclient_Register_TBox.BackAlpha = 0;
            this.Passwordclient_Register_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Passwordclient_Register_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordclient_Register_TBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordclient_Register_TBox.ForeColor = System.Drawing.Color.White;
            this.Passwordclient_Register_TBox.Location = new System.Drawing.Point(47, 550);
            this.Passwordclient_Register_TBox.Multiline = true;
            this.Passwordclient_Register_TBox.Name = "Passwordclient_Register_TBox";
            this.Passwordclient_Register_TBox.Size = new System.Drawing.Size(351, 47);
            this.Passwordclient_Register_TBox.TabIndex = 20;
            this.Passwordclient_Register_TBox.Text = "Password";
            this.Passwordclient_Register_TBox.TextChanged += new System.EventHandler(this.Passwordclient_Register_TBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(13, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 3);
            this.panel3.TabIndex = 18;
            // 
            // Nameclient_Register_TBox
            // 
            this.Nameclient_Register_TBox.BackAlpha = 0;
            this.Nameclient_Register_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Nameclient_Register_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nameclient_Register_TBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nameclient_Register_TBox.ForeColor = System.Drawing.Color.White;
            this.Nameclient_Register_TBox.Location = new System.Drawing.Point(47, 325);
            this.Nameclient_Register_TBox.Multiline = true;
            this.Nameclient_Register_TBox.Name = "Nameclient_Register_TBox";
            this.Nameclient_Register_TBox.Size = new System.Drawing.Size(351, 47);
            this.Nameclient_Register_TBox.TabIndex = 17;
            this.Nameclient_Register_TBox.Text = "Nombre";
            this.Nameclient_Register_TBox.TextChanged += new System.EventHandler(this.Nameclient_Register_TBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(13, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 3);
            this.panel4.TabIndex = 15;
            // 
            // IDclient_Register_TBox
            // 
            this.IDclient_Register_TBox.BackAlpha = 0;
            this.IDclient_Register_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IDclient_Register_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDclient_Register_TBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDclient_Register_TBox.ForeColor = System.Drawing.Color.White;
            this.IDclient_Register_TBox.Location = new System.Drawing.Point(47, 240);
            this.IDclient_Register_TBox.Multiline = true;
            this.IDclient_Register_TBox.Name = "IDclient_Register_TBox";
            this.IDclient_Register_TBox.Size = new System.Drawing.Size(351, 47);
            this.IDclient_Register_TBox.TabIndex = 14;
            this.IDclient_Register_TBox.Text = "IDclient";
            this.IDclient_Register_TBox.TextChanged += new System.EventHandler(this.IDclient_Register_TBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(130, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrarse";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 3);
            this.panel2.TabIndex = 5;
            // 
            // Mailclient_Register_TBox
            // 
            this.Mailclient_Register_TBox.BackAlpha = 0;
            this.Mailclient_Register_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Mailclient_Register_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mailclient_Register_TBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mailclient_Register_TBox.ForeColor = System.Drawing.Color.White;
            this.Mailclient_Register_TBox.Location = new System.Drawing.Point(47, 478);
            this.Mailclient_Register_TBox.Multiline = true;
            this.Mailclient_Register_TBox.Name = "Mailclient_Register_TBox";
            this.Mailclient_Register_TBox.Size = new System.Drawing.Size(351, 47);
            this.Mailclient_Register_TBox.TabIndex = 4;
            this.Mailclient_Register_TBox.Text = "Mail";
            this.Mailclient_Register_TBox.TextChanged += new System.EventHandler(this.Mailclient_Register_TBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 3);
            this.panel1.TabIndex = 1;
            // 
            // Surnameclient_Register_TBox
            // 
            this.Surnameclient_Register_TBox.BackAlpha = 0;
            this.Surnameclient_Register_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Surnameclient_Register_TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surnameclient_Register_TBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surnameclient_Register_TBox.ForeColor = System.Drawing.Color.White;
            this.Surnameclient_Register_TBox.Location = new System.Drawing.Point(47, 393);
            this.Surnameclient_Register_TBox.Multiline = true;
            this.Surnameclient_Register_TBox.Name = "Surnameclient_Register_TBox";
            this.Surnameclient_Register_TBox.Size = new System.Drawing.Size(351, 47);
            this.Surnameclient_Register_TBox.TabIndex = 0;
            this.Surnameclient_Register_TBox.Text = "Apellido";
            this.Surnameclient_Register_TBox.TextChanged += new System.EventHandler(this.Surnameclient_Register_TBox_TextChanged);
            // 
            // Fondo_Register_Panel
            // 
            this.Fondo_Register_Panel.Controls.Add(this.labelverificarmail);
            this.Fondo_Register_Panel.Controls.Add(this.Back_button_register);
            this.Fondo_Register_Panel.Controls.Add(this.iconPictureBox3);
            this.Fondo_Register_Panel.Controls.Add(this.panel5);
            this.Fondo_Register_Panel.Controls.Add(this.Passwordclient_Register_TBox);
            this.Fondo_Register_Panel.Controls.Add(this.iconPictureBox1);
            this.Fondo_Register_Panel.Controls.Add(this.panel3);
            this.Fondo_Register_Panel.Controls.Add(this.Nameclient_Register_TBox);
            this.Fondo_Register_Panel.Controls.Add(this.iconPictureBox2);
            this.Fondo_Register_Panel.Controls.Add(this.panel4);
            this.Fondo_Register_Panel.Controls.Add(this.IDclient_Register_TBox);
            this.Fondo_Register_Panel.Controls.Add(this.Register_button_acceptar);
            this.Fondo_Register_Panel.Controls.Add(this.label1);
            this.Fondo_Register_Panel.Controls.Add(this.iconPictureBox_Passoword);
            this.Fondo_Register_Panel.Controls.Add(this.panel2);
            this.Fondo_Register_Panel.Controls.Add(this.Mailclient_Register_TBox);
            this.Fondo_Register_Panel.Controls.Add(this.iconPictureBox_Gmail);
            this.Fondo_Register_Panel.Controls.Add(this.panel1);
            this.Fondo_Register_Panel.Controls.Add(this.Surnameclient_Register_TBox);
            this.Fondo_Register_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo_Register_Panel.Location = new System.Drawing.Point(0, 0);
            this.Fondo_Register_Panel.Name = "Fondo_Register_Panel";
            this.Fondo_Register_Panel.Size = new System.Drawing.Size(425, 765);
            this.Fondo_Register_Panel.TabIndex = 2;
            this.Fondo_Register_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Fondo_Register_Panel_Paint);
            // 
            // Back_button_register
            // 
            this.Back_button_register.BackColor = System.Drawing.Color.Transparent;
            this.Back_button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button_register.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.Back_button_register.IconColor = System.Drawing.Color.Black;
            this.Back_button_register.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Back_button_register.Location = new System.Drawing.Point(13, 12);
            this.Back_button_register.Name = "Back_button_register";
            this.Back_button_register.Size = new System.Drawing.Size(66, 43);
            this.Back_button_register.TabIndex = 23;
            this.Back_button_register.UseVisualStyleBackColor = false;
            this.Back_button_register.Click += new System.EventHandler(this.Back_button_register_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(12, 478);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 22;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 331);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(13, 246);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 16;
            this.iconPictureBox2.TabStop = false;
            // 
            // Register_button_acceptar
            // 
            this.Register_button_acceptar.BackColor = System.Drawing.Color.Transparent;
            this.Register_button_acceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_button_acceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_button_acceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button_acceptar.ForeColor = System.Drawing.Color.Black;
            this.Register_button_acceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Register_button_acceptar.IconColor = System.Drawing.Color.Black;
            this.Register_button_acceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Register_button_acceptar.Location = new System.Drawing.Point(148, 683);
            this.Register_button_acceptar.Name = "Register_button_acceptar";
            this.Register_button_acceptar.Size = new System.Drawing.Size(111, 35);
            this.Register_button_acceptar.TabIndex = 13;
            this.Register_button_acceptar.Text = "REGISTER";
            this.Register_button_acceptar.UseVisualStyleBackColor = false;
            this.Register_button_acceptar.Click += new System.EventHandler(this.Register_button_acceptar_Click);
            // 
            // iconPictureBox_Passoword
            // 
            this.iconPictureBox_Passoword.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Passoword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_Passoword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox_Passoword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_Passoword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Passoword.Location = new System.Drawing.Point(9, 550);
            this.iconPictureBox_Passoword.Name = "iconPictureBox_Passoword";
            this.iconPictureBox_Passoword.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Passoword.TabIndex = 6;
            this.iconPictureBox_Passoword.TabStop = false;
            // 
            // iconPictureBox_Gmail
            // 
            this.iconPictureBox_Gmail.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Gmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_Gmail.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox_Gmail.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox_Gmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Gmail.Location = new System.Drawing.Point(13, 399);
            this.iconPictureBox_Gmail.Name = "iconPictureBox_Gmail";
            this.iconPictureBox_Gmail.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Gmail.TabIndex = 3;
            this.iconPictureBox_Gmail.TabStop = false;
            // 
            // labelverificarmail
            // 
            this.labelverificarmail.AutoSize = true;
            this.labelverificarmail.BackColor = System.Drawing.Color.Transparent;
            this.labelverificarmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelverificarmail.Location = new System.Drawing.Point(12, 619);
            this.labelverificarmail.Name = "labelverificarmail";
            this.labelverificarmail.Size = new System.Drawing.Size(12, 18);
            this.labelverificarmail.TabIndex = 24;
            this.labelverificarmail.Text = ".";
            // 
            // FormRegisUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 765);
            this.Controls.Add(this.Fondo_Register_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisUsu";
            this.Text = "FormRegisUsu";
            this.Fondo_Register_Panel.ResumeLayout(false);
            this.Fondo_Register_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Passoword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Gmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private FontAwesome.Sharp.IconButton Back_button_register;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel5;
        private ZBobb.AlphaBlendTextBox Passwordclient_Register_TBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private ZBobb.AlphaBlendTextBox Nameclient_Register_TBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel4;
        private ZBobb.AlphaBlendTextBox IDclient_Register_TBox;
        private FontAwesome.Sharp.IconButton Register_button_acceptar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Passoword;
        private System.Windows.Forms.Panel panel2;
        private ZBobb.AlphaBlendTextBox Mailclient_Register_TBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Gmail;
        private System.Windows.Forms.Panel panel1;
        private ZBobb.AlphaBlendTextBox Surnameclient_Register_TBox;
        private System.Windows.Forms.Panel Fondo_Register_Panel;
        private System.Windows.Forms.Label labelverificarmail;
    }
}