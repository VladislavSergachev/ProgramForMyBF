
namespace MyTrainer
{
    partial class stats
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
            this.statCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bWasTraining = new System.Windows.Forms.Label();
            this.stTimePassed = new System.Windows.Forms.Label();
            this.stBeginTime = new System.Windows.Forms.Label();
            this.stEndTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dailyObjWasReached = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statCalendar
            // 
            this.statCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.statCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.statCalendar.Location = new System.Drawing.Point(18, 18);
            this.statCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.statCalendar.MaxSelectionCount = 1;
            this.statCalendar.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.statCalendar.Name = "statCalendar";
            this.statCalendar.TabIndex = 0;
            this.statCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.statCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тренировался:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начало:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конец:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Затраченное время";
            // 
            // bWasTraining
            // 
            this.bWasTraining.AutoSize = true;
            this.bWasTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bWasTraining.Location = new System.Drawing.Point(453, 18);
            this.bWasTraining.Name = "bWasTraining";
            this.bWasTraining.Size = new System.Drawing.Size(24, 13);
            this.bWasTraining.TabIndex = 5;
            this.bWasTraining.Text = "Да";
            // 
            // stTimePassed
            // 
            this.stTimePassed.AutoSize = true;
            this.stTimePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stTimePassed.Location = new System.Drawing.Point(125, 116);
            this.stTimePassed.Name = "stTimePassed";
            this.stTimePassed.Size = new System.Drawing.Size(57, 13);
            this.stTimePassed.TabIndex = 6;
            this.stTimePassed.Text = "00:00:00";
            // 
            // stBeginTime
            // 
            this.stBeginTime.AutoSize = true;
            this.stBeginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stBeginTime.Location = new System.Drawing.Point(56, 149);
            this.stBeginTime.Name = "stBeginTime";
            this.stBeginTime.Size = new System.Drawing.Size(39, 13);
            this.stBeginTime.TabIndex = 7;
            this.stBeginTime.Text = "00:00";
            // 
            // stEndTime
            // 
            this.stEndTime.AutoSize = true;
            this.stEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stEndTime.Location = new System.Drawing.Point(50, 183);
            this.stEndTime.Name = "stEndTime";
            this.stEndTime.Size = new System.Drawing.Size(39, 13);
            this.stEndTime.TabIndex = 8;
            this.stEndTime.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dailyObjWasReached);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.stEndTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stBeginTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stTimePassed);
            this.panel1.Location = new System.Drawing.Point(364, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 294);
            this.panel1.TabIndex = 9;
            // 
            // dailyObjWasReached
            // 
            this.dailyObjWasReached.AutoSize = true;
            this.dailyObjWasReached.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dailyObjWasReached.Location = new System.Drawing.Point(179, 213);
            this.dailyObjWasReached.Name = "dailyObjWasReached";
            this.dailyObjWasReached.Size = new System.Drawing.Size(24, 13);
            this.dailyObjWasReached.TabIndex = 11;
            this.dailyObjWasReached.Text = "Да";
            this.dailyObjWasReached.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дневная цель была достигнута:";
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bWasTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statCalendar);
            this.MaximizeBox = false;
            this.Name = "stats";
            this.Text = "stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.stats_FormClosing);
            this.SizeChanged += new System.EventHandler(this.stats_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar statCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bWasTraining;
        private System.Windows.Forms.Label stTimePassed;
        private System.Windows.Forms.Label stBeginTime;
        private System.Windows.Forms.Label stEndTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dailyObjWasReached;
        private System.Windows.Forms.Label label6;
    }
}