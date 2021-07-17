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
            
        }

        private void trainStartButton_Click(object sender, EventArgs e)
        {
            trainerBase.PE.StartTraining();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            trainerBase.RestoreValues();
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
            trainerBase.PE.OpenObjWindow();
            trainerBase.MainFrame.Enabled = false;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            trStatCoverPanel.Visible = trainerBase.PE.CurrentTime.Equals(new TimeSpan(0, 0, 0)) ? true : false;
            fbStatCoverPanel.Visible = trainerBase.Football.CurrentTime.Equals(new TimeSpan(0, 0, 0)) ? true : false;

            trCoverPanel.Visible = !trainerBase.PE.HasObjective;
            fbCoverPanel.Visible = !trainerBase.Football.HasObjective;

            trainTimeToday.Text = trainerBase.PE.CurrentTime.ToString();
            footTrainingTime.Text = trainerBase.Football.CurrentTime.ToString();

            trainTodayFromTime.Text = trainerBase.PE.BeginTime.ToShortTimeString();
            trainTodaySinceTime.Text = trainerBase.PE.EndTime.ToShortTimeString();

            footTimeFrom.Text = trainerBase.Football.BeginTime.ToShortTimeString();
            footTimeSince.Text = trainerBase.Football.EndTime.ToShortTimeString();

          //  Console.WriteLine("PE BeginTime " + trainerBase.PE.BeginTime);
          //  Console.WriteLine("PE EndTime " + trainerBase.PE.EndTime);
          //  Console.WriteLine("FB BeginTime " + trainerBase.Football.BeginTime);
          //  Console.WriteLine("FB EndTime " + trainerBase.Football.EndTime);
           Console.WriteLine("DateTime.Today " + DateTime.Today);

        }

        private void footStartButton_Click(object sender, EventArgs e)
        {
            trainerBase.Football.StartTraining();
        }

        private void footChangeObjButton_Click(object sender, EventArgs e)
        {
            trainerBase.Football.OpenObjWindow();
        }

        private void fbStatCoverPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            trainerBase.SaveValues();
        }

        private void trainDetailedButton_Click(object sender, EventArgs e)
        {
            trainerBase.PE.OpenStatsWindow();
        }

        private void footDetailedButton_Click(object sender, EventArgs e)
        {
            trainerBase.Football.OpenStatsWindow();
        }
    }
}
