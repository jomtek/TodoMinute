
namespace TodoMinute
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTC = new System.Windows.Forms.TabControl();
            this.homeTP = new System.Windows.Forms.TabPage();
            this.futureTasksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.doneTasksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.planningTP = new System.Windows.Forms.TabPage();
            this.addTaskHBI = new TodoMinute.Theme.TodoHoverableButtonImage();
            this.planningPanel1 = new TodoMinute.Task.PlanningPanel();
            this.todoDaySlider1 = new TodoMinute.Theme.TodoDaySlider();
            this.mainTC.SuspendLayout();
            this.homeTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futureTasksChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksChart)).BeginInit();
            this.planningTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTC
            // 
            this.mainTC.Controls.Add(this.homeTP);
            this.mainTC.Controls.Add(this.planningTP);
            this.mainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTC.Font = new System.Drawing.Font("Miriam Libre", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTC.Location = new System.Drawing.Point(0, 0);
            this.mainTC.Name = "mainTC";
            this.mainTC.SelectedIndex = 0;
            this.mainTC.Size = new System.Drawing.Size(718, 593);
            this.mainTC.TabIndex = 1;
            this.mainTC.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTC_Selecting);
            // 
            // homeTP
            // 
            this.homeTP.Controls.Add(this.futureTasksChart);
            this.homeTP.Controls.Add(this.doneTasksChart);
            this.homeTP.Location = new System.Drawing.Point(4, 37);
            this.homeTP.Name = "homeTP";
            this.homeTP.Padding = new System.Windows.Forms.Padding(3);
            this.homeTP.Size = new System.Drawing.Size(710, 552);
            this.homeTP.TabIndex = 0;
            this.homeTP.Text = "Accueil";
            this.homeTP.UseVisualStyleBackColor = true;
            // 
            // futureTasksChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "Jours";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.Format = "0";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MaximumAutoSize = 80F;
            chartArea1.AxisY.Title = "Nbr. de tâches";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.futureTasksChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.futureTasksChart.Legends.Add(legend1);
            this.futureTasksChart.Location = new System.Drawing.Point(3, 12);
            this.futureTasksChart.Name = "futureTasksChart";
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Tâches à effectuer";
            series1.ShadowColor = System.Drawing.Color.Silver;
            series1.ShadowOffset = 3;
            series1.YValuesPerPoint = 2;
            this.futureTasksChart.Series.Add(series1);
            this.futureTasksChart.Size = new System.Drawing.Size(527, 252);
            this.futureTasksChart.TabIndex = 1;
            this.futureTasksChart.Text = "chart2";
            title1.BackColor = System.Drawing.Color.Gray;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title1.Font = new System.Drawing.Font("Miriam Libre", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.IndianRed;
            title1.Name = "Title1";
            title1.Text = "Tâches à effectuer pour les prochains jours";
            this.futureTasksChart.Titles.Add(title1);
            // 
            // doneTasksChart
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisX.Title = "Jours";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.LabelStyle.Format = "0";
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MaximumAutoSize = 80F;
            chartArea2.AxisY.Title = "Nbr. de tâches";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.doneTasksChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.doneTasksChart.Legends.Add(legend2);
            this.doneTasksChart.Location = new System.Drawing.Point(0, 287);
            this.doneTasksChart.Name = "doneTasksChart";
            series2.BorderWidth = 7;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Tâches effectuées";
            series2.ShadowColor = System.Drawing.Color.Silver;
            series2.ShadowOffset = 3;
            series2.YValuesPerPoint = 2;
            this.doneTasksChart.Series.Add(series2);
            this.doneTasksChart.Size = new System.Drawing.Size(527, 259);
            this.doneTasksChart.TabIndex = 0;
            this.doneTasksChart.Text = "chart1";
            title2.BackColor = System.Drawing.Color.Gray;
            title2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title2.Font = new System.Drawing.Font("Miriam Libre", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            title2.Name = "Title1";
            title2.Text = "Tâches effectuées par jour sous deux semaines";
            this.doneTasksChart.Titles.Add(title2);
            // 
            // planningTP
            // 
            this.planningTP.Controls.Add(this.addTaskHBI);
            this.planningTP.Controls.Add(this.planningPanel1);
            this.planningTP.Controls.Add(this.todoDaySlider1);
            this.planningTP.Location = new System.Drawing.Point(4, 37);
            this.planningTP.Name = "planningTP";
            this.planningTP.Padding = new System.Windows.Forms.Padding(3);
            this.planningTP.Size = new System.Drawing.Size(710, 552);
            this.planningTP.TabIndex = 1;
            this.planningTP.Text = "Planning";
            this.planningTP.UseVisualStyleBackColor = true;
            // 
            // addTaskHBI
            // 
            this.addTaskHBI.BackColor = System.Drawing.Color.Transparent;
            this.addTaskHBI.Image_Hovered = global::TodoMinute.Properties.Resources.plus_icon_hovered;
            this.addTaskHBI.Image_Normal = global::TodoMinute.Properties.Resources.plus_icon_normal;
            this.addTaskHBI.Location = new System.Drawing.Point(247, 475);
            this.addTaskHBI.Name = "addTaskHBI";
            this.addTaskHBI.Size = new System.Drawing.Size(45, 51);
            this.addTaskHBI.TabIndex = 7;
            this.addTaskHBI.Text = "todoHoverableButtonImage1";
            this.addTaskHBI.Click += new System.EventHandler(this.AddTaskHIB_Click);
            // 
            // planningPanel1
            // 
            this.planningPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planningPanel1.Location = new System.Drawing.Point(89, 74);
            this.planningPanel1.Name = "planningPanel1";
            this.planningPanel1.Size = new System.Drawing.Size(360, 398);
            this.planningPanel1.TabIndex = 5;
            // 
            // todoDaySlider1
            // 
            this.todoDaySlider1.BackColor = System.Drawing.Color.Transparent;
            this.todoDaySlider1.Location = new System.Drawing.Point(114, 16);
            this.todoDaySlider1.Name = "todoDaySlider1";
            this.todoDaySlider1.Size = new System.Drawing.Size(310, 36);
            this.todoDaySlider1.TabIndex = 0;
            this.todoDaySlider1.Text = "todoDaySlider1";
            this.todoDaySlider1.OnDayChanged += new TodoMinute.Theme.TodoDaySlider.OnDayChangedEventHandler(this.TodoDaySlider1_OnDayChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 593);
            this.Controls.Add(this.mainTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TodoMinute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTC.ResumeLayout(false);
            this.homeTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.futureTasksChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksChart)).EndInit();
            this.planningTP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Theme.TodoDaySlider todoDaySlider1;
        private System.Windows.Forms.TabControl mainTC;
        private System.Windows.Forms.TabPage homeTP;
        private System.Windows.Forms.TabPage planningTP;
        private Task.PlanningPanel planningPanel1;
        private Theme.TodoHoverableButtonImage addTaskHBI;
        private System.Windows.Forms.DataVisualization.Charting.Chart doneTasksChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart futureTasksChart;
    }
}

