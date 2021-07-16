// TIMER

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
    public partial class MainWindow : Form
    {
        stats stat;
        public MainWindow()
        {
            InitializeComponent();
            stat = new stats()
            {
                Visible = true
            };
        }

        private void trainStartButton_Click(object sender, EventArgs e)
        {
            trainerBase.phEd.StartTraining();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void trainTabSelected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    {
                        TrainKindLabel.Text = "Обычные тренировки";
                        break;
                    }
                case 1:
                    {
                        TrainKindLabel.Text = "Тренировки по футболу";
                        break;
                    }
            }
                

        }

        private void trainChangeObjButton_Click(object sender, EventArgs e)
        {
            trainerBase.phEd.Objective.OpenWindow();
            trainerBase.MainFrame.Enabled = false;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            trStatCoverPanel.Visible = trainerBase.phEd.CurrentTime.Equals(new TimeSpan(0, 0, 0)) ? true : false;
            fbStatCoverPanel.Visible = trainerBase.Football.CurrentTime.Equals(new TimeSpan(0, 0, 0)) ? true : false;

            trCoverPanel.Visible = !trainerBase.phEd.Objective.HasObjective;
            fbCoverPanel.Visible = !trainerBase.Football.Objective.HasObjective;

            trainTimeToday.Text = trainerBase.phEd.CurrentTime.ToString();
            footTrainingTime.Text = trainerBase.Football.CurrentTime.ToString();

            trainTodayFromTime.Text = trainerBase.phEd.BeginTime.ToShortTimeString();
            trainTodaySinceTime.Text = trainerBase.phEd.EndTime.ToShortTimeString();

            footTimeFrom.Text = trainerBase.Football.BeginTime.ToShortTimeString();
            footTimeSince.Text = trainerBase.Football.EndTime.ToShortTimeString();

            Console.WriteLine("PE BeginTime " + trainerBase.phEd.BeginTime);
            Console.WriteLine("PE EndTime " + trainerBase.phEd.EndTime);
            Console.WriteLine("FB BeginTime " + trainerBase.Football.BeginTime);
            Console.WriteLine("FB EndTime " + trainerBase.Football.EndTime);
            Console.WriteLine("DateTime.Now " + DateTime.Now);

        }

        private void footStartButton_Click(object sender, EventArgs e)
        {
            trainerBase.Football.StartTraining();
        }

        private void footChangeObjButton_Click(object sender, EventArgs e)
        {
            trainerBase.Football.Objective.OpenWindow();
        }

        private void fbStatCoverPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
