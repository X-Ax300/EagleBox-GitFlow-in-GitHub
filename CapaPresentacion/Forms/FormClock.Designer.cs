namespace CapaPresentacion.Forms
{
    partial class FormClock
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.LBL_fecha = new System.Windows.Forms.Label();
            this.Lbl_Hour = new System.Windows.Forms.Label();
            this.hourdate = new System.Windows.Forms.Timer(this.components);
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.LBL_fecha);
            this.panelBackground.Controls.Add(this.Lbl_Hour);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1034, 673);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // LBL_fecha
            // 
            this.LBL_fecha.AutoSize = true;
            this.LBL_fecha.BackColor = System.Drawing.Color.Transparent;
            this.LBL_fecha.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_fecha.ForeColor = System.Drawing.Color.White;
            this.LBL_fecha.Location = new System.Drawing.Point(291, 305);
            this.LBL_fecha.Name = "LBL_fecha";
            this.LBL_fecha.Size = new System.Drawing.Size(130, 41);
            this.LBL_fecha.TabIndex = 1;
            this.LBL_fecha.Text = "FECHA";
            this.LBL_fecha.Click += new System.EventHandler(this.LBL_fecha_Click);
            // 
            // Lbl_Hour
            // 
            this.Lbl_Hour.AutoSize = true;
            this.Lbl_Hour.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Hour.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hour.ForeColor = System.Drawing.Color.White;
            this.Lbl_Hour.Location = new System.Drawing.Point(268, 193);
            this.Lbl_Hour.Name = "Lbl_Hour";
            this.Lbl_Hour.Size = new System.Drawing.Size(320, 112);
            this.Lbl_Hour.TabIndex = 0;
            this.Lbl_Hour.Text = "HORA";
            this.Lbl_Hour.Click += new System.EventHandler(this.Lbl_Hour_Click);
            // 
            // hourdate
            // 
            this.hourdate.Enabled = true;
            this.hourdate.Tick += new System.EventHandler(this.hourdate_Tick);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 673);
            this.Controls.Add(this.panelBackground);
            this.Name = "FormClock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label Lbl_Hour;
        private System.Windows.Forms.Label LBL_fecha;
        private System.Windows.Forms.Timer hourdate;
    }
}