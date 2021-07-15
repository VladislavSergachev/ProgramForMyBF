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
        public MainWindow()
        {
            InitializeComponent();
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
            trCoverPanel.Visible = !trainerBase.phEd.Objective.HasObjective;
        }
    }
}
