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
        Size frameSize;
        TimeSpan daily, timeGone;
        trainerBase.TrainKind trainKind;
        
        public onTrainingFrame(trainerBase.TrainKind kind)
        {
            InitializeComponent();
            trainKind = kind;
            timeGone = new TimeSpan(0, 0, 0);
            frameSize = Size;
        }
        

        private void trainFrame_Load(object sender, EventArgs e)
        {
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                if (!trainerBase.PE.TrainedToday)
                {
                    trainerBase.PE.obMonthly.Completed++;
                    trainerBase.PE.TrainedToday = true;
                }
                timeRemaining.Visible = trainerBase.PE.HasObjective;
                daily = trainerBase.PE.obDaily.Required;
            }

            else
            {
                if (!trainerBase.Football.TrainedToday)
                {
                    trainerBase.Football.obMonthly.Completed++;
                    trainerBase.Football.TrainedToday = true;
                }
                timeRemaining.Visible = trainerBase.Football.HasObjective;
                daily = trainerBase.Football.obDaily.Required;
            }

            motivationLabel.Text = "Не сдавайся!";
            updateTimer.Start();
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                trainerBase.PE.StopTraining();
                
            }
            else
            {
                trainerBase.Football.StopTraining();
            }

            updateTimer.Stop();

        }

        private void onTrainingFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                trainerBase.PE.StopTraining();

            }
            else
            {
                trainerBase.Football.StopTraining();
            }

            updateTimer.Stop();
        }

        private void onTrainingFrame_SizeChanged(object sender, EventArgs e)
        {
            Size = frameSize;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            timeGone = timeGone.Add(new TimeSpan(0, 0, 1));
            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                trainerBase.PE.CurrentTime = trainerBase.PE.CurrentTime.Add(new TimeSpan(0, 0, 1));
                trainerBase.PE.obDaily.Completed += new TimeSpan(0, 0, 1);


                currentTime.Text = "Ты тренируешься уже " + timeGone.ToString();
                if (trainerBase.PE.HasObjective)
                {
                    if (trainerBase.PE.CurrentTime >= daily)
                    {
                        timeRemaining.Text = "Дневная цель достигнута!";
                        motivationLabel.Text = "Молодец!";
                    }
                    else
                        timeRemaining.Text = "Осталось " + (trainerBase.PE.obDaily.Required - trainerBase.PE.obDaily.Completed) + " для достижения цели на день";

                   // Console.WriteLine("H: " + trainerBase.phEd.CurrentTime + " " + trainerBase.phEd.DailyObj);
                }
            }
            else
            {
                trainerBase.Football.CurrentTime = trainerBase.Football.CurrentTime.Add(new TimeSpan(0, 0, 1));
                trainerBase.Football.obDaily.Completed += new TimeSpan(0, 0, 1);


                currentTime.Text = "Ты тренируешься уже " + timeGone.ToString();
                if (trainerBase.Football.HasObjective)
                {
                    if (trainerBase.Football.CurrentTime >= daily)
                    {
                        timeRemaining.Text = "Дневная цель достигнута!";
                        motivationLabel.Text = "Молодец!";
                    }
                    else
                        timeRemaining.Text = "Осталось " + (trainerBase.Football.obDaily.Required - trainerBase.Football.obDaily.Completed) + " для достижения цели на день";

                }
            }
        }
    }
}
