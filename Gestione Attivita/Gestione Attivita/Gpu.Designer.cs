
namespace Gestione_Attivita
{
    partial class Gpu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroProgressBarGpu = new MetroFramework.Controls.MetroProgressBar();
            this.lblGpu = new MetroFramework.Controls.MetroLabel();
            this.metroRete = new MetroFramework.Controls.MetroButton();
            this.btnGpu = new MetroFramework.Controls.MetroButton();
            this.btnDisco = new MetroFramework.Controls.MetroButton();
            this.btnRam = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(561, 121);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 0);
            this.lblInfo.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(54, 131);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "GPU";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 7;
            // 
            // metroProgressBarGpu
            // 
            this.metroProgressBarGpu.Location = new System.Drawing.Point(70, 60);
            this.metroProgressBarGpu.Name = "metroProgressBarGpu";
            this.metroProgressBarGpu.Size = new System.Drawing.Size(636, 23);
            this.metroProgressBarGpu.TabIndex = 6;
            // 
            // lblGpu
            // 
            this.lblGpu.AutoSize = true;
            this.lblGpu.Location = new System.Drawing.Point(721, 64);
            this.lblGpu.Name = "lblGpu";
            this.lblGpu.Size = new System.Drawing.Size(31, 19);
            this.lblGpu.TabIndex = 9;
            this.lblGpu.Text = "0 %";
            // 
            // metroRete
            // 
            this.metroRete.Location = new System.Drawing.Point(459, 420);
            this.metroRete.Name = "metroRete";
            this.metroRete.Size = new System.Drawing.Size(75, 23);
            this.metroRete.TabIndex = 13;
            this.metroRete.Text = "Rete";
            this.metroRete.UseSelectable = true;
            this.metroRete.Click += new System.EventHandler(this.metroRete_Click);
            // 
            // btnGpu
            // 
            this.btnGpu.Location = new System.Drawing.Point(702, 420);
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.Size = new System.Drawing.Size(75, 23);
            this.btnGpu.TabIndex = 12;
            this.btnGpu.Text = "Cpu";
            this.btnGpu.UseSelectable = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(540, 420);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(75, 23);
            this.btnDisco.TabIndex = 11;
            this.btnDisco.Text = "Disco";
            this.btnDisco.UseSelectable = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(621, 420);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 10;
            this.btnRam.Text = "Ram";
            this.btnRam.UseSelectable = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // Gpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroRete);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.lblGpu);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroProgressBarGpu);
            this.Name = "Gpu";
            this.Text = "Gpu";
            this.Load += new System.EventHandler(this.Gpu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarGpu;
        private MetroFramework.Controls.MetroLabel lblGpu;
        private MetroFramework.Controls.MetroButton metroRete;
        private MetroFramework.Controls.MetroButton btnGpu;
        private MetroFramework.Controls.MetroButton btnDisco;
        private MetroFramework.Controls.MetroButton btnRam;
    }
}