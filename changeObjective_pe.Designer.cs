
namespace MyTrainer
{
    partial class changeObjective_pe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeObjective_pe));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthsPerYear = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.daysPerMonth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secondsPerDay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.minutesPerDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursPerDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.applyObjButton = new System.Windows.Forms.Button();
            this.hasObjective = new System.Windows.Forms.CheckBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsPerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysPerMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.monthsPerYear);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.daysPerMonth);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.secondsPerDay);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.minutesPerDay);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.hoursPerDay);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 194);
            this.mainPanel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(22, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Твоя цель на век.. Ну, ладно, шучу :)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(195, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "месяцев в год";
            // 
            // monthsPerYear
            // 
            this.monthsPerYear.Location = new System.Drawing.Point(155, 118);
            this.monthsPerYear.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthsPerYear.Name = "monthsPerYear";
            this.monthsPerYear.Size = new System.Drawing.Size(34, 20);
            this.monthsPerYear.TabIndex = 14;
            this.monthsPerYear.ValueChanged += new System.EventHandler(this.monthsPerYear_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(22, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Твоя цель на год";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(224, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "дней в месяц";
            // 
            // daysPerMonth
            // 
            this.daysPerMonth.Location = new System.Drawing.Point(174, 71);
            this.daysPerMonth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.daysPerMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysPerMonth.Name = "daysPerMonth";
            this.daysPerMonth.Size = new System.Drawing.Size(34, 20);
            this.daysPerMonth.TabIndex = 11;
            this.daysPerMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysPerMonth.ValueChanged += new System.EventHandler(this.daysPerMonth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Твоя цель на месяц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(394, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "секунд";
            // 
            // secondsPerDay
            // 
            this.secondsPerDay.Location = new System.Drawing.Point(354, 25);
            this.secondsPerDay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsPerDay.Name = "secondsPerDay";
            this.secondsPerDay.Size = new System.Drawing.Size(34, 20);
            this.secondsPerDay.TabIndex = 6;
            this.secondsPerDay.ValueChanged += new System.EventHandler(this.secondsPerDay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(299, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "минут";
            // 
            // minutesPerDay
            // 
            this.minutesPerDay.Location = new System.Drawing.Point(259, 25);
            this.minutesPerDay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesPerDay.Name = "minutesPerDay";
            this.minutesPerDay.Size = new System.Drawing.Size(34, 20);
            this.minutesPerDay.TabIndex = 4;
            this.minutesPerDay.ValueChanged += new System.EventHandler(this.minutesPerDay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(204, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "часов";
            // 
            // hoursPerDay
            // 
            this.hoursPerDay.Location = new System.Drawing.Point(164, 25);
            this.hoursPerDay.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hoursPerDay.Name = "hoursPerDay";
            this.hoursPerDay.Size = new System.Drawing.Size(34, 20);
            this.hoursPerDay.TabIndex = 1;
            this.hoursPerDay.ValueChanged += new System.EventHandler(this.hoursPerDay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Твоя цель на день";
            // 
            // applyObjButton
            // 
            this.applyObjButton.Location = new System.Drawing.Point(713, 230);
            this.applyObjButton.Name = "applyObjButton";
            this.applyObjButton.Size = new System.Drawing.Size(75, 23);
            this.applyObjButton.TabIndex = 2;
            this.applyObjButton.Text = "Готово";
            this.applyObjButton.UseVisualStyleBackColor = true;
            this.applyObjButton.Click += new System.EventHandler(this.applyObjButton_Click);
            // 
            // hasObjective
            // 
            this.hasObjective.AutoSize = true;
            this.hasObjective.Checked = true;
            this.hasObjective.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hasObjective.Location = new System.Drawing.Point(12, 234);
            this.hasObjective.Name = "hasObjective";
            this.hasObjective.Size = new System.Drawing.Size(150, 17);
            this.hasObjective.TabIndex = 3;
            this.hasObjective.Text = "Я хочу задать себе цель";
            this.hasObjective.UseVisualStyleBackColor = true;
            this.hasObjective.CheckedChanged += new System.EventHandler(this.hasObjective_CheckedChanged);
            // 
            // changeObjective_pe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.hasObjective);
            this.Controls.Add(this.applyObjButton);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "changeObjective_pe";
            this.Text = "Изменить цель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onChangeFrameClose);
            this.SizeChanged += new System.EventHandler(this.changeFrameSized);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsPerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysPerMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown hoursPerDay;
        public System.Windows.Forms.NumericUpDown monthsPerYear;
        public System.Windows.Forms.NumericUpDown daysPerMonth;
        public System.Windows.Forms.NumericUpDown secondsPerDay;
        public System.Windows.Forms.NumericUpDown minutesPerDay;
        public System.Windows.Forms.Button applyObjButton;
        private System.Windows.Forms.CheckBox hasObjective;
        public System.Windows.Forms.Panel mainPanel;
    }
}