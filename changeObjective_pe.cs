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
    public partial class changeObjective_pe : Form
    {
        public Size frameSize;
        public bool isAnyValChanged = false;
        public trainerBase.TrainKind kind;


        bool zerotime_condition;

        public changeObjective_pe(trainerBase.TrainKind kindOfTrain)
        {
            InitializeComponent();
            frameSize = Size;

            kind = kindOfTrain;

            if (kind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                hasObjective.Checked = trainerBase.PE.HasObjective;
                hoursPerDay.Value = trainerBase.PE.obDaily.Required.Hours;
                minutesPerDay.Value = trainerBase.PE.obDaily.Required.Minutes;
                secondsPerDay.Value = trainerBase.PE.obDaily.Required.Seconds;
                daysPerMonth.Value = !(trainerBase.Football.obMonthly.Required <= 0) ? trainerBase.Football.obMonthly.Required : 1;
                monthsPerYear.Value = trainerBase.PE.obAnnually.Required;
            }
            else
            {
                hasObjective.Checked = trainerBase.Football.HasObjective;
                hoursPerDay.Value = trainerBase.Football.obDaily.Required.Hours;
                minutesPerDay.Value = trainerBase.Football.obDaily.Required.Minutes;
                secondsPerDay.Value = trainerBase.Football.obDaily.Required.Seconds;
                daysPerMonth.Value = !(trainerBase.Football.obMonthly.Required <= 0) ? trainerBase.Football.obMonthly.Required : 1;
                monthsPerYear.Value = trainerBase.Football.obAnnually.Required;
            }

        }

        private void applyObjButton_Click(object sender, EventArgs e)
        {
            objFrameCloseHandler(kind);
        }

        private void changeFrameSized(object sender, EventArgs e)
        {
            Size = frameSize;
        }

        private void onChangeFrameClose(object sender, FormClosingEventArgs e)
        {
            objFrameCloseHandler(kind);
        }

        public void objFrameCloseHandler(trainerBase.TrainKind trainKind)
        {
            zerotime_condition =
            minutesPerDay.Value == 0 &&
            hoursPerDay.Value == 0 &&
            secondsPerDay.Value == 0;




            if (trainKind.Equals(trainerBase.TrainKind.PhysicalEdu))
            {
                if (trainerBase.PE.HasObjective && !hasObjective.Checked)
                {
                    if (MessageBox.Show("Если ты сейчас отключишь функцию \"Цель\", то твои последние достижения будут сброшены. Это не повлияет на Статистику.", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        hasObjective.Checked = true;
                        MessageBox.Show("Достижения не были сброшены", "Всё ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Достижения по тренировкам сброшены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (hasObjective.Checked) // IF USER HAS DAILY/MONTHLY/ANY OBJECTIVE...
                {
                    if (zerotime_condition) // ... THEN CHECK IF TIME SET TO 00:00:00 ...
                    {
                        if (MessageBox.Show("Ты не задал количество времени для занятий. Хочешь отключить эту функцию?", "Задай время", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) /// IF SO THEN NOTIFY USER HE WASN`T SET TARGET TIME AND ASK IF HE WANT TO DO IT.
                        {
                            // IF HE ANSWERS "YES" THEN WE DIRECTLY CHANGE HAS_OBJECTIVE COMBOBOX VALUE TO "FALSE" 
                            hasObjective.Checked = false;
                            zerotime_condition = false; // RESET ZEROTIME_CONDITION TO PREVENT REPEATED FLASHING OF MESSAGEBOX

                            trainerBase.MainFrame.Enabled = true; // UNLOCKING THE MAIN WINDOW
                            trainerBase.PE.CloseObjWindow(); // CLOSE "OBJECTIVE WINDOW"
                        }
                        else
                        {
                            zerotime_condition = false; // IF HE SAYS "NO" WE RESET ZEROTIME_CONDITION (for the same purpose as above) 
                            hasObjective.Checked = true; // SETTING COMBOBOX VALUE TO TRUE AS BY SAYING "NO" USER MEANS THAT HE WANT TO SET SOME OBJECTIVE 
                        }
                        trainerBase.PE.HasObjective = hasObjective.Checked; // STORING VALUE OF COMBOBOX TO BOOL VAR WHICH AT THE MAIN SIDE OF APP
                    }
                    else // ELSE, IF TIME VALUE IS DIFERRENT TO 00:00:OO
                    {
                        trainerBase.PE.HasObjective = hasObjective.Checked; // THEN STORING VALUE OF COMBOBOX TO MAIN CLASS
                        trainerBase.PE.SetObjectiveTime // GATHERING VALUES FROM THE FORM AND STORIN THEM TO MAIN CLASS
                        (
                            Convert.ToInt32(monthsPerYear.Value),
                            Convert.ToInt32(daysPerMonth.Value),
                            Convert.ToInt32(hoursPerDay.Value),
                            Convert.ToInt32(minutesPerDay.Value),
                            Convert.ToInt32(secondsPerDay.Value)
                        );
                        trainerBase.PE.CloseObjWindow();
                        trainerBase.MainFrame.Enabled = true; // UNLOCKING MAIN WINDOW
                    }
                }
                else // ELSE, IF USER DOESN`T WANT TO SET ANY OBJECTIVE
                {
                    trainerBase.PE.CloseObjWindow(); // WE`RE JUST CLOSING THE WINDOW (we aren`t changing any values because we`ll do it below at line 90)
                    trainerBase.MainFrame.Enabled = true;
                }

                trainerBase.PE.HasObjective = hasObjective.Checked; // STORING VALUE OF COMBOBOX TO BOOL VAR WHICH AT THE MAIN SIDE OF APP
                                                                    //trainerBase.PE.GetLog();
            }
            else
            {
                if (trainerBase.Football.HasObjective && !hasObjective.Checked)
                {
                    if (MessageBox.Show("Если ты сейчас отключишь функцию \"Цель\", то твои последние достижения будут сброшены. Это не повлияет на Статистику.", "Ты уверен?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        hasObjective.Checked = true;
                        MessageBox.Show("Достижения не были сброшены", "Всё ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Достижения по футболу сброшены", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (hasObjective.Checked) // IF USER HAS DAILY/MONTHLY/ANY OBJECTIVE...
                {
                    if (zerotime_condition) // ... THEN CHECK IF TIME SET TO 00:00:00 ...
                    {
                        if (MessageBox.Show("Ты не задал количество времени для занятий. Хочешь отключить эту функцию?", "Задай время", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) /// IF SO THEN NOTIFY USER HE WASN`T SET TARGET TIME AND ASK IF HE WANT TO DO IT.
                        {
                            // IF HE ANSWERS "YES" THEN WE DIRECTLY CHANGE HAS_OBJECTIVE COMBOBOX VALUE TO "FALSE" 
                            hasObjective.Checked = false;
                            zerotime_condition = false; // RESET ZEROTIME_CONDITION TO PREVENT REPEATED FLASHING OF MESSAGEBOX

                            trainerBase.MainFrame.Enabled = true; // UNLOCKING THE MAIN WINDOW
                            trainerBase.Football.CloseObjWindow(); // CLOSE "OBJECTIVE WINDOW"
                        }
                        else
                        {
                            zerotime_condition = false; // IF HE SAYS "NO" WE RESET ZEROTIME_CONDITION (for the same purpose as above) 
                            hasObjective.Checked = true; // SETTING COMBOBOX VALUE TO TRUE AS BY SAYING "NO" USER MEANS THAT HE WANT TO SET SOME OBJECTIVE 
                        }
                        trainerBase.Football.HasObjective = hasObjective.Checked; // STORING VALUE OF COMBOBOX TO BOOL VAR WHICH AT THE MAIN SIDE OF APP
                    }
                    else // ELSE, IF TIME VALUE IS DIFERRENT TO 00:00:OO
                    {
                        trainerBase.Football.HasObjective = hasObjective.Checked; // THEN STORING VALUE OF COMBOBOX TO MAIN CLASS
                        trainerBase.Football.SetObjectiveTime // GATHERING VALUES FROM THE FORM AND STORIN THEM TO MAIN CLASS
                        (
                            Convert.ToInt32(monthsPerYear.Value),
                            Convert.ToInt32(daysPerMonth.Value),
                            Convert.ToInt32(hoursPerDay.Value),
                            Convert.ToInt32(minutesPerDay.Value),
                            Convert.ToInt32(secondsPerDay.Value)
                        );
                        trainerBase.Football.CloseObjWindow();
                        trainerBase.MainFrame.Enabled = true; // UNLOCKING MAIN WINDOW
                    }

                }
                else // ELSE, IF USER DOESN`T WANT TO SET ANY OBJECTIVE
                {
                    trainerBase.Football.CloseObjWindow(); // WE`RE JUST CLOSING THE WINDOW (we aren`t changing any values because we`ll do it below at line 90)
                    trainerBase.MainFrame.Enabled = true;
                }

                trainerBase.Football.HasObjective = hasObjective.Checked; // STORING VALUE OF COMBOBOX TO BOOL VAR WHICH AT THE MAIN SIDE OF APP
                                                                          //trainerBase.Football.GetLog();
            }
        }

        private void hasObjective_CheckedChanged(object sender, EventArgs e)
        {
            mainPanel.Enabled = hasObjective.Checked;


        }

        private void hoursPerDay_ValueChanged(object sender, EventArgs e)
        {
            valChangingHandler();
        }

        private void minutesPerDay_ValueChanged(object sender, EventArgs e)
        {
            valChangingHandler();
        }

        private void secondsPerDay_ValueChanged(object sender, EventArgs e)
        {
            valChangingHandler();
        }

        private void daysPerMonth_ValueChanged(object sender, EventArgs e)
        {
            valChangingHandler();
        }

        private void monthsPerYear_ValueChanged(object sender, EventArgs e)
        {
            valChangingHandler();
        }
        public void valChangingHandler() // currently not using
        {
            // isAnyValChanged = true;
            //Text += "*";
        }
    }

}
