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
        TimeSpan daily, timeGone;
        trainerBase.TrainKind trainKind;
        
        public onTrainingFrame(trainerBase.TrainKind kind)
        {
            InitializeComponent();
            trainKind = kind;
            timeGone = new TimeSpan(0, 0, 0);
        }
        

        private void trainFrame_Load(object sender, EventArgs e)
        {
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                Console.WriteLine("Started PE session.\n");
                timeRemaining.Visible = trainerBase.phEd.Objective.HasObjective;
                daily = trainerBase.phEd.Objective.Daily;
                
                //trainerBase.phEd.CurrentTime = new TimeSpan(0, 0, 0);
            }

            else
            {
                Console.WriteLine("Started Football session.\n");
                timeRemaining.Visible = trainerBase.Football.Objective.HasObjective;
                daily = trainerBase.Football.Objective.Daily;
                //trainerBase.Football.CurrentTime = new TimeSpan(0, 0, 0);
            }

            motivationLabel.Text = "Не сдавайся!";
            updateTimer.Start();
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                trainerBase.phEd.StopTraining();
                
            }
            else
            {
                trainerBase.Football.StopTraining();
            }

            updateTimer.Stop();

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            timeGone = timeGone.Add(new TimeSpan(0, 0, 1));
            Console.WriteLine(timeGone.ToString());
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                trainerBase.phEd.CurrentTime = trainerBase.phEd.CurrentTime.Add(new TimeSpan(0, 0, 1));
                trainerBase.phEd.Objective.Daily -= new TimeSpan(0, 0, 1);

                Console.WriteLine("time: " + trainerBase.phEd.CurrentTime);

                currentTime.Text = "Ты тренируешься уже " + timeGone.ToString();
                if (trainerBase.phEd.Objective.HasObjective)
                {
                    if (trainerBase.phEd.CurrentTime >= daily)
                    {
                        timeRemaining.Text = "Дневная цель достигнута!";
                        motivationLabel.Text = "Молодец!";
                    }
                    else
                        timeRemaining.Text = "Осталось " + trainerBase.phEd.Objective.Daily + " для достижения цели на день";

                   // Console.WriteLine("H: " + trainerBase.phEd.CurrentTime + " " + trainerBase.phEd.Objective.Daily);
                }
            }
            else
            {
                trainerBase.Football.CurrentTime = trainerBase.Football.CurrentTime.Add(new TimeSpan(0, 0, 1));
                trainerBase.Football.Objective.Daily -= new TimeSpan(0, 0, 1);

                Console.WriteLine("time " + trainerBase.Football.CurrentTime);

                currentTime.Text = "Ты тренируешься уже " + timeGone.ToString();
                if (trainerBase.Football.Objective.HasObjective)
                {
                    if (trainerBase.Football.CurrentTime >= daily)
                    {
                        timeRemaining.Text = "Дневная цель достигнута!";
                        motivationLabel.Text = "Молодец!";
                    }
                    else
                        timeRemaining.Text = "Осталось " + trainerBase.Football.Objective.Daily + " для достижения цели на день";

                }
            }
        }
    }
}
