
namespace MyTrainer
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainFrame = new System.Windows.Forms.TabControl();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.trCoverPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trainTrainStatsMini = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trainTodayToTime = new System.Windows.Forms.Label();
            this.trainTodaySince = new System.Windows.Forms.Label();
            this.trainTodayFromTime = new System.Windows.Forms.Label();
            this.trainTodayFrom = new System.Windows.Forms.Label();
            this.trainYouTrainedLabel = new System.Windows.Forms.Label();
            this.trainTimeToday = new System.Windows.Forms.Label();
            this.trainDaysGone = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.trainMonthRequired = new System.Windows.Forms.Label();
            this.trainMonthGone = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.trainDaysRequired = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.trainStartButton = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.trainWeeksRequired = new System.Windows.Forms.Label();
            this.trainDetailedButton = new System.Windows.Forms.Button();
            this.trainChangeObjButton = new System.Windows.Forms.Button();
            this.trainWeeksGone = new System.Windows.Forms.Label();
            this.tabFootball = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.footStatsMini = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.footTimeSince = new System.Windows.Forms.Label();
            this.footSince = new System.Windows.Forms.Label();
            this.footTimeFrom = new System.Windows.Forms.Label();
            this.footFrom = new System.Windows.Forms.Label();
            this.footyouTrainedToday = new System.Windows.Forms.Label();
            this.footTrainingTime = new System.Windows.Forms.Label();
            this.footDaysGone = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.footMonthRequired = new System.Windows.Forms.Label();
            this.footMonthGone = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.footDaysRequired = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.footStartButton = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.footWeeksRequired = new System.Windows.Forms.Label();
            this.footDetailedButton = new System.Windows.Forms.Button();
            this.footChangeObjButton = new System.Windows.Forms.Button();
            this.footWeeksGone = new System.Windows.Forms.Label();
            this.TrainKindLabel = new System.Windows.Forms.Label();
            this.mainFrame.SuspendLayout();
            this.tabTraining.SuspendLayout();
            this.trCoverPanel.SuspendLayout();
            this.trainTrainStatsMini.SuspendLayout();
            this.tabFootball.SuspendLayout();
            this.panel2.SuspendLayout();
            this.footStatsMini.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFrame
            // 
            this.mainFrame.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.mainFrame.Controls.Add(this.tabTraining);
            this.mainFrame.Controls.Add(this.tabFootball);
            this.mainFrame.Location = new System.Drawing.Point(4, 51);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.SelectedIndex = 0;
            this.mainFrame.Size = new System.Drawing.Size(675, 363);
            this.mainFrame.TabIndex = 1;
            this.mainFrame.Selected += new System.Windows.Forms.TabControlEventHandler(this.trainTabSelected);
            // 
            // tabTraining
            // 
            this.tabTraining.Controls.Add(this.trCoverPanel);
            this.tabTraining.Controls.Add(this.trainTrainStatsMini);
            this.tabTraining.Controls.Add(this.trainDaysGone);
            this.tabTraining.Controls.Add(this.label25);
            this.tabTraining.Controls.Add(this.trainMonthRequired);
            this.tabTraining.Controls.Add(this.trainMonthGone);
            this.tabTraining.Controls.Add(this.label27);
            this.tabTraining.Controls.Add(this.label34);
            this.tabTraining.Controls.Add(this.trainDaysRequired);
            this.tabTraining.Controls.Add(this.label33);
            this.tabTraining.Controls.Add(this.label29);
            this.tabTraining.Controls.Add(this.trainStartButton);
            this.tabTraining.Controls.Add(this.label30);
            this.tabTraining.Controls.Add(this.trainWeeksRequired);
            this.tabTraining.Controls.Add(this.trainDetailedButton);
            this.tabTraining.Controls.Add(this.trainChangeObjButton);
            this.tabTraining.Controls.Add(this.trainWeeksGone);
            this.tabTraining.Location = new System.Drawing.Point(4, 4);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraining.Size = new System.Drawing.Size(667, 337);
            this.tabTraining.TabIndex = 0;
            this.tabTraining.Text = "Тренировки";
            this.tabTraining.UseVisualStyleBackColor = true;
            // 
            // trCoverPanel
            // 
            this.trCoverPanel.Controls.Add(this.label3);
            this.trCoverPanel.Location = new System.Drawing.Point(59, 20);
            this.trCoverPanel.Name = "trCoverPanel";
            this.trCoverPanel.Size = new System.Drawing.Size(385, 216);
            this.trCoverPanel.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Цель не установлена";
            // 
            // trainTrainStatsMini
            // 
            this.trainTrainStatsMini.Controls.Add(this.label1);
            this.trainTrainStatsMini.Controls.Add(this.trainTodayToTime);
            this.trainTrainStatsMini.Controls.Add(this.trainTodaySince);
            this.trainTrainStatsMini.Controls.Add(this.trainTodayFromTime);
            this.trainTrainStatsMini.Controls.Add(this.trainTodayFrom);
            this.trainTrainStatsMini.Controls.Add(this.trainYouTrainedLabel);
            this.trainTrainStatsMini.Controls.Add(this.trainTimeToday);
            this.trainTrainStatsMini.Location = new System.Drawing.Point(459, 20);
            this.trainTrainStatsMini.Name = "trainTrainStatsMini";
            this.trainTrainStatsMini.Size = new System.Drawing.Size(200, 170);
            this.trainTrainStatsMini.TabIndex = 37;
            this.trainTrainStatsMini.TabStop = false;
            this.trainTrainStatsMini.Text = "Статистика";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Дневная цель достигнута";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trainTodayToTime
            // 
            this.trainTodayToTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainTodayToTime.Location = new System.Drawing.Point(99, 96);
            this.trainTodayToTime.Name = "trainTodayToTime";
            this.trainTodayToTime.Size = new System.Drawing.Size(41, 17);
            this.trainTodayToTime.TabIndex = 22;
            this.trainTodayToTime.Text = "00:00";
            // 
            // trainTodaySince
            // 
            this.trainTodaySince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainTodaySince.Location = new System.Drawing.Point(68, 96);
            this.trainTodaySince.Name = "trainTodaySince";
            this.trainTodaySince.Size = new System.Drawing.Size(25, 17);
            this.trainTodaySince.TabIndex = 21;
            this.trainTodaySince.Text = "До";
            // 
            // trainTodayFromTime
            // 
            this.trainTodayFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainTodayFromTime.Location = new System.Drawing.Point(23, 96);
            this.trainTodayFromTime.Name = "trainTodayFromTime";
            this.trainTodayFromTime.Size = new System.Drawing.Size(41, 17);
            this.trainTodayFromTime.TabIndex = 20;
            this.trainTodayFromTime.Text = "00:00";
            // 
            // trainTodayFrom
            // 
            this.trainTodayFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainTodayFrom.Location = new System.Drawing.Point(6, 96);
            this.trainTodayFrom.Name = "trainTodayFrom";
            this.trainTodayFrom.Size = new System.Drawing.Size(126, 17);
            this.trainTodayFrom.TabIndex = 19;
            this.trainTodayFrom.Text = "С";
            // 
            // trainYouTrainedLabel
            // 
            this.trainYouTrainedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainYouTrainedLabel.Location = new System.Drawing.Point(6, 17);
            this.trainYouTrainedLabel.Name = "trainYouTrainedLabel";
            this.trainYouTrainedLabel.Size = new System.Drawing.Size(126, 36);
            this.trainYouTrainedLabel.TabIndex = 17;
            this.trainYouTrainedLabel.Text = "Сегодня ты тренировался:";
            // 
            // trainTimeToday
            // 
            this.trainTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainTimeToday.Location = new System.Drawing.Point(6, 53);
            this.trainTimeToday.Name = "trainTimeToday";
            this.trainTimeToday.Size = new System.Drawing.Size(126, 16);
            this.trainTimeToday.TabIndex = 18;
            this.trainTimeToday.Text = "00:00:00";
            // 
            // trainDaysGone
            // 
            this.trainDaysGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainDaysGone.Location = new System.Drawing.Point(46, 20);
            this.trainDaysGone.Name = "trainDaysGone";
            this.trainDaysGone.Size = new System.Drawing.Size(47, 67);
            this.trainDaysGone.TabIndex = 22;
            this.trainDaysGone.Text = "0";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(285, 186);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 16);
            this.label25.TabIndex = 36;
            this.label25.Text = "месяцев";
            this.label25.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trainMonthRequired
            // 
            this.trainMonthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainMonthRequired.Location = new System.Drawing.Point(256, 165);
            this.trainMonthRequired.Name = "trainMonthRequired";
            this.trainMonthRequired.Size = new System.Drawing.Size(23, 37);
            this.trainMonthRequired.TabIndex = 29;
            this.trainMonthRequired.Text = "0";
            this.trainMonthRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trainMonthGone
            // 
            this.trainMonthGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainMonthGone.Location = new System.Drawing.Point(182, 137);
            this.trainMonthGone.Name = "trainMonthGone";
            this.trainMonthGone.Size = new System.Drawing.Size(47, 67);
            this.trainMonthGone.TabIndex = 28;
            this.trainMonthGone.Text = "0";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(379, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 16);
            this.label27.TabIndex = 35;
            this.label27.Text = "недель";
            this.label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(235, 165);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 37);
            this.label34.TabIndex = 30;
            this.label34.Text = "/";
            this.label34.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // trainDaysRequired
            // 
            this.trainDaysRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainDaysRequired.Location = new System.Drawing.Point(120, 48);
            this.trainDaysRequired.Name = "trainDaysRequired";
            this.trainDaysRequired.Size = new System.Drawing.Size(23, 37);
            this.trainDaysRequired.TabIndex = 23;
            this.trainDaysRequired.Text = "0";
            this.trainDaysRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(331, 48);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 37);
            this.label33.TabIndex = 27;
            this.label33.Text = "/";
            this.label33.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(149, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 16);
            this.label29.TabIndex = 34;
            this.label29.Text = "днейднейдней";
            this.label29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trainStartButton
            // 
            this.trainStartButton.Location = new System.Drawing.Point(195, 242);
            this.trainStartButton.Name = "trainStartButton";
            this.trainStartButton.Size = new System.Drawing.Size(154, 50);
            this.trainStartButton.TabIndex = 31;
            this.trainStartButton.Text = "Начать тренировку";
            this.trainStartButton.UseVisualStyleBackColor = true;
            this.trainStartButton.Click += new System.EventHandler(this.trainStartButton_Click);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(99, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 37);
            this.label30.TabIndex = 24;
            this.label30.Text = "/";
            this.label30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // trainWeeksRequired
            // 
            this.trainWeeksRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainWeeksRequired.Location = new System.Drawing.Point(352, 48);
            this.trainWeeksRequired.Name = "trainWeeksRequired";
            this.trainWeeksRequired.Size = new System.Drawing.Size(23, 37);
            this.trainWeeksRequired.TabIndex = 26;
            this.trainWeeksRequired.Text = "0";
            this.trainWeeksRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // trainDetailedButton
            // 
            this.trainDetailedButton.Location = new System.Drawing.Point(584, 269);
            this.trainDetailedButton.Name = "trainDetailedButton";
            this.trainDetailedButton.Size = new System.Drawing.Size(75, 23);
            this.trainDetailedButton.TabIndex = 33;
            this.trainDetailedButton.Text = "Подробно";
            this.trainDetailedButton.UseVisualStyleBackColor = true;
            // 
            // trainChangeObjButton
            // 
            this.trainChangeObjButton.Location = new System.Drawing.Point(550, 298);
            this.trainChangeObjButton.Name = "trainChangeObjButton";
            this.trainChangeObjButton.Size = new System.Drawing.Size(109, 30);
            this.trainChangeObjButton.TabIndex = 32;
            this.trainChangeObjButton.Text = "Изменить цели";
            this.trainChangeObjButton.UseVisualStyleBackColor = true;
            this.trainChangeObjButton.Click += new System.EventHandler(this.trainChangeObjButton_Click);
            // 
            // trainWeeksGone
            // 
            this.trainWeeksGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainWeeksGone.Location = new System.Drawing.Point(278, 20);
            this.trainWeeksGone.Name = "trainWeeksGone";
            this.trainWeeksGone.Size = new System.Drawing.Size(47, 67);
            this.trainWeeksGone.TabIndex = 25;
            this.trainWeeksGone.Text = "0";
            // 
            // tabFootball
            // 
            this.tabFootball.Controls.Add(this.panel2);
            this.tabFootball.Controls.Add(this.footStatsMini);
            this.tabFootball.Controls.Add(this.footDaysGone);
            this.tabFootball.Controls.Add(this.label43);
            this.tabFootball.Controls.Add(this.footMonthRequired);
            this.tabFootball.Controls.Add(this.footMonthGone);
            this.tabFootball.Controls.Add(this.label45);
            this.tabFootball.Controls.Add(this.label52);
            this.tabFootball.Controls.Add(this.footDaysRequired);
            this.tabFootball.Controls.Add(this.label51);
            this.tabFootball.Controls.Add(this.label47);
            this.tabFootball.Controls.Add(this.footStartButton);
            this.tabFootball.Controls.Add(this.label48);
            this.tabFootball.Controls.Add(this.footWeeksRequired);
            this.tabFootball.Controls.Add(this.footDetailedButton);
            this.tabFootball.Controls.Add(this.footChangeObjButton);
            this.tabFootball.Controls.Add(this.footWeeksGone);
            this.tabFootball.Location = new System.Drawing.Point(4, 4);
            this.tabFootball.Name = "tabFootball";
            this.tabFootball.Padding = new System.Windows.Forms.Padding(3);
            this.tabFootball.Size = new System.Drawing.Size(667, 337);
            this.tabFootball.TabIndex = 1;
            this.tabFootball.Text = "Футбол";
            this.tabFootball.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(50, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 216);
            this.panel2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Цель не установлена";
            // 
            // footStatsMini
            // 
            this.footStatsMini.Controls.Add(this.label2);
            this.footStatsMini.Controls.Add(this.footTimeSince);
            this.footStatsMini.Controls.Add(this.footSince);
            this.footStatsMini.Controls.Add(this.footTimeFrom);
            this.footStatsMini.Controls.Add(this.footFrom);
            this.footStatsMini.Controls.Add(this.footyouTrainedToday);
            this.footStatsMini.Controls.Add(this.footTrainingTime);
            this.footStatsMini.Location = new System.Drawing.Point(459, 18);
            this.footStatsMini.Name = "footStatsMini";
            this.footStatsMini.Size = new System.Drawing.Size(200, 182);
            this.footStatsMini.TabIndex = 37;
            this.footStatsMini.TabStop = false;
            this.footStatsMini.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дневная цель достигнута!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // footTimeSince
            // 
            this.footTimeSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footTimeSince.Location = new System.Drawing.Point(106, 96);
            this.footTimeSince.Name = "footTimeSince";
            this.footTimeSince.Size = new System.Drawing.Size(39, 17);
            this.footTimeSince.TabIndex = 22;
            this.footTimeSince.Text = "00:00";
            // 
            // footSince
            // 
            this.footSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footSince.Location = new System.Drawing.Point(72, 96);
            this.footSince.Name = "footSince";
            this.footSince.Size = new System.Drawing.Size(28, 17);
            this.footSince.TabIndex = 21;
            this.footSince.Text = "До";
            // 
            // footTimeFrom
            // 
            this.footTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footTimeFrom.Location = new System.Drawing.Point(25, 96);
            this.footTimeFrom.Name = "footTimeFrom";
            this.footTimeFrom.Size = new System.Drawing.Size(41, 17);
            this.footTimeFrom.TabIndex = 20;
            this.footTimeFrom.Text = "00:00";
            // 
            // footFrom
            // 
            this.footFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footFrom.Location = new System.Drawing.Point(6, 96);
            this.footFrom.Name = "footFrom";
            this.footFrom.Size = new System.Drawing.Size(126, 17);
            this.footFrom.TabIndex = 19;
            this.footFrom.Text = "С";
            // 
            // footyouTrainedToday
            // 
            this.footyouTrainedToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footyouTrainedToday.Location = new System.Drawing.Point(6, 17);
            this.footyouTrainedToday.Name = "footyouTrainedToday";
            this.footyouTrainedToday.Size = new System.Drawing.Size(126, 36);
            this.footyouTrainedToday.TabIndex = 17;
            this.footyouTrainedToday.Text = "Сегодня ты тренировался:";
            // 
            // footTrainingTime
            // 
            this.footTrainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footTrainingTime.Location = new System.Drawing.Point(6, 53);
            this.footTrainingTime.Name = "footTrainingTime";
            this.footTrainingTime.Size = new System.Drawing.Size(126, 16);
            this.footTrainingTime.TabIndex = 18;
            this.footTrainingTime.Text = "00:00:00";
            // 
            // footDaysGone
            // 
            this.footDaysGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footDaysGone.Location = new System.Drawing.Point(46, 18);
            this.footDaysGone.Name = "footDaysGone";
            this.footDaysGone.Size = new System.Drawing.Size(47, 67);
            this.footDaysGone.TabIndex = 22;
            this.footDaysGone.Text = "0";
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(285, 184);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 16);
            this.label43.TabIndex = 36;
            this.label43.Text = "месяцев";
            this.label43.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // footMonthRequired
            // 
            this.footMonthRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footMonthRequired.Location = new System.Drawing.Point(256, 163);
            this.footMonthRequired.Name = "footMonthRequired";
            this.footMonthRequired.Size = new System.Drawing.Size(23, 37);
            this.footMonthRequired.TabIndex = 29;
            this.footMonthRequired.Text = "0";
            this.footMonthRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // footMonthGone
            // 
            this.footMonthGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footMonthGone.Location = new System.Drawing.Point(182, 135);
            this.footMonthGone.Name = "footMonthGone";
            this.footMonthGone.Size = new System.Drawing.Size(47, 67);
            this.footMonthGone.TabIndex = 28;
            this.footMonthGone.Text = "0";
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.Location = new System.Drawing.Point(379, 69);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(56, 16);
            this.label45.TabIndex = 35;
            this.label45.Text = "недель";
            this.label45.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.Location = new System.Drawing.Point(235, 163);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(15, 37);
            this.label52.TabIndex = 30;
            this.label52.Text = "/";
            this.label52.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // footDaysRequired
            // 
            this.footDaysRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footDaysRequired.Location = new System.Drawing.Point(120, 46);
            this.footDaysRequired.Name = "footDaysRequired";
            this.footDaysRequired.Size = new System.Drawing.Size(23, 37);
            this.footDaysRequired.TabIndex = 23;
            this.footDaysRequired.Text = "0";
            this.footDaysRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.Location = new System.Drawing.Point(331, 46);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(15, 37);
            this.label51.TabIndex = 27;
            this.label51.Text = "/";
            this.label51.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.Location = new System.Drawing.Point(149, 69);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 16);
            this.label47.TabIndex = 34;
            this.label47.Text = "днейднейдней";
            this.label47.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // footStartButton
            // 
            this.footStartButton.Location = new System.Drawing.Point(195, 240);
            this.footStartButton.Name = "footStartButton";
            this.footStartButton.Size = new System.Drawing.Size(154, 50);
            this.footStartButton.TabIndex = 31;
            this.footStartButton.Text = "Начать тренировку";
            this.footStartButton.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.Location = new System.Drawing.Point(99, 46);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(15, 37);
            this.label48.TabIndex = 24;
            this.label48.Text = "/";
            this.label48.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // footWeeksRequired
            // 
            this.footWeeksRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footWeeksRequired.Location = new System.Drawing.Point(352, 46);
            this.footWeeksRequired.Name = "footWeeksRequired";
            this.footWeeksRequired.Size = new System.Drawing.Size(23, 37);
            this.footWeeksRequired.TabIndex = 26;
            this.footWeeksRequired.Text = "0";
            this.footWeeksRequired.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // footDetailedButton
            // 
            this.footDetailedButton.Location = new System.Drawing.Point(584, 267);
            this.footDetailedButton.Name = "footDetailedButton";
            this.footDetailedButton.Size = new System.Drawing.Size(75, 23);
            this.footDetailedButton.TabIndex = 33;
            this.footDetailedButton.Text = "Подробно";
            this.footDetailedButton.UseVisualStyleBackColor = true;
            // 
            // footChangeObjButton
            // 
            this.footChangeObjButton.Location = new System.Drawing.Point(550, 296);
            this.footChangeObjButton.Name = "footChangeObjButton";
            this.footChangeObjButton.Size = new System.Drawing.Size(109, 30);
            this.footChangeObjButton.TabIndex = 32;
            this.footChangeObjButton.Text = "Изменить цели";
            this.footChangeObjButton.UseVisualStyleBackColor = true;
            // 
            // footWeeksGone
            // 
            this.footWeeksGone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footWeeksGone.Location = new System.Drawing.Point(278, 18);
            this.footWeeksGone.Name = "footWeeksGone";
            this.footWeeksGone.Size = new System.Drawing.Size(47, 67);
            this.footWeeksGone.TabIndex = 25;
            this.footWeeksGone.Text = "0";
            // 
            // TrainKindLabel
            // 
            this.TrainKindLabel.AutoSize = true;
            this.TrainKindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainKindLabel.Location = new System.Drawing.Point(12, 17);
            this.TrainKindLabel.Name = "TrainKindLabel";
            this.TrainKindLabel.Size = new System.Drawing.Size(284, 31);
            this.TrainKindLabel.TabIndex = 2;
            this.TrainKindLabel.Text = "Обычные тренировки";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 420);
            this.Controls.Add(this.TrainKindLabel);
            this.Controls.Add(this.mainFrame);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainFrame.ResumeLayout(false);
            this.tabTraining.ResumeLayout(false);
            this.trCoverPanel.ResumeLayout(false);
            this.trCoverPanel.PerformLayout();
            this.trainTrainStatsMini.ResumeLayout(false);
            this.tabFootball.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.footStatsMini.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainFrame;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.TabPage tabFootball;
        private System.Windows.Forms.GroupBox trainTrainStatsMini;
        private System.Windows.Forms.Label trainTodayToTime;
        private System.Windows.Forms.Label trainTodaySince;
        private System.Windows.Forms.Label trainTodayFromTime;
        private System.Windows.Forms.Label trainTodayFrom;
        private System.Windows.Forms.Label trainYouTrainedLabel;
        private System.Windows.Forms.Label trainTimeToday;
        private System.Windows.Forms.Label trainDaysGone;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label trainMonthRequired;
        private System.Windows.Forms.Label trainMonthGone;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label trainDaysRequired;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button trainStartButton;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label trainWeeksRequired;
        private System.Windows.Forms.Button trainDetailedButton;
        private System.Windows.Forms.Button trainChangeObjButton;
        private System.Windows.Forms.Label trainWeeksGone;
        private System.Windows.Forms.GroupBox footStatsMini;
        private System.Windows.Forms.Label footTimeSince;
        private System.Windows.Forms.Label footSince;
        private System.Windows.Forms.Label footTimeFrom;
        private System.Windows.Forms.Label footFrom;
        private System.Windows.Forms.Label footyouTrainedToday;
        private System.Windows.Forms.Label footTrainingTime;
        private System.Windows.Forms.Label footDaysGone;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label footMonthRequired;
        private System.Windows.Forms.Label footMonthGone;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label footDaysRequired;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button footStartButton;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label footWeeksRequired;
        private System.Windows.Forms.Button footDetailedButton;
        private System.Windows.Forms.Button footChangeObjButton;
        private System.Windows.Forms.Label footWeeksGone;
        private System.Windows.Forms.Label TrainKindLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel trCoverPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}

