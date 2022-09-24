namespace Kendim_Yaptim_Veri_Tabanlı_Grafik_Sistemi
{
    partial class FrmGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrgA = new System.Windows.Forms.ProgressBar();
            this.PrgB = new System.Windows.Forms.ProgressBar();
            this.PrgC = new System.Windows.Forms.ProgressBar();
            this.PrgD = new System.Windows.Forms.ProgressBar();
            this.PrgE = new System.Windows.Forms.ProgressBar();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.Cmbilce = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(990, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafik";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(982, 253);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Cmbilce);
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.PrgE);
            this.groupBox2.Controls.Add(this.PrgD);
            this.groupBox2.Controls.Add(this.PrgC);
            this.groupBox2.Controls.Add(this.PrgB);
            this.groupBox2.Controls.Add(this.PrgA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Partiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A parti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "B parti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "C parti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "D parti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "E parti:";
            // 
            // PrgA
            // 
            this.PrgA.Location = new System.Drawing.Point(87, 80);
            this.PrgA.Maximum = 200;
            this.PrgA.Name = "PrgA";
            this.PrgA.Size = new System.Drawing.Size(704, 23);
            this.PrgA.TabIndex = 5;
            // 
            // PrgB
            // 
            this.PrgB.Location = new System.Drawing.Point(85, 119);
            this.PrgB.Maximum = 200;
            this.PrgB.Name = "PrgB";
            this.PrgB.Size = new System.Drawing.Size(704, 23);
            this.PrgB.TabIndex = 6;
            // 
            // PrgC
            // 
            this.PrgC.Location = new System.Drawing.Point(85, 156);
            this.PrgC.Maximum = 200;
            this.PrgC.Name = "PrgC";
            this.PrgC.Size = new System.Drawing.Size(704, 23);
            this.PrgC.TabIndex = 7;
            // 
            // PrgD
            // 
            this.PrgD.Location = new System.Drawing.Point(85, 196);
            this.PrgD.Maximum = 200;
            this.PrgD.Name = "PrgD";
            this.PrgD.Size = new System.Drawing.Size(704, 23);
            this.PrgD.TabIndex = 8;
            // 
            // PrgE
            // 
            this.PrgE.Location = new System.Drawing.Point(84, 233);
            this.PrgE.Maximum = 200;
            this.PrgE.Name = "PrgE";
            this.PrgE.Size = new System.Drawing.Size(704, 23);
            this.PrgE.TabIndex = 9;
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(813, 80);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(32, 24);
            this.LblA.TabIndex = 10;
            this.LblA.Text = "00";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(813, 119);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(32, 24);
            this.LblB.TabIndex = 11;
            this.LblB.Text = "00";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(813, 156);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(32, 24);
            this.LblC.TabIndex = 12;
            this.LblC.Text = "00";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(813, 195);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(32, 24);
            this.LblD.TabIndex = 13;
            this.LblD.Text = "00";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(813, 232);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(32, 24);
            this.LblE.TabIndex = 14;
            this.LblE.Text = "00";
            // 
            // Cmbilce
            // 
            this.Cmbilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbilce.FormattingEnabled = true;
            this.Cmbilce.Location = new System.Drawing.Point(87, 30);
            this.Cmbilce.Name = "Cmbilce";
            this.Cmbilce.Size = new System.Drawing.Size(121, 32);
            this.Cmbilce.TabIndex = 15;
            this.Cmbilce.SelectedIndexChanged += new System.EventHandler(this.Cmbilce_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "İlçe:";
            // 
            // FrmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1016, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafik";
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafik_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ProgressBar PrgE;
        private System.Windows.Forms.ProgressBar PrgD;
        private System.Windows.Forms.ProgressBar PrgC;
        private System.Windows.Forms.ProgressBar PrgB;
        private System.Windows.Forms.ProgressBar PrgA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmbilce;
    }
}