
namespace Gestione_Attivita
{
    partial class Gestore
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCpu = new MetroFramework.Controls.MetroProgressBar();
            this.lblCpu = new MetroFramework.Controls.MetroLabel();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gradi = new MetroFramework.Controls.MetroLabel();
            this.btnRam = new MetroFramework.Controls.MetroButton();
            this.btnDisco = new MetroFramework.Controls.MetroButton();
            this.btnGpu = new MetroFramework.Controls.MetroButton();
            this.metroRete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(23, 60);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(33, 19);
            this.metroLabel.TabIndex = 0;
            this.metroLabel.Text = "Cpu";
            // 
            // metroProgressBarCpu
            // 
            this.metroProgressBarCpu.Location = new System.Drawing.Point(110, 56);
            this.metroProgressBarCpu.Name = "metroProgressBarCpu";
            this.metroProgressBarCpu.Size = new System.Drawing.Size(613, 23);
            this.metroProgressBarCpu.TabIndex = 1;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(729, 60);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(31, 19);
            this.lblCpu.TabIndex = 2;
            this.lblCpu.Text = "0 %";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(5, 111);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(539, 300);
            this.chart1.TabIndex = 3;
            // 
            // gradi
            // 
            this.gradi.AutoSize = true;
            this.gradi.Location = new System.Drawing.Point(518, 111);
            this.gradi.Name = "gradi";
            this.gradi.Size = new System.Drawing.Size(0, 0);
            this.gradi.TabIndex = 4;
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(611, 388);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 5;
            this.btnRam.Text = "Ram";
            this.btnRam.UseSelectable = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(530, 388);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(75, 23);
            this.btnDisco.TabIndex = 6;
            this.btnDisco.Text = "Disco";
            this.btnDisco.UseSelectable = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click_1);
            // 
            // btnGpu
            // 
            this.btnGpu.Location = new System.Drawing.Point(692, 388);
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.Size = new System.Drawing.Size(75, 23);
            this.btnGpu.TabIndex = 7;
            this.btnGpu.Text = "Gpu";
            this.btnGpu.UseSelectable = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // metroRete
            // 
            this.metroRete.Location = new System.Drawing.Point(449, 388);
            this.metroRete.Name = "metroRete";
            this.metroRete.Size = new System.Drawing.Size(75, 23);
            this.metroRete.TabIndex = 8;
            this.metroRete.Text = "Rete";
            this.metroRete.UseSelectable = true;
            this.metroRete.Click += new System.EventHandler(this.metroRete_Click);
            // 
            // Gestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 448);
            this.Controls.Add(this.metroRete);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.gradi);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.metroProgressBarCpu);
            this.Controls.Add(this.metroLabel);
            this.Name = "Gestore";
            this.Text = "Gestore Processore";
            this.Load += new System.EventHandler(this.Gestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCpu;
        private MetroFramework.Controls.MetroLabel lblCpu;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel gradi;
        private MetroFramework.Controls.MetroButton btnRam;
        private MetroFramework.Controls.MetroButton btnDisco;
        private MetroFramework.Controls.MetroButton btnGpu;
        private MetroFramework.Controls.MetroButton metroRete;
    }
}