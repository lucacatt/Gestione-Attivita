
namespace Gestione_Attivita
{
    partial class Ram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRam = new MetroFramework.Controls.MetroProgressBar();
            this.lblRam = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.btnCpu = new MetroFramework.Controls.MetroButton();
            this.btnGpu = new MetroFramework.Controls.MetroButton();
            this.btnRete = new MetroFramework.Controls.MetroButton();
            this.btnDisco = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ram";
            // 
            // metroProgressBarRam
            // 
            this.metroProgressBarRam.Location = new System.Drawing.Point(65, 56);
            this.metroProgressBarRam.Name = "metroProgressBarRam";
            this.metroProgressBarRam.Size = new System.Drawing.Size(636, 23);
            this.metroProgressBarRam.TabIndex = 1;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(707, 60);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 19);
            this.lblRam.TabIndex = 2;
            this.lblRam.Text = "0 %";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(8, 127);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "RAM";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(515, 117);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 0);
            this.lblInfo.TabIndex = 5;
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(464, 413);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(75, 23);
            this.btnCpu.TabIndex = 23;
            this.btnCpu.Text = "Cpu";
            this.btnCpu.UseSelectable = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnGpu
            // 
            this.btnGpu.Location = new System.Drawing.Point(707, 413);
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.Size = new System.Drawing.Size(75, 23);
            this.btnGpu.TabIndex = 22;
            this.btnGpu.Text = "Gpu";
            this.btnGpu.UseSelectable = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // btnRete
            // 
            this.btnRete.Location = new System.Drawing.Point(545, 413);
            this.btnRete.Name = "btnRete";
            this.btnRete.Size = new System.Drawing.Size(75, 23);
            this.btnRete.TabIndex = 21;
            this.btnRete.Text = "Rete";
            this.btnRete.UseSelectable = true;
            this.btnRete.Click += new System.EventHandler(this.btnRete_Click);
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(626, 413);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(75, 23);
            this.btnDisco.TabIndex = 20;
            this.btnDisco.Text = "Disco";
            this.btnDisco.UseSelectable = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
            // 
            // Ram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnRete);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.metroProgressBarRam);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Ram";
            this.Text = "Gestore Ram";
            this.Load += new System.EventHandler(this.Ram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRam;
        private MetroFramework.Controls.MetroLabel lblRam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private MetroFramework.Controls.MetroButton btnCpu;
        private MetroFramework.Controls.MetroButton btnGpu;
        private MetroFramework.Controls.MetroButton btnRete;
        private MetroFramework.Controls.MetroButton btnDisco;
    }
}