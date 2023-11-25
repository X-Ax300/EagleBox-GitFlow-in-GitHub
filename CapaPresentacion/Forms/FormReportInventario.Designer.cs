namespace CapaPresentacion.Forms
{
    partial class FormReportInventario
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_reports_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title_fisrt = new System.Windows.Forms.Label();
            this.Stock_count_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label_Count_low = new System.Windows.Forms.Label();
            this.Title_low_stock = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Label_count_high = new System.Windows.Forms.Label();
            this.Title_High_stock = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Title_tabla = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Title_reports_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 100);
            this.panel1.TabIndex = 0;
            // 
            // Title_reports_label
            // 
            this.Title_reports_label.AutoSize = true;
            this.Title_reports_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title_reports_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_reports_label.Location = new System.Drawing.Point(437, 21);
            this.Title_reports_label.Name = "Title_reports_label";
            this.Title_reports_label.Size = new System.Drawing.Size(230, 25);
            this.Title_reports_label.TabIndex = 0;
            this.Title_reports_label.Text = "Reporte de inventario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.Stock_count_label);
            this.panel2.Controls.Add(this.Title_fisrt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 90);
            this.panel2.TabIndex = 0;
            // 
            // Title_fisrt
            // 
            this.Title_fisrt.AutoSize = true;
            this.Title_fisrt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_fisrt.ForeColor = System.Drawing.Color.White;
            this.Title_fisrt.Location = new System.Drawing.Point(13, 7);
            this.Title_fisrt.Name = "Title_fisrt";
            this.Title_fisrt.Size = new System.Drawing.Size(53, 18);
            this.Title_fisrt.TabIndex = 0;
            this.Title_fisrt.Text = "Stock.";
            // 
            // Stock_count_label
            // 
            this.Stock_count_label.AutoSize = true;
            this.Stock_count_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_count_label.ForeColor = System.Drawing.Color.White;
            this.Stock_count_label.Location = new System.Drawing.Point(12, 35);
            this.Stock_count_label.Name = "Stock_count_label";
            this.Stock_count_label.Size = new System.Drawing.Size(19, 16);
            this.Stock_count_label.TabIndex = 1;
            this.Stock_count_label.Text = "...";
            this.Stock_count_label.Click += new System.EventHandler(this.Stock_count_label_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.Label_Count_low);
            this.panel3.Controls.Add(this.Title_low_stock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 90);
            this.panel3.TabIndex = 1;
            // 
            // Label_Count_low
            // 
            this.Label_Count_low.AutoSize = true;
            this.Label_Count_low.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Count_low.ForeColor = System.Drawing.Color.White;
            this.Label_Count_low.Location = new System.Drawing.Point(3, 35);
            this.Label_Count_low.Name = "Label_Count_low";
            this.Label_Count_low.Size = new System.Drawing.Size(16, 15);
            this.Label_Count_low.TabIndex = 1;
            this.Label_Count_low.Text = "...";
            this.Label_Count_low.Click += new System.EventHandler(this.Label_Count_low_Click);
            // 
            // Title_low_stock
            // 
            this.Title_low_stock.AutoSize = true;
            this.Title_low_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_low_stock.ForeColor = System.Drawing.Color.White;
            this.Title_low_stock.Location = new System.Drawing.Point(13, 7);
            this.Title_low_stock.Name = "Title_low_stock";
            this.Title_low_stock.Size = new System.Drawing.Size(80, 18);
            this.Title_low_stock.TabIndex = 0;
            this.Title_low_stock.Text = "Mas bajo.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Label_count_high);
            this.panel4.Controls.Add(this.Title_High_stock);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(516, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 90);
            this.panel4.TabIndex = 2;
            // 
            // Label_count_high
            // 
            this.Label_count_high.AutoSize = true;
            this.Label_count_high.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_count_high.ForeColor = System.Drawing.Color.White;
            this.Label_count_high.Location = new System.Drawing.Point(3, 35);
            this.Label_count_high.Name = "Label_count_high";
            this.Label_count_high.Size = new System.Drawing.Size(16, 15);
            this.Label_count_high.TabIndex = 1;
            this.Label_count_high.Text = "...";
            this.Label_count_high.Click += new System.EventHandler(this.Label_count_high_Click);
            // 
            // Title_High_stock
            // 
            this.Title_High_stock.AutoSize = true;
            this.Title_High_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_High_stock.ForeColor = System.Drawing.Color.White;
            this.Title_High_stock.Location = new System.Drawing.Point(13, 7);
            this.Title_High_stock.Name = "Title_High_stock";
            this.Title_High_stock.Size = new System.Drawing.Size(74, 18);
            this.Title_High_stock.TabIndex = 0;
            this.Title_High_stock.Text = "Mas alto.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(774, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 90);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "...";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dinero en Stock.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.Controls.Add(this.chart3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 200);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 176);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.chart2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 176);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Inventario";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(560, 173);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(0, 183);
            this.chart2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Precio";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(560, 173);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart3
            // 
            chartArea15.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea15);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            this.chart3.Legends.Add(legend15);
            this.chart3.Location = new System.Drawing.Point(684, 0);
            this.chart3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.chart3.Name = "chart3";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series15.Legend = "Legend1";
            series15.Name = "Inventario";
            series15.YValuesPerPoint = 4;
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(350, 166);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chart4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(631, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(403, 297);
            this.panel6.TabIndex = 3;
            // 
            // chart4
            // 
            chartArea16.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea16);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend16.Name = "Legend1";
            this.chart4.Legends.Add(legend16);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series16.CustomProperties = "PieLabelStyle=Disabled";
            series16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chart4.Series.Add(series16);
            this.chart4.Size = new System.Drawing.Size(403, 297);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            this.chart4.Click += new System.EventHandler(this.chart4_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.Title_tabla);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 376);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(631, 297);
            this.panel7.TabIndex = 4;
            // 
            // Title_tabla
            // 
            this.Title_tabla.AutoSize = true;
            this.Title_tabla.Location = new System.Drawing.Point(3, 7);
            this.Title_tabla.Name = "Title_tabla";
            this.Title_tabla.Size = new System.Drawing.Size(34, 13);
            this.Title_tabla.TabIndex = 0;
            this.Title_tabla.Text = "Tabla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(631, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormReportInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1034, 673);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormReportInventario";
            this.Text = "FormReportInventario";
            this.Load += new System.EventHandler(this.FormReportInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_reports_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Label_count_high;
        private System.Windows.Forms.Label Title_High_stock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Label_Count_low;
        private System.Windows.Forms.Label Title_low_stock;
        private System.Windows.Forms.Label Stock_count_label;
        private System.Windows.Forms.Label Title_fisrt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Title_tabla;
    }
}