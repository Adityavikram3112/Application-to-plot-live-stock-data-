
namespace Project3_Stock_App_
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CmpnyNamelabel = new System.Windows.Forms.Label();
            this.StartDatelable = new System.Windows.Forms.Label();
            this.EndDatelabel = new System.Windows.Forms.Label();
            this.HighestOpenLabel = new System.Windows.Forms.Label();
            this.HighestCloseLabel = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.HighestOpenText = new System.Windows.Forms.TextBox();
            this.HighestCloseText = new System.Windows.Forms.TextBox();
            this.DataChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(64, 447);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(173, 447);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // CmpnyNamelabel
            // 
            this.CmpnyNamelabel.AutoSize = true;
            this.CmpnyNamelabel.Location = new System.Drawing.Point(34, 141);
            this.CmpnyNamelabel.Name = "CmpnyNamelabel";
            this.CmpnyNamelabel.Size = new System.Drawing.Size(82, 13);
            this.CmpnyNamelabel.TabIndex = 2;
            this.CmpnyNamelabel.Text = "Company Name";
            // 
            // StartDatelable
            // 
            this.StartDatelable.AutoSize = true;
            this.StartDatelable.Location = new System.Drawing.Point(61, 175);
            this.StartDatelable.Name = "StartDatelable";
            this.StartDatelable.Size = new System.Drawing.Size(55, 13);
            this.StartDatelable.TabIndex = 3;
            this.StartDatelable.Text = "Start Date";
            // 
            // EndDatelabel
            // 
            this.EndDatelabel.AutoSize = true;
            this.EndDatelabel.Location = new System.Drawing.Point(64, 209);
            this.EndDatelabel.Name = "EndDatelabel";
            this.EndDatelabel.Size = new System.Drawing.Size(52, 13);
            this.EndDatelabel.TabIndex = 4;
            this.EndDatelabel.Text = "End Date";
            // 
            // HighestOpenLabel
            // 
            this.HighestOpenLabel.AutoSize = true;
            this.HighestOpenLabel.Location = new System.Drawing.Point(44, 342);
            this.HighestOpenLabel.Name = "HighestOpenLabel";
            this.HighestOpenLabel.Size = new System.Drawing.Size(72, 13);
            this.HighestOpenLabel.TabIndex = 5;
            this.HighestOpenLabel.Text = "Highest Open";
            // 
            // HighestCloseLabel
            // 
            this.HighestCloseLabel.AutoSize = true;
            this.HighestCloseLabel.Location = new System.Drawing.Point(44, 380);
            this.HighestCloseLabel.Name = "HighestCloseLabel";
            this.HighestCloseLabel.Size = new System.Drawing.Size(72, 13);
            this.HighestCloseLabel.TabIndex = 6;
            this.HighestCloseLabel.Text = "Highest Close";
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy/MM/dd";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(134, 169);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(114, 20);
            this.StartDate.TabIndex = 7;
            // 
            // EndDate
            // 
            this.EndDate.CustomFormat = "yyyy/MM/dd";
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(134, 203);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(114, 20);
            this.EndDate.TabIndex = 8;
            // 
            // HighestOpenText
            // 
            this.HighestOpenText.Location = new System.Drawing.Point(134, 335);
            this.HighestOpenText.Name = "HighestOpenText";
            this.HighestOpenText.Size = new System.Drawing.Size(114, 20);
            this.HighestOpenText.TabIndex = 10;
            // 
            // HighestCloseText
            // 
            this.HighestCloseText.Location = new System.Drawing.Point(134, 373);
            this.HighestCloseText.Name = "HighestCloseText";
            this.HighestCloseText.Size = new System.Drawing.Size(114, 20);
            this.HighestCloseText.TabIndex = 11;
            // 
            // DataChart1
            // 
            chartArea8.Name = "ChartArea1";
            this.DataChart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.DataChart1.Legends.Add(legend8);
            this.DataChart1.Location = new System.Drawing.Point(344, 23);
            this.DataChart1.Name = "DataChart1";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Color = System.Drawing.Color.Green;
            series29.Legend = "Legend1";
            series29.Name = "Open";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Color = System.Drawing.Color.RoyalBlue;
            series30.Legend = "Legend1";
            series30.Name = "Close";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series31.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series31.Legend = "Legend1";
            series31.Name = "High";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series32.Legend = "Legend1";
            series32.Name = "Low";
            this.DataChart1.Series.Add(series29);
            this.DataChart1.Series.Add(series30);
            this.DataChart1.Series.Add(series31);
            this.DataChart1.Series.Add(series32);
            this.DataChart1.Size = new System.Drawing.Size(815, 630);
            this.DataChart1.TabIndex = 12;
            this.DataChart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CompanyBox
            // 
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(134, 133);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(121, 21);
            this.CompanyBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 683);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.DataChart1);
            this.Controls.Add(this.HighestCloseText);
            this.Controls.Add(this.HighestOpenText);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.HighestCloseLabel);
            this.Controls.Add(this.HighestOpenLabel);
            this.Controls.Add(this.EndDatelabel);
            this.Controls.Add(this.StartDatelable);
            this.Controls.Add(this.CmpnyNamelabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label CmpnyNamelabel;
        private System.Windows.Forms.Label StartDatelable;
        private System.Windows.Forms.Label EndDatelabel;
        private System.Windows.Forms.Label HighestOpenLabel;
        private System.Windows.Forms.Label HighestCloseLabel;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.TextBox HighestOpenText;
        private System.Windows.Forms.TextBox HighestCloseText;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CompanyBox;
    }
}

