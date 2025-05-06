namespace Yapılacaklar_Uygulaması__To_Do_List__APP_
{
    partial class StatisticsForm
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblIncomplete = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblLast7Days = new System.Windows.Forms.Label();
            this.chartTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(29, 55);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompleted.Location = new System.Drawing.Point(29, 85);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(35, 13);
            this.lblCompleted.TabIndex = 1;
            this.lblCompleted.Text = "label2";
            // 
            // lblIncomplete
            // 
            this.lblIncomplete.AutoSize = true;
            this.lblIncomplete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncomplete.Location = new System.Drawing.Point(29, 114);
            this.lblIncomplete.Name = "lblIncomplete";
            this.lblIncomplete.Size = new System.Drawing.Size(35, 13);
            this.lblIncomplete.TabIndex = 2;
            this.lblIncomplete.Text = "label3";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToday.Location = new System.Drawing.Point(29, 143);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(35, 13);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "label4";
            // 
            // lblLast7Days
            // 
            this.lblLast7Days.AutoSize = true;
            this.lblLast7Days.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLast7Days.Location = new System.Drawing.Point(29, 169);
            this.lblLast7Days.Name = "lblLast7Days";
            this.lblLast7Days.Size = new System.Drawing.Size(35, 13);
            this.lblLast7Days.TabIndex = 4;
            this.lblLast7Days.Text = "label5";
            // 
            // chartTasks
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTasks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTasks.Legends.Add(legend1);
            this.chartTasks.Location = new System.Drawing.Point(294, 12);
            this.chartTasks.Name = "chartTasks";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTasks.Series.Add(series1);
            this.chartTasks.Size = new System.Drawing.Size(300, 300);
            this.chartTasks.TabIndex = 5;
            this.chartTasks.Text = "chart1";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(606, 330);
            this.Controls.Add(this.chartTasks);
            this.Controls.Add(this.lblLast7Days);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblIncomplete);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.lblTotal);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblIncomplete;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblLast7Days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTasks;
    }
}