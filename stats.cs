using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MyTrainer
{
    public partial class stats : Form
    {
        trainerBase.ExersicePE actualObjectPE;
        trainerBase.ExersiceFootball actualObjectFootball;
        trainerBase.TrainKind tKind;
        Size frameSize;

        public stats(trainerBase.TrainKind kind)
        {
            InitializeComponent();

            tKind = kind;
            frameSize = Size;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            trainerBase.MainFrame.Show();
        }

        private void statCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (tKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                if (e.Start == DateTime.Today)
                {
                    bWasTraining.Text = (trainerBase.PE.TrainedToday) ? "Да" : "Нет";
                    stBeginTime.Text = (trainerBase.PE.TrainedToday) ? trainerBase.PE.BeginTime.ToLongTimeString() : "Н/Д";
                    stEndTime.Text = (trainerBase.PE.TrainedToday) ? trainerBase.PE.EndTime.ToLongTimeString() : "Н/Д";
                    stTimePassed.Text = (trainerBase.PE.TrainedToday) ? trainerBase.PE.CurrentTime.ToString() : "Н/Д";


                    dailyObjWasReached.Text = (trainerBase.PE.obDaily.Completed >= trainerBase.PE.obDaily.Required) ? "Да" : "Нет";
                }
                else
                {
                    for (int i = 0; i < trainerBase._datesCal.Length; i++)
                    {
                        if (e.Start == trainerBase._datesCal[i])
                        {
                            actualObjectPE = JsonConvert.DeserializeObject<trainerBase.ExersicePE>(trainerBase._stData[i]);
                            bWasTraining.Text = "Да";
                            stBeginTime.Text = actualObjectPE.BeginTime.ToLongTimeString();
                            stEndTime.Text = actualObjectPE.EndTime.ToLongTimeString();
                            stTimePassed.Text = actualObjectPE.CurrentTime.ToString();

                            dailyObjWasReached.Text = (actualObjectPE.obDaily.Required >= actualObjectPE.obDaily.Completed) ? "Да" : "Нет";
                            break;
                        }

                        if (!trainerBase._datesCal.Contains(e.Start))
                        {
                            bWasTraining.Text = "Нет";
                            stBeginTime.Text = "Н/Д";
                            stEndTime.Text = "Н/Д";
                            stTimePassed.Text = "Н/Д";

                            dailyObjWasReached.Text = "Н/Д";
                            break;
                        }
                    }
                }

            }
            else
            {
                if (e.Start == DateTime.Today)
                {
                    bWasTraining.Text = (trainerBase.Football.TrainedToday) ? "Да" : "Нет";
                    stBeginTime.Text = (trainerBase.Football.TrainedToday) ? trainerBase.Football.BeginTime.ToLongTimeString() : "Н/Д";
                    stEndTime.Text = (trainerBase.Football.TrainedToday) ? trainerBase.Football.EndTime.ToLongTimeString() : "Н/Д";
                    stTimePassed.Text = (trainerBase.Football.TrainedToday) ? trainerBase.Football.CurrentTime.ToString() : "Н/Д";


                    dailyObjWasReached.Text = (trainerBase.Football.obDaily.Completed >= trainerBase.Football.obDaily.Required) ? "Да" : "Нет";
                }
                else
                {
                    for (int i = 0; i < trainerBase._datesCal.Length; i++)
                    {
                        if (e.Start == trainerBase._datesCal[i])
                        {
                            actualObjectFootball = JsonConvert.DeserializeObject<trainerBase.ExersiceFootball>(trainerBase._stData[i]);
                            bWasTraining.Text = "Да";
                            stBeginTime.Text = actualObjectFootball.BeginTime.ToLongTimeString();
                            stEndTime.Text = actualObjectFootball.EndTime.ToLongTimeString();
                            stTimePassed.Text = actualObjectFootball.CurrentTime.ToString();

                            dailyObjWasReached.Text = (actualObjectFootball.obDaily.Required >= actualObjectFootball.obDaily.Completed) ? "Да" : "Нет";
                            break;
                        }

                        if (!trainerBase._datesCal.Contains(e.Start))
                        {
                            bWasTraining.Text = "Нет";
                            stBeginTime.Text = "Н/Д";
                            stEndTime.Text = "Н/Д";
                            stTimePassed.Text = "Н/Д";

                            dailyObjWasReached.Text = "Н/Д";
                            break;
                        }
                    }

                }
            }
        }

        private void stats_SizeChanged(object sender, EventArgs e)
        {
            Size = frameSize;
        }
    }
}
