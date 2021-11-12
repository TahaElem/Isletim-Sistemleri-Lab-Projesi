
namespace CPU_RAM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Pram = new System.Diagnostics.PerformanceCounter();
            this.Pcpu = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar_cpu = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar_ram = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_cpu = new MetroFramework.Controls.MetroLabel();
            this.lbl_ram = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Pram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pram
            // 
            this.Pram.CategoryName = "memory";
            this.Pram.CounterName = "% Committed Bytes in Use";
            // 
            // Pcpu
            // 
            this.Pcpu.CategoryName = "Processor";
            this.Pcpu.CounterName = "% Processor Time";
            this.Pcpu.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(113, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU : ";
            // 
            // metroProgressBar_cpu
            // 
            this.metroProgressBar_cpu.Location = new System.Drawing.Point(178, 132);
            this.metroProgressBar_cpu.Name = "metroProgressBar_cpu";
            this.metroProgressBar_cpu.Size = new System.Drawing.Size(300, 51);
            this.metroProgressBar_cpu.TabIndex = 1;
            // 
            // metroProgressBar_ram
            // 
            this.metroProgressBar_ram.Location = new System.Drawing.Point(178, 198);
            this.metroProgressBar_ram.Name = "metroProgressBar_ram";
            this.metroProgressBar_ram.Size = new System.Drawing.Size(300, 51);
            this.metroProgressBar_ram.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(113, 214);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "RAM :";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Location = new System.Drawing.Point(493, 148);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(31, 19);
            this.lbl_cpu.TabIndex = 4;
            this.lbl_cpu.Text = "0 %";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(493, 214);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(31, 19);
            this.lbl_ram.TabIndex = 5;
            this.lbl_ram.Text = "0 %";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 289);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(771, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 612);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.lbl_cpu);
            this.Controls.Add(this.metroProgressBar_ram);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroProgressBar_cpu);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "CPU & RAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter Pram;
        private System.Diagnostics.PerformanceCounter Pcpu;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar_cpu;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar_ram;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_cpu;
        private MetroFramework.Controls.MetroLabel lbl_ram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

