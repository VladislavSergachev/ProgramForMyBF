using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTrainer
{
    public static class trainerBase
    {
        public enum TrainKind
        {
            PhysicalEdu = 0,
            Football = 1
        }

        private static MainWindow _mainFrame;
        private static onTrainingFrame _trainingFrame;
        private static changeObjective_pe _changeObjFrame;

        public static class phEd
        {
            private static DateTime _trainingStarted;
            private static DateTime _trainingFinished;
            private static TimeSpan _trainingCurrent; //Time values

            static int monthly, annually;
            static TimeSpan daily;

            private static bool hasObjective;



            public static class Objective
            {
                public static void CloseWindow()
                {
                    _changeObjFrame.Dispose();
                }
                public static void OpenWindow()
                {
                    _changeObjFrame = new changeObjective_pe(TrainKind.PhysicalEdu);
                    _changeObjFrame.Show();
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
                    Console.WriteLine("PhEdu:\n");
                    Console.WriteLine("Annually " + Annually.ToString());
                    Console.WriteLine("Monyhly " + Monthly.ToString());
                    Console.WriteLine("Daily " + Daily.ToString());

                    Console.WriteLine("HasObjective " + HasObjective);
                }
                public static void SetObjectiveTime(int months, int daysPerMonth, int hours, int minutes, int seconds)
                {
                    if (HasObjective)
                    {
                        Daily = new TimeSpan(hours, minutes, seconds);
                        Monthly = daysPerMonth;
                        Annually = months;
                    }
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
            public static void StartTraining()
            {
                _trainingFrame = new onTrainingFrame(TrainKind.PhysicalEdu);

                _mainFrame.Hide();
                _trainingFrame.Show();

                _trainingStarted = DateTime.Now;
            }
            public static void StopTraining()
            {
                _trainingFinished = DateTime.Now;

                _mainFrame.Show();
                _trainingFrame.Hide();

                         
           }
        };
        public static class Football
        {
            static int monthly, annually;
            static TimeSpan daily;
            private static DateTime _trainingStarted;
            private static DateTime _trainingFinished;
            private static TimeSpan _trainingCurrent; //Time values

            private static bool hasObjective;



            public static class Objective
            {
                public static void CloseWindow()
                {
                    _changeObjFrame.Dispose();
                }
                public static void OpenWindow()
                {
                    _changeObjFrame = new changeObjective_pe(TrainKind.Football);
                    _changeObjFrame.Show();
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
                    Console.WriteLine("Football:\n");
                    Console.WriteLine("Annually " + Annually.ToString());
                    Console.WriteLine("Monyhly " + Monthly.ToString());
                    Console.WriteLine("Daily " + Daily.ToString());

                    Console.WriteLine("HasObjective " + HasObjective);
                }
                public static void SetObjectiveTime(int months, int daysPerMonth, int hours, int minutes, int seconds)
                {
                    if (HasObjective)
                    {
                        Daily = new TimeSpan(hours, minutes, seconds);
                        Monthly = daysPerMonth;
                        Annually = months;
                    }
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
            public static void StartTraining()
            {
                _trainingFrame = new onTrainingFrame(TrainKind.Football);

                _mainFrame.Hide();
                Console.WriteLine("HIDED MAIN");
                _trainingFrame.Show();

                _trainingStarted = DateTime.Now;
            }
            public static void StopTraining()
            {
                _trainingFinished = DateTime.Now;
                _mainFrame.Show();
                _trainingFrame.Hide();
            }
        }
        private static TrainKind _openedTab = TrainKind.PhysicalEdu;


        public static MainWindow MainFrame
        {
            get
            {
                return _mainFrame;
            }
        }
        public static void InitMainWin()
        {
            _mainFrame = new MainWindow();
            phEd.BeginTime = new DateTime(1, 1, 1, 0, 0, 0);
            phEd.CurrentTime = new TimeSpan(0, 0, 0);
            phEd.EndTime = new DateTime();

            Football.BeginTime = new DateTime(1, 1, 1, 0, 0, 0);
            Football.CurrentTime = new TimeSpan(0, 0, 0);
            Football.EndTime = new DateTime();
            _mainFrame.Show();
        }
        public static onTrainingFrame TrainingFrame
        {
            get
            {
                return _trainingFrame;
            }
        }

        public static TrainKind TabOpened
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
    }

}

