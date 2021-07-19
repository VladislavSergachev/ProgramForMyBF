
namespace MyTrainer
{
    partial class onTrainingFrame
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.timeRemaining = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.motivationLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тренируемся...";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTime.Location = new System.Drawing.Point(49, 54);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(284, 24);
            this.currentTime.TabIndex = 4;
            this.currentTime.Text = "Ты тренируешься уже 00:00:00";
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRemaining.Location = new System.Drawing.Point(49, 106);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(449, 24);
            this.timeRemaining.TabIndex = 6;
            this.timeRemaining.Text = "Осталось 00:00:00 для достижения цели на день";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.currentTime);
            this.panel1.Controls.Add(this.timeRemaining);
            this.panel1.Location = new System.Drawing.Point(18, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 172);
            this.panel1.TabIndex = 9;
            // 
            // motivationLabel
            // 
            this.motivationLabel.AutoSize = true;
            this.motivationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motivationLabel.Location = new System.Drawing.Point(203, 261);
            this.motivationLabel.Name = "motivationLabel";
            this.motivationLabel.Size = new System.Drawing.Size(194, 31);
            this.motivationLabel.TabIndex = 10;
            this.motivationLabel.Text = "Не сдавайся!";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(260, 310);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(83, 38);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Хватит";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // onTrainingFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 360);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.motivationLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "onTrainingFrame";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onTrainingFrame_FormClosing);
            this.Load += new System.EventHandler(this.trainFrame_Load);
            this.SizeChanged += new System.EventHandler(this.onTrainingFrame_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label currentTime;
        public System.Windows.Forms.Label timeRemaining;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label motivationLabel;
        public System.Windows.Forms.Button stopButton;
        public System.Windows.Forms.Timer updateTimer;
    }
}