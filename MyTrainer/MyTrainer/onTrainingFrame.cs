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
        TimeSpan daily;
        
        public onTrainingFrame()
        {
            InitializeComponent();
        }
        

        private void trainFrame_Load(object sender, EventArgs e)
        {
            timeRemaining.Visible = trainerBase.phEd.Objective.HasObjective;
            updateTimer.Start();
            daily = trainerBase.phEd.Objective.Daily;
            motivationLabel.Text = "Не сдавайся!";
            

            trainerBase.phEd.CurrentTime = new TimeSpan(0, 0, 0);
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            trainerBase.phEd.StopTraining();
            
            updateTimer.Stop();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            trainerBase.phEd.CurrentTime = trainerBase.phEd.CurrentTime.Add(new TimeSpan(0, 0, 1));
            trainerBase.phEd.Objective.Daily -= new TimeSpan(0, 0, 1);

            Console.WriteLine(trainerBase.phEd.CurrentTime);

            currentTime.Text = "Ты тренируешься уже " + trainerBase.phEd.CurrentTime;
            if (trainerBase.phEd.Objective.HasObjective)
            {
                if (trainerBase.phEd.CurrentTime >= daily)
                {
                    timeRemaining.Text = "Дневная цель достигнута!";
                    motivationLabel.Text = "Молодец!";
                }
                else
                    timeRemaining.Text = "Осталось " + trainerBase.phEd.Objective.Daily + " для достижения цели на день";

                Console.WriteLine("H: " + trainerBase.phEd.CurrentTime + " " + trainerBase.phEd.Objective.Daily);
            }
        }
    }
}
