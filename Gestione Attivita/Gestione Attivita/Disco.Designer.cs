
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.prova = new MetroFramework.Controls.MetroLabel();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDisco = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarDisco = new MetroFramework.Controls.MetroProgressBar();
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(44, 127);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "DISCO";
            this.chart1.Series.Add(series2);
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
            // Disco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}