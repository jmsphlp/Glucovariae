
namespace ThesisGUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyPanelTitle = new System.Windows.Forms.Label();
            this.historyDgv = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyPanel = new System.Windows.Forms.Panel();
            this.accuracyBar = new CircularProgressBar.CircularProgressBar();
            this.proceedPanel = new System.Windows.Forms.Panel();
            this.proceedLabel = new System.Windows.Forms.Label();
            this.guidePanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.guideLabel = new System.Windows.Forms.Label();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.analogChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultBar = new System.Windows.Forms.Panel();
            this.resultBarPaint = new System.Windows.Forms.Panel();
            this.resultContainer = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Panel();
            this.saveLabel = new System.Windows.Forms.Label();
            this.saveImg = new System.Windows.Forms.PictureBox();
            this.retryBtn = new System.Windows.Forms.Panel();
            this.retryLabel = new System.Windows.Forms.Label();
            this.retryImg = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.dashbImg = new System.Windows.Forms.PictureBox();
            this.signalPanel = new System.Windows.Forms.Panel();
            this.voltagePanel = new System.Windows.Forms.Panel();
            this.voltageValue = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.analogPanel = new System.Windows.Forms.Panel();
            this.analogValue = new System.Windows.Forms.Label();
            this.analogLabel = new System.Windows.Forms.Label();
            this.suggestionPanel = new System.Windows.Forms.Panel();
            this.suggestionLabel = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.birthDateDtp = new System.Windows.Forms.DateTimePicker();
            this.doneFormBtn = new System.Windows.Forms.Button();
            this.backFormBtn = new System.Windows.Forms.Button();
            this.femaleBtn = new System.Windows.Forms.Button();
            this.maleBtn = new System.Windows.Forms.Button();
            this.cnumberTxtbox = new System.Windows.Forms.TextBox();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.lnameTxtbox = new System.Windows.Forms.TextBox();
            this.addressTxtbox = new System.Windows.Forms.TextBox();
            this.fnameTxtbox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cnumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.bdateLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.formguideLabel = new System.Windows.Forms.Label();
            this.arduinoTimer = new System.Windows.Forms.Timer(this.components);
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDgv)).BeginInit();
            this.accuracyPanel.SuspendLayout();
            this.proceedPanel.SuspendLayout();
            this.guidePanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analogChart)).BeginInit();
            this.resultPanel.SuspendLayout();
            this.resultBar.SuspendLayout();
            this.resultContainer.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.saveBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).BeginInit();
            this.retryBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retryImg)).BeginInit();
            this.dashboardBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashbImg)).BeginInit();
            this.signalPanel.SuspendLayout();
            this.voltagePanel.SuspendLayout();
            this.analogPanel.SuspendLayout();
            this.suggestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.historyPanel.Controls.Add(this.historyPanelTitle);
            this.historyPanel.Controls.Add(this.historyDgv);
            this.historyPanel.Location = new System.Drawing.Point(67, 123);
            this.historyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(767, 554);
            this.historyPanel.TabIndex = 0;
            // 
            // historyPanelTitle
            // 
            this.historyPanelTitle.AutoSize = true;
            this.historyPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.historyPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.historyPanelTitle.Location = new System.Drawing.Point(13, 18);
            this.historyPanelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyPanelTitle.Name = "historyPanelTitle";
            this.historyPanelTitle.Size = new System.Drawing.Size(150, 29);
            this.historyPanelTitle.TabIndex = 20;
            this.historyPanelTitle.Text = "Latest Activty";
            this.historyPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyDgv
            // 
            this.historyDgv.AllowUserToAddRows = false;
            this.historyDgv.AllowUserToDeleteRows = false;
            this.historyDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.historyDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historyDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.historyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.Age,
            this.Sex,
            this.Condition,
            this.testDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.historyDgv.EnableHeadersVisualStyles = false;
            this.historyDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.historyDgv.Location = new System.Drawing.Point(-4, 92);
            this.historyDgv.Margin = new System.Windows.Forms.Padding(4);
            this.historyDgv.Name = "historyDgv";
            this.historyDgv.ReadOnly = true;
            this.historyDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.historyDgv.RowHeadersVisible = false;
            this.historyDgv.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.historyDgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.historyDgv.RowTemplate.Height = 42;
            this.historyDgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.historyDgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.historyDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDgv.Size = new System.Drawing.Size(767, 468);
            this.historyDgv.TabIndex = 19;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 240;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 75;
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "condition";
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 105;
            // 
            // testDate
            // 
            this.testDate.DataPropertyName = "testDate";
            this.testDate.HeaderText = "Test Date";
            this.testDate.MinimumWidth = 6;
            this.testDate.Name = "testDate";
            this.testDate.ReadOnly = true;
            this.testDate.Width = 105;
            // 
            // accuracyPanel
            // 
            this.accuracyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.accuracyPanel.Controls.Add(this.accuracyBar);
            this.accuracyPanel.Location = new System.Drawing.Point(867, 123);
            this.accuracyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.accuracyPanel.Name = "accuracyPanel";
            this.accuracyPanel.Size = new System.Drawing.Size(347, 308);
            this.accuracyPanel.TabIndex = 1;
            // 
            // accuracyBar
            // 
            this.accuracyBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.accuracyBar.AnimationSpeed = 500;
            this.accuracyBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.accuracyBar.Enabled = false;
            this.accuracyBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.accuracyBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.accuracyBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.accuracyBar.InnerMargin = 2;
            this.accuracyBar.InnerWidth = 2;
            this.accuracyBar.Location = new System.Drawing.Point(60, 49);
            this.accuracyBar.Margin = new System.Windows.Forms.Padding(4);
            this.accuracyBar.MarqueeAnimationSpeed = 2000;
            this.accuracyBar.Name = "accuracyBar";
            this.accuracyBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.accuracyBar.OuterMargin = -25;
            this.accuracyBar.OuterWidth = 25;
            this.accuracyBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.accuracyBar.ProgressWidth = 15;
            this.accuracyBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.accuracyBar.Size = new System.Drawing.Size(227, 209);
            this.accuracyBar.StartAngle = 270;
            this.accuracyBar.Step = 0;
            this.accuracyBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.accuracyBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.accuracyBar.SubscriptMargin = new System.Windows.Forms.Padding(-50, 0, 0, 0);
            this.accuracyBar.SubscriptText = "";
            this.accuracyBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.accuracyBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.accuracyBar.SuperscriptText = "";
            this.accuracyBar.TabIndex = 0;
            this.accuracyBar.TextMargin = new System.Windows.Forms.Padding(25, -10, 0, 0);
            this.accuracyBar.Value = 90;
            // 
            // proceedPanel
            // 
            this.proceedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.proceedPanel.Controls.Add(this.proceedLabel);
            this.proceedPanel.Location = new System.Drawing.Point(867, 462);
            this.proceedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.proceedPanel.Name = "proceedPanel";
            this.proceedPanel.Size = new System.Drawing.Size(347, 215);
            this.proceedPanel.TabIndex = 6;
            // 
            // proceedLabel
            // 
            this.proceedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proceedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.proceedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.proceedLabel.Location = new System.Drawing.Point(0, 0);
            this.proceedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proceedLabel.Name = "proceedLabel";
            this.proceedLabel.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.proceedLabel.Size = new System.Drawing.Size(347, 215);
            this.proceedLabel.TabIndex = 0;
            this.proceedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.proceedLabel.Click += new System.EventHandler(this.proceedLabel_Click);
            // 
            // guidePanel
            // 
            this.guidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.guidePanel.Controls.Add(this.backBtn);
            this.guidePanel.Controls.Add(this.nextBtn);
            this.guidePanel.Controls.Add(this.guideLabel);
            this.guidePanel.Location = new System.Drawing.Point(160, 92);
            this.guidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.guidePanel.Name = "guidePanel";
            this.guidePanel.Size = new System.Drawing.Size(960, 492);
            this.guidePanel.TabIndex = 7;
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.backBtn.Location = new System.Drawing.Point(67, 369);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 37);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "← Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.nextBtn.Location = new System.Drawing.Point(773, 369);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(120, 37);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next →";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // guideLabel
            // 
            this.guideLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.guideLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.guideLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.guideLabel.Location = new System.Drawing.Point(0, 0);
            this.guideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(960, 492);
            this.guideLabel.TabIndex = 0;
            this.guideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.chartPanel.Controls.Add(this.analogChart);
            this.chartPanel.Location = new System.Drawing.Point(67, 123);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(767, 406);
            this.chartPanel.TabIndex = 8;
            // 
            // analogChart
            // 
            this.analogChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            chartArea2.Name = "ChartArea1";
            this.analogChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.Title = "Analog";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.analogChart.Legends.Add(legend2);
            this.analogChart.Location = new System.Drawing.Point(0, 0);
            this.analogChart.Margin = new System.Windows.Forms.Padding(4);
            this.analogChart.Name = "analogChart";
            this.analogChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = " ";
            this.analogChart.Series.Add(series2);
            this.analogChart.Size = new System.Drawing.Size(767, 406);
            this.analogChart.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            title2.Name = "Title1";
            title2.Text = "Overview";
            this.analogChart.Titles.Add(title2);
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.resultPanel.Controls.Add(this.resultBar);
            this.resultPanel.Controls.Add(this.resultContainer);
            this.resultPanel.Location = new System.Drawing.Point(67, 560);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(4);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(767, 86);
            this.resultPanel.TabIndex = 9;
            // 
            // resultBar
            // 
            this.resultBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.resultBar.Controls.Add(this.resultBarPaint);
            this.resultBar.Location = new System.Drawing.Point(67, 18);
            this.resultBar.Margin = new System.Windows.Forms.Padding(4);
            this.resultBar.Name = "resultBar";
            this.resultBar.Size = new System.Drawing.Size(400, 49);
            this.resultBar.TabIndex = 1;
            // 
            // resultBarPaint
            // 
            this.resultBarPaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.resultBarPaint.Location = new System.Drawing.Point(0, 0);
            this.resultBarPaint.Margin = new System.Windows.Forms.Padding(4);
            this.resultBarPaint.Name = "resultBarPaint";
            this.resultBarPaint.Size = new System.Drawing.Size(133, 49);
            this.resultBarPaint.TabIndex = 0;
            // 
            // resultContainer
            // 
            this.resultContainer.Controls.Add(this.resultLabel);
            this.resultContainer.Location = new System.Drawing.Point(500, 0);
            this.resultContainer.Margin = new System.Windows.Forms.Padding(4);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(267, 86);
            this.resultContainer.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(267, 86);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.buttonsPanel.Controls.Add(this.saveBtn);
            this.buttonsPanel.Controls.Add(this.retryBtn);
            this.buttonsPanel.Controls.Add(this.dashboardBtn);
            this.buttonsPanel.Location = new System.Drawing.Point(867, 560);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(347, 123);
            this.buttonsPanel.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.saveBtn.Controls.Add(this.saveLabel);
            this.saveBtn.Controls.Add(this.saveImg);
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.saveBtn.Location = new System.Drawing.Point(240, 0);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.saveBtn.Size = new System.Drawing.Size(107, 86);
            this.saveBtn.TabIndex = 2;
            // 
            // saveLabel
            // 
            this.saveLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLabel.Location = new System.Drawing.Point(0, 58);
            this.saveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(107, 16);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "Save";
            this.saveLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // saveImg
            // 
            this.saveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImg.Image = global::ThesisGUI.Properties.Resources.iconSave;
            this.saveImg.Location = new System.Drawing.Point(0, 0);
            this.saveImg.Margin = new System.Windows.Forms.Padding(4);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(107, 70);
            this.saveImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.saveImg.TabIndex = 1;
            this.saveImg.TabStop = false;
            this.saveImg.Click += new System.EventHandler(this.saveImg_Click);
            // 
            // retryBtn
            // 
            this.retryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.retryBtn.Controls.Add(this.retryLabel);
            this.retryBtn.Controls.Add(this.retryImg);
            this.retryBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.retryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.retryBtn.Location = new System.Drawing.Point(120, 0);
            this.retryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.retryBtn.Size = new System.Drawing.Size(107, 86);
            this.retryBtn.TabIndex = 1;
            // 
            // retryLabel
            // 
            this.retryLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.retryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryLabel.Location = new System.Drawing.Point(0, 58);
            this.retryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.retryLabel.Name = "retryLabel";
            this.retryLabel.Size = new System.Drawing.Size(107, 16);
            this.retryLabel.TabIndex = 1;
            this.retryLabel.Text = "Retry";
            this.retryLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // retryImg
            // 
            this.retryImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retryImg.Image = global::ThesisGUI.Properties.Resources.iconReset;
            this.retryImg.Location = new System.Drawing.Point(0, 0);
            this.retryImg.Margin = new System.Windows.Forms.Padding(4);
            this.retryImg.Name = "retryImg";
            this.retryImg.Size = new System.Drawing.Size(107, 70);
            this.retryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.retryImg.TabIndex = 2;
            this.retryImg.TabStop = false;
            this.retryImg.Click += new System.EventHandler(this.retryImg_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.dashboardBtn.Controls.Add(this.homeLabel);
            this.dashboardBtn.Controls.Add(this.dashbImg);
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dashboardBtn.Size = new System.Drawing.Size(107, 86);
            this.dashboardBtn.TabIndex = 0;
            // 
            // homeLabel
            // 
            this.homeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(0, 58);
            this.homeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(107, 16);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Dashboard";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dashbImg
            // 
            this.dashbImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbImg.Image = global::ThesisGUI.Properties.Resources.iconDashboard;
            this.dashbImg.Location = new System.Drawing.Point(0, 0);
            this.dashbImg.Margin = new System.Windows.Forms.Padding(4);
            this.dashbImg.Name = "dashbImg";
            this.dashbImg.Size = new System.Drawing.Size(107, 70);
            this.dashbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dashbImg.TabIndex = 2;
            this.dashbImg.TabStop = false;
            this.dashbImg.Click += new System.EventHandler(this.dashbImg_Click);
            // 
            // signalPanel
            // 
            this.signalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.signalPanel.Controls.Add(this.voltagePanel);
            this.signalPanel.Controls.Add(this.analogPanel);
            this.signalPanel.Location = new System.Drawing.Point(867, 123);
            this.signalPanel.Margin = new System.Windows.Forms.Padding(4);
            this.signalPanel.Name = "signalPanel";
            this.signalPanel.Size = new System.Drawing.Size(347, 154);
            this.signalPanel.TabIndex = 11;
            // 
            // voltagePanel
            // 
            this.voltagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.voltagePanel.Controls.Add(this.voltageValue);
            this.voltagePanel.Controls.Add(this.voltageLabel);
            this.voltagePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.voltagePanel.Location = new System.Drawing.Point(207, 0);
            this.voltagePanel.Margin = new System.Windows.Forms.Padding(4);
            this.voltagePanel.Name = "voltagePanel";
            this.voltagePanel.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.voltagePanel.Size = new System.Drawing.Size(140, 123);
            this.voltagePanel.TabIndex = 1;
            // 
            // voltageValue
            // 
            this.voltageValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.voltageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.voltageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.voltageValue.Location = new System.Drawing.Point(0, 18);
            this.voltageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voltageValue.Name = "voltageValue";
            this.voltageValue.Size = new System.Drawing.Size(140, 46);
            this.voltageValue.TabIndex = 2;
            this.voltageValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // voltageLabel
            // 
            this.voltageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.voltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.voltageLabel.Location = new System.Drawing.Point(0, 77);
            this.voltageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(140, 28);
            this.voltageLabel.TabIndex = 1;
            this.voltageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // analogPanel
            // 
            this.analogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.analogPanel.Controls.Add(this.analogValue);
            this.analogPanel.Controls.Add(this.analogLabel);
            this.analogPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.analogPanel.Location = new System.Drawing.Point(0, 0);
            this.analogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.analogPanel.Name = "analogPanel";
            this.analogPanel.Padding = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.analogPanel.Size = new System.Drawing.Size(187, 123);
            this.analogPanel.TabIndex = 0;
            // 
            // analogValue
            // 
            this.analogValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.analogValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.analogValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.analogValue.Location = new System.Drawing.Point(0, 18);
            this.analogValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analogValue.Name = "analogValue";
            this.analogValue.Size = new System.Drawing.Size(187, 46);
            this.analogValue.TabIndex = 1;
            this.analogValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // analogLabel
            // 
            this.analogLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.analogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.analogLabel.Location = new System.Drawing.Point(0, 80);
            this.analogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.analogLabel.Name = "analogLabel";
            this.analogLabel.Size = new System.Drawing.Size(187, 25);
            this.analogLabel.TabIndex = 0;
            this.analogLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // suggestionPanel
            // 
            this.suggestionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.suggestionPanel.Controls.Add(this.suggestionLabel);
            this.suggestionPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suggestionPanel.Location = new System.Drawing.Point(867, 277);
            this.suggestionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.suggestionPanel.Name = "suggestionPanel";
            this.suggestionPanel.Size = new System.Drawing.Size(347, 252);
            this.suggestionPanel.TabIndex = 12;
            // 
            // suggestionLabel
            // 
            this.suggestionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.suggestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.suggestionLabel.Location = new System.Drawing.Point(0, 0);
            this.suggestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suggestionLabel.Name = "suggestionLabel";
            this.suggestionLabel.Size = new System.Drawing.Size(347, 252);
            this.suggestionLabel.TabIndex = 0;
            this.suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1180, 15);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(33, 31);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 5;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::ThesisGUI.Properties.Resources.iconClose;
            this.close.Location = new System.Drawing.Point(1231, 15);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // logoImg
            // 
            this.logoImg.Image = global::ThesisGUI.Properties.Resources.glucovariae_logo;
            this.logoImg.Location = new System.Drawing.Point(47, 31);
            this.logoImg.Margin = new System.Windows.Forms.Padding(4);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(100, 62);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImg.TabIndex = 3;
            this.logoImg.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(155, 31);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(347, 62);
            this.titlePanel.TabIndex = 13;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 62);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.formPanel.Controls.Add(this.birthDateDtp);
            this.formPanel.Controls.Add(this.doneFormBtn);
            this.formPanel.Controls.Add(this.backFormBtn);
            this.formPanel.Controls.Add(this.femaleBtn);
            this.formPanel.Controls.Add(this.maleBtn);
            this.formPanel.Controls.Add(this.cnumberTxtbox);
            this.formPanel.Controls.Add(this.emailTxtbox);
            this.formPanel.Controls.Add(this.lnameTxtbox);
            this.formPanel.Controls.Add(this.addressTxtbox);
            this.formPanel.Controls.Add(this.fnameTxtbox);
            this.formPanel.Controls.Add(this.addressLabel);
            this.formPanel.Controls.Add(this.cnumberLabel);
            this.formPanel.Controls.Add(this.emailLabel);
            this.formPanel.Controls.Add(this.sexLabel);
            this.formPanel.Controls.Add(this.bdateLabel);
            this.formPanel.Controls.Add(this.lnameLabel);
            this.formPanel.Controls.Add(this.fnameLabel);
            this.formPanel.Controls.Add(this.formguideLabel);
            this.formPanel.Location = new System.Drawing.Point(160, 185);
            this.formPanel.Margin = new System.Windows.Forms.Padding(4);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(960, 492);
            this.formPanel.TabIndex = 14;
            // 
            // birthDateDtp
            // 
            this.birthDateDtp.CustomFormat = "MM-dd-yyyy";
            this.birthDateDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.birthDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDtp.Location = new System.Drawing.Point(0, 295);
            this.birthDateDtp.Margin = new System.Windows.Forms.Padding(4);
            this.birthDateDtp.Name = "birthDateDtp";
            this.birthDateDtp.Size = new System.Drawing.Size(305, 36);
            this.birthDateDtp.TabIndex = 3;
            // 
            // doneFormBtn
            // 
            this.doneFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.doneFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneFormBtn.FlatAppearance.BorderSize = 0;
            this.doneFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.doneFormBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.doneFormBtn.Location = new System.Drawing.Point(817, 363);
            this.doneFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.doneFormBtn.Name = "doneFormBtn";
            this.doneFormBtn.Size = new System.Drawing.Size(143, 37);
            this.doneFormBtn.TabIndex = 9;
            this.doneFormBtn.Text = "Done";
            this.doneFormBtn.UseVisualStyleBackColor = false;
            this.doneFormBtn.Click += new System.EventHandler(this.doneFormBtn_Click);
            // 
            // backFormBtn
            // 
            this.backFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.backFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backFormBtn.FlatAppearance.BorderSize = 0;
            this.backFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backFormBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.backFormBtn.Location = new System.Drawing.Point(653, 363);
            this.backFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backFormBtn.Name = "backFormBtn";
            this.backFormBtn.Size = new System.Drawing.Size(143, 37);
            this.backFormBtn.TabIndex = 10;
            this.backFormBtn.Text = "Back";
            this.backFormBtn.UseVisualStyleBackColor = false;
            this.backFormBtn.Click += new System.EventHandler(this.backFormBtn_Click);
            // 
            // femaleBtn
            // 
            this.femaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.femaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleBtn.FlatAppearance.BorderSize = 0;
            this.femaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.femaleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.femaleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.femaleBtn.Location = new System.Drawing.Point(491, 98);
            this.femaleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(143, 37);
            this.femaleBtn.TabIndex = 5;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = false;
            this.femaleBtn.Click += new System.EventHandler(this.femaleBtn_Click);
            // 
            // maleBtn
            // 
            this.maleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.maleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleBtn.FlatAppearance.BorderSize = 0;
            this.maleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.maleBtn.Location = new System.Drawing.Point(327, 98);
            this.maleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(143, 37);
            this.maleBtn.TabIndex = 4;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = false;
            this.maleBtn.Click += new System.EventHandler(this.maleBtn_Click);
            // 
            // cnumberTxtbox
            // 
            this.cnumberTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cnumberTxtbox.Location = new System.Drawing.Point(327, 295);
            this.cnumberTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.cnumberTxtbox.Multiline = true;
            this.cnumberTxtbox.Name = "cnumberTxtbox";
            this.cnumberTxtbox.Size = new System.Drawing.Size(305, 36);
            this.cnumberTxtbox.TabIndex = 7;
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTxtbox.Location = new System.Drawing.Point(327, 197);
            this.emailTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxtbox.Multiline = true;
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(305, 36);
            this.emailTxtbox.TabIndex = 6;
            // 
            // lnameTxtbox
            // 
            this.lnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnameTxtbox.Location = new System.Drawing.Point(0, 197);
            this.lnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.lnameTxtbox.Multiline = true;
            this.lnameTxtbox.Name = "lnameTxtbox";
            this.lnameTxtbox.Size = new System.Drawing.Size(305, 36);
            this.lnameTxtbox.TabIndex = 2;
            // 
            // addressTxtbox
            // 
            this.addressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressTxtbox.Location = new System.Drawing.Point(653, 98);
            this.addressTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTxtbox.Multiline = true;
            this.addressTxtbox.Name = "addressTxtbox";
            this.addressTxtbox.Size = new System.Drawing.Size(305, 98);
            this.addressTxtbox.TabIndex = 8;
            // 
            // fnameTxtbox
            // 
            this.fnameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fnameTxtbox.Location = new System.Drawing.Point(0, 98);
            this.fnameTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.fnameTxtbox.Multiline = true;
            this.fnameTxtbox.Name = "fnameTxtbox";
            this.fnameTxtbox.Size = new System.Drawing.Size(305, 36);
            this.fnameTxtbox.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.addressLabel.Location = new System.Drawing.Point(653, 62);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(71, 20);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnumberLabel
            // 
            this.cnumberLabel.AutoSize = true;
            this.cnumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cnumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cnumberLabel.Location = new System.Drawing.Point(327, 258);
            this.cnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnumberLabel.Name = "cnumberLabel";
            this.cnumberLabel.Size = new System.Drawing.Size(131, 20);
            this.cnumberLabel.TabIndex = 6;
            this.cnumberLabel.Text = "Contact Number";
            this.cnumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.emailLabel.Location = new System.Drawing.Point(327, 160);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 20);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.sexLabel.Location = new System.Drawing.Point(327, 62);
            this.sexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(37, 20);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Sex";
            this.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bdateLabel
            // 
            this.bdateLabel.AutoSize = true;
            this.bdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bdateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bdateLabel.Location = new System.Drawing.Point(0, 258);
            this.bdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bdateLabel.Name = "bdateLabel";
            this.bdateLabel.Size = new System.Drawing.Size(86, 20);
            this.bdateLabel.TabIndex = 3;
            this.bdateLabel.Text = "Birth Date";
            this.bdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lnameLabel.Location = new System.Drawing.Point(0, 160);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(91, 20);
            this.lnameLabel.TabIndex = 2;
            this.lnameLabel.Text = "Last Name";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.fnameLabel.Location = new System.Drawing.Point(0, 62);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(92, 20);
            this.fnameLabel.TabIndex = 1;
            this.fnameLabel.Text = "First Name";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formguideLabel
            // 
            this.formguideLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formguideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.formguideLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.formguideLabel.Location = new System.Drawing.Point(0, 0);
            this.formguideLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formguideLabel.Name = "formguideLabel";
            this.formguideLabel.Size = new System.Drawing.Size(960, 25);
            this.formguideLabel.TabIndex = 0;
            this.formguideLabel.Text = "Please fill out this form first.";
            // 
            // arduinoTimer
            // 
            this.arduinoTimer.Interval = 1000;
            this.arduinoTimer.Tick += new System.EventHandler(this.arduinoTimer_Tick);
            // 
            // arduinoPort
            // 
            this.arduinoPort.PortName = "COM3";
            this.arduinoPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.arduinoPort_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1280, 738);
            this.Controls.Add(this.accuracyPanel);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.signalPanel);
            this.Controls.Add(this.proceedPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.suggestionPanel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.guidePanel);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDgv)).EndInit();
            this.accuracyPanel.ResumeLayout(false);
            this.proceedPanel.ResumeLayout(false);
            this.guidePanel.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analogChart)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.resultBar.ResumeLayout(false);
            this.resultContainer.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.saveBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveImg)).EndInit();
            this.retryBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.retryImg)).EndInit();
            this.dashboardBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashbImg)).EndInit();
            this.signalPanel.ResumeLayout(false);
            this.voltagePanel.ResumeLayout(false);
            this.analogPanel.ResumeLayout(false);
            this.suggestionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Panel accuracyPanel;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel proceedPanel;
        private CircularProgressBar.CircularProgressBar accuracyBar;
        private System.Windows.Forms.Label proceedLabel;
        private System.Windows.Forms.Panel guidePanel;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel signalPanel;
        private System.Windows.Forms.Panel suggestionPanel;
        private System.Windows.Forms.Panel voltagePanel;
        private System.Windows.Forms.Panel analogPanel;
        private System.Windows.Forms.Panel retryBtn;
        private System.Windows.Forms.Panel dashboardBtn;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Label analogValue;
        private System.Windows.Forms.Label analogLabel;
        private System.Windows.Forms.Label suggestionLabel;
        private System.Windows.Forms.Label retryLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label voltageValue;
        private System.Windows.Forms.Panel saveBtn;
        private System.Windows.Forms.PictureBox saveImg;
        private System.Windows.Forms.Label saveLabel;
        private System.Windows.Forms.PictureBox retryImg;
        private System.Windows.Forms.PictureBox dashbImg;
        private System.Windows.Forms.Panel resultContainer;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel resultBar;
        private System.Windows.Forms.Panel resultBarPaint;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart analogChart;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label formguideLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cnumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label bdateLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox addressTxtbox;
        private System.Windows.Forms.TextBox fnameTxtbox;
        private System.Windows.Forms.TextBox cnumberTxtbox;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.TextBox lnameTxtbox;
        private System.Windows.Forms.Button maleBtn;
        private System.Windows.Forms.Button doneFormBtn;
        private System.Windows.Forms.Button backFormBtn;
        private System.Windows.Forms.Button femaleBtn;
        private System.Windows.Forms.Timer arduinoTimer;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.DateTimePicker birthDateDtp;
        private System.Windows.Forms.DataGridView historyDgv;
        private System.Windows.Forms.Label historyPanelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDate;
    }
}