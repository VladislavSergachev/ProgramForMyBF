using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrainer
{
    static class trainerBase
    {
        public enum TabKind
        {
            PhysicalEdu = 0,
            Football = 1
        }
        
        private static MainWindow _mainFrame;
        private static onTrainingFrame _trainingFrame;
        private static changeObjective_pe _changeObjFrame;

        private static DateTime _trainingStarted;
        private static DateTime _trainingFinished;
        private static TimeSpan _trainingCurrent; //Time values
        
        
        
        public static class Objective
        {
            static TimeSpan _targetPeriod;
            static int weekly,
                       monthly,
                       annually;

            static TimeSpan daily;
            private static bool hasObjective;


            public static void CloseWindow()
            {
                _changeObjFrame.Dispose();
            }
            public static void OpenWindow()
            {
                _changeObjFrame = new changeObjective_pe();
                _changeObjFrame.Show();
            }
            static public int Weekly
            {
                get
                {
                    return weekly;
                }
                set
                {
                    weekly = value;
                }
            }
            static public int Monthly
            {
                get
                {
                    return monthly;
                }
                set
                {
                    monthly = value;
                }
            }
            static public int Annually
            {
                get
                {
                    return annually;
                }
                set
                {
                    annually = value;
                }
            }
            static public TimeSpan Daily
            {
                get
                {
                    return daily;
                }
                set
                {
                    daily = value;
                }
            }
            public static TimeSpan ObjectivePeriod
            {
                get
                {
                    return _targetPeriod;
                }
                set
                {
                    _targetPeriod = value;
                }
            }
            
            public static bool HasObjective
            {
                get
                {
                    return hasObjective;
                }
                set
                {
                    hasObjective = value;
                }
            }
            public static void GetLog()
            {
                Console.WriteLine("Annually " + Annually.ToString());
                Console.WriteLine("Monyhly " + Monthly.ToString());
                Console.WriteLine("Daily " + Daily.ToString());
                Console.WriteLine("Weekly " + Weekly.ToString());

                Console.WriteLine("HasObjective " + HasObjective);
            }
        };
        private static TabKind _openedTab = TabKind.PhysicalEdu;


        public static MainWindow MainFrame
        {
            get
            {
                if (_mainFrame == null)
                    _mainFrame = new MainWindow();

                Objective.ObjectivePeriod = new TimeSpan();

                return _mainFrame;
            }
        }
        public static onTrainingFrame TrainingFrame
        {
            get
            {
                if (_trainingFrame == null)
                    _trainingFrame = new onTrainingFrame();

                return _trainingFrame;
            }
        }
        public static DateTime BeginTime
        {
            get
            {
                return _trainingStarted;
            }
            set
            {
                _trainingStarted = value;
            }
        }
        public static DateTime EndTime
        {
            get
            {
                return _trainingFinished;
            }
            set
            {
                _trainingFinished = value;
            }
        }
        public static TimeSpan CurrentTime
        {
            get
            {
                return _trainingCurrent;
            }
            set
            {
                _trainingCurrent = value;
            }
        }
      

        public static TabKind TabOpened
        {
            get
            {
                return _openedTab;
            }
            set
            {
                _openedTab = value;
            }
        }
        public static void StartTraining()
        {
            _trainingFrame = new onTrainingFrame();

            _mainFrame.Hide();
            _trainingFrame.Show();

            BeginTime = DateTime.Now;
        }
        public static void StopTraining()
        {
            if (_trainingFrame == null)
                _trainingFrame = new onTrainingFrame();

            _mainFrame.Show();
            _trainingFrame.Hide();

            EndTime = DateTime.Now;
        }
        public static void SetObjectiveTime(int months, int daysPerMonth,  int hours, int minutes, int seconds)
        {
            if(Objective.HasObjective)
            {
                Objective.Daily = new TimeSpan(hours, minutes, seconds);     
                Objective.Monthly = daysPerMonth;                        
                Objective.Annually = months;
            }
        }
    }
}
