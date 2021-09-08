
namespace Gestione_Attivita
{
    partial class Net
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbInterface = new MetroFramework.Controls.MetroComboBox();
            this.lblBytesSent = new MetroFramework.Controls.MetroLabel();
            this.lblBytesReceived = new MetroFramework.Controls.MetroLabel();
            this.lblSpeed = new MetroFramework.Controls.MetroLabel();
            this.lblInterfaceType = new MetroFramework.Controls.MetroLabel();
            this.lblDownload = new MetroFramework.Controls.MetroLabel();
            this.lblUpload = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUpload1 = new MetroFramework.Controls.MetroLabel();
            this.lblDownload1 = new MetroFramework.Controls.MetroLabel();
            this.btnGpu = new MetroFramework.Controls.MetroButton();
            this.btnDisco = new MetroFramework.Controls.MetroButton();
            this.btnRam = new MetroFramework.Controls.MetroButton();
            this.btnCpu = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbInterface
            // 
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.ItemHeight = 23;
            this.cmbInterface.Location = new System.Drawing.Point(23, 63);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(121, 29);
            this.cmbInterface.TabIndex = 0;
            this.cmbInterface.UseSelectable = true;
            // 
            // lblBytesSent
            // 
            this.lblBytesSent.AutoSize = true;
            this.lblBytesSent.Location = new System.Drawing.Point(120, 95);
            this.lblBytesSent.Name = "lblBytesSent";
            this.lblBytesSent.Size = new System.Drawing.Size(16, 19);
            this.lblBytesSent.TabIndex = 1;
            this.lblBytesSent.Text = "0";
            // 
            // lblBytesReceived
            // 
            this.lblBytesReceived.AutoSize = true;
            this.lblBytesReceived.Location = new System.Drawing.Point(120, 114);
            this.lblBytesReceived.Name = "lblBytesReceived";
            this.lblBytesReceived.Size = new System.Drawing.Size(16, 19);
            this.lblBytesReceived.TabIndex = 2;
            this.lblBytesReceived.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(23, 133);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(54, 19);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Velocità";
            // 
            // lblInterfaceType
            // 
            this.lblInterfaceType.AutoSize = true;
            this.lblInterfaceType.Location = new System.Drawing.Point(23, 152);
            this.lblInterfaceType.Name = "lblInterfaceType";
            this.lblInterfaceType.Size = new System.Drawing.Size(113, 19);
            this.lblInterfaceType.TabIndex = 4;
            this.lblInterfaceType.Text = "Tipo di interfaccia";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(23, 171);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(105, 19);
            this.lblDownload.TabIndex = 5;
            this.lblDownload.Text = "Download [KB/s]";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(23, 190);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(89, 19);
            this.lblUpload.TabIndex = 6;
            this.lblUpload.Text = "Upload [KB/s]";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Byte ricevuti";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Byte inviati";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(276, 95);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "DOWNLOAD";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(511, 300);
            this.chart1.TabIndex = 9;
            // 
            // lblUpload1
            // 
            this.lblUpload1.AutoSize = true;
            this.lblUpload1.Location = new System.Drawing.Point(130, 190);
            this.lblUpload1.Name = "lblUpload1";
            this.lblUpload1.Size = new System.Drawing.Size(16, 19);
            this.lblUpload1.TabIndex = 11;
            this.lblUpload1.Text = "0";
            // 
            // lblDownload1
            // 
            this.lblDownload1.AutoSize = true;
            this.lblDownload1.Location = new System.Drawing.Point(130, 171);
            this.lblDownload1.Name = "lblDownload1";
            this.lblDownload1.Size = new System.Drawing.Size(16, 19);
            this.lblDownload1.TabIndex = 10;
            this.lblDownload1.Text = "0";
            // 
            // btnGpu
            // 
            this.btnGpu.Location = new System.Drawing.Point(702, 404);
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.Size = new System.Drawing.Size(75, 23);
            this.btnGpu.TabIndex = 14;
            this.btnGpu.Text = "Gpu";
            this.btnGpu.UseSelectable = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(540, 404);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(75, 23);
            this.btnDisco.TabIndex = 13;
            this.btnDisco.Text = "Disco";
            this.btnDisco.UseSelectable = true;
            this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(621, 404);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(75, 23);
            this.btnRam.TabIndex = 12;
            this.btnRam.Text = "Ram";
            this.btnRam.UseSelectable = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(459, 404);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(75, 23);
            this.btnCpu.TabIndex = 15;
            this.btnCpu.Text = "Cpu";
            this.btnCpu.UseSelectable = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // Net
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.lblUpload1);
            this.Controls.Add(this.lblDownload1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblInterfaceType);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblBytesReceived);
            this.Controls.Add(this.lblBytesSent);
            this.Controls.Add(this.cmbInterface);
            this.Name = "Net";
            this.Text = "Net";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbInterface;
        private MetroFramework.Controls.MetroLabel lblBytesSent;
        private MetroFramework.Controls.MetroLabel lblBytesReceived;
        private MetroFramework.Controls.MetroLabel lblSpeed;
        private MetroFramework.Controls.MetroLabel lblInterfaceType;
        private MetroFramework.Controls.MetroLabel lblDownload;
        private MetroFramework.Controls.MetroLabel lblUpload;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel lblUpload1;
        private MetroFramework.Controls.MetroLabel lblDownload1;
        private MetroFramework.Controls.MetroButton btnGpu;
        private MetroFramework.Controls.MetroButton btnDisco;
        private MetroFramework.Controls.MetroButton btnRam;
        private MetroFramework.Controls.MetroButton btnCpu;
    }
}