
namespace Gestione_Attivita
{
    partial class Disco
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.prova = new MetroFramework.Controls.MetroLabel();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDisco = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarDisco = new MetroFramework.Controls.MetroProgressBar();
            this.btnCpu = new MetroFramework.Controls.MetroButton();
            this.btnGpu = new MetroFramework.Controls.MetroButton();
            this.btnRete = new MetroFramework.Controls.MetroButton();
            this.btnRam = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // prova
            // 
            this.prova.AutoSize = true;
            this.prova.Location = new System.Drawing.Point(23, 60);
            this.prova.Name = "prova";
            this.prova.Size = new System.Drawing.Size(36, 19);
            this.prova.TabIndex = 0;
            this.prova.Text = "HDD";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(551, 117);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 0);
            this.lblInfo.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(44, 127);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "DISCO";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 8;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(743, 60);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(31, 19);
            this.lblDisco.TabIndex = 7;
            this.lblDisco.Text = "0 %";
            // 
            // metroProgressBarDisco
            // 
            this.metroProgressBarDisco.Location = new System.Drawing.Point(101, 56);
            this.metroProgressBarDisco.Name = "metroProgressBarDisco";
            this.metroProgressBarDisco.Size = new System.Drawing.Size(636, 23);
            this.metroProgressBarDisco.TabIndex = 6;
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(456, 413);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(75, 23);
            this.btnCpu.TabIndex = 19;
            this.btnCpu.Text = "Cpu";
            this.btnCpu.UseSelectable = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnGpu
            // 
            this.btnGpu.Location = new System.Drawing.Point(699, 413);
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.Size = new System.Drawing.Size(75, 23);
            this.btnGpu.TabIndex = 18;
            this.btnGpu.Text = "Gpu";
            this.btnGpu.UseSelectable = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // btnRete
            // 
            this.btnRete.Location = new System.Drawing.Point(537, 413);
            this.btnRete.Name = "btnRete";
            this.btnRete.Size = new System.Drawing.Size(75, 23);
            this.btnRete.TabIndex = 17;
            this.btnRete.Text = "Rete";
            this.btnRete.UseSelectable = true;
            this.btnRete.Click += new System.EventHandler(this.btnRete_Click);
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(618, 413);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 16;
            this.btnRam.Text = "Ram";
            this.btnRam.UseSelectable = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // Disco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnRete);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.metroProgressBarDisco);
            this.Controls.Add(this.prova);
            this.Name = "Disco";
            this.Text = "Disco";
            this.Load += new System.EventHandler(this.Disco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel prova;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel lblDisco;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarDisco;
        private MetroFramework.Controls.MetroButton btnCpu;
        private MetroFramework.Controls.MetroButton btnGpu;
        private MetroFramework.Controls.MetroButton btnRete;
        private MetroFramework.Controls.MetroButton btnRam;
    }
}