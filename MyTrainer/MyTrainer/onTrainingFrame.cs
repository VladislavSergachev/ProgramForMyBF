using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTrainer
{
    public partial class onTrainingFrame : Form
    {
        TimeSpan timeLeft;
        public onTrainingFrame()
        {
            InitializeComponent();
        }
        

        private void trainFrame_Load(object sender, EventArgs e)
        {
            timeLeft = new TimeSpan();
            
            updateTimer.Start();

            
            
            trainerBase.CurrentTime = new TimeSpan(0, 0, 0);
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            trainerBase.StopTraining();
            
            updateTimer.Stop();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            trainerBase.CurrentTime = trainerBase.CurrentTime.Add(new TimeSpan(0, 0, 1));
            trainerBase.Objective.Daily -= new TimeSpan(0, 0, 1);

            Console.WriteLine(trainerBase.CurrentTime);

            currentTime.Text = "Ты тренируешься уже " + trainerBase.CurrentTime;
            timeRemaining.Text = "Осталось " + trainerBase.Objective.Daily + " для достижения цели на день";
        }
    }
}
