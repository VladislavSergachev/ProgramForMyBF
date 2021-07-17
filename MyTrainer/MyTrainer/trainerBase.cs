using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MyTrainer
{
    public static class trainerBase
    {
        private static DateTime date;
        private static string _peSavePath = "../statistics/pe/", 
                            _footballSavePath = "../statistics/football/";

        public static void SaveValues()
        {
            if (!Directory.Exists(_peSavePath))
                Directory.CreateDirectory(_peSavePath);
            if (!Directory.Exists(_footballSavePath))
                Directory.CreateDirectory(_footballSavePath);

            string _peData = JsonConvert.SerializeObject(PE, Formatting.Indented);
            string _footbalData = JsonConvert.SerializeObject(Football, Formatting.Indented);

            string _finalPathPE = (_peSavePath + actualDate.Date.ToShortDateString() + ".json");
            string _finalPathFootball = (_footballSavePath + actualDate.Date.ToShortDateString() + ".json");

            File.WriteAllText(_finalPathPE, _peData);
            File.WriteAllText(_finalPathFootball, _footbalData);
        }
        public static void RestoreValues()
        {
            if (Directory.Exists(_peSavePath))
            {
                string[] _peFilepaths = Directory.GetFiles(_peSavePath);
                string[] _peFileNames = new string [_peFilepaths.Length];
                string 
                
                DateTime[] _crDates = new DateTime[_peFilepaths.Length];
                DateTime lastDate;

                for (int i = 0; i < _peFilepaths.Length - 1; i++)
                {
                    _peFileNames[i] = Path.GetFileNameWithoutExtension(_peFilepaths[i]);
                    _crDates[i] = DateTime.Parse(_peFileNames[i]);
                }

                lastDate = _crDates.Max();

                for(int i = 0; i < _crDates.Length - 1; i++)
                    Console.WriteLine(_crDates[i].ToString());

                
                
                PE = JsonConvert.DeserializeObject()
            }
        }
        public enum TrainKind
        {
            PhysicalEdu = 0,
            Football = 1
        }

        private static TrainKind _openedTab;
        private static MainWindow _mainFrame;
        private static onTrainingFrame _trainingFrame;
        private static changeObjective_pe _changeObjFrame;

        private static ExersicePE exersicePE;
        private static ExersiceFootball exersiceFootball;

        
        
        public static DateTime actualDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        
        public static ExersicePE PE
        {
            get
            {
                return exersicePE;
            }
            set
            {
                exersicePE = value;
            }
        }
        public static ExersiceFootball Football
        {
            get
            {
                return exersiceFootball;
            }
            set
            {
                exersiceFootball = value;
            }
        }

        public class ExersicePE
        {
            private DateTime date;

            private DateTime _trainingStarted;
            private DateTime _trainingFinished;
            private TimeSpan _trainingCurrent; //Time values


            private bool hasObjective;
            public DateTime Date
            {
                get
                {
                    return date;
                }
                set
                {
                    date = value;
                }
            }
            public struct dailyObj
            {
                TimeSpan required, completed;
                public TimeSpan Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public TimeSpan Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }
            public struct monthlyObj
            {
                int required, completed;
                public int Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public int Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }
            public struct annuallyObj
            {
                int required, completed;
                public int Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public int Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }

            public dailyObj obDaily;
            public monthlyObj obMonthly;
            public annuallyObj obAnnually;
            
            //int monthly, annually;
            //TimeSpan daily;

            public void CloseObjWindow()
            {
                _changeObjFrame.Dispose();
            }
            public void OpenObjWindow()
            {
                _changeObjFrame = new changeObjective_pe(TrainKind.PhysicalEdu);
                _changeObjFrame.Show();
            }



            public bool HasObjective
            {
                get
                {
                    return this.hasObjective;
                }
                set
                {
                    hasObjective = value;
                }
            }
           /* public void GetLog()
            {
                Console.WriteLine("PhEdu:\n");
                Console.WriteLine("Annually " + AnnuallyObj.ToString());
                Console.WriteLine("Monyhly " + MonthlyObj.ToString());
                Console.WriteLine("Daily " + DailyObj.ToString());

                Console.WriteLine("HasObjective " + HasObjective);
            }*/
            public void SetObjectiveTime(int months, int daysPerMonth, int hours, int minutes, int seconds)
            {
                if (HasObjective)
                {
                    obDaily = new dailyObj
                    {
                        Required = new TimeSpan(hours, minutes, seconds),
                        Completed = new TimeSpan()
                    };
                    obMonthly = new monthlyObj
                    {
                        Required = daysPerMonth,
                        Completed = 0
                    };
                    obAnnually = new annuallyObj
                    {
                        Required = months,
                        Completed = 0
                    };
                }
            }

            public DateTime BeginTime
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
            public DateTime EndTime
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
            public TimeSpan CurrentTime
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
            public void StartTraining()
            {
                _trainingFrame = new onTrainingFrame(TrainKind.PhysicalEdu);

                _mainFrame.Hide();
                _trainingFrame.Show();

                _trainingStarted = DateTime.Now;
            }
            public void StopTraining()
            {
                _trainingFinished = DateTime.Now;

                _mainFrame.Show();
                _trainingFrame.Hide();


            }

        };
        public class ExersiceFootball
        {

            private DateTime _trainingStarted;
            private DateTime _trainingFinished;
            private TimeSpan _trainingCurrent; //Time values
            private DateTime date;


            private bool hasObjective;
            public struct monthlyObj
            {
                int required, completed;
                public int Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public int Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }
            public struct annuallyObj
            {
                int required, completed;
                public int Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public int Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }
            public struct dailyObj
            {
                TimeSpan required, completed;
                public TimeSpan Required
                {
                    get
                    {
                        return required;
                    }
                    set
                    {
                        required = value;
                    }
                }
                public TimeSpan Completed
                {
                    get
                    {
                        return completed;
                    }
                    set
                    {
                        completed = value;
                    }
                }
            }

            public monthlyObj obMonthly;
            public dailyObj obDaily;
            public annuallyObj obAnnually;
            

            
            
            //int monthly, annually;
            //TimeSpan daily;

            public void CloseObjWindow()
            {
                _changeObjFrame.Dispose();
            }
            public void OpenObjWindow()
            {
                _changeObjFrame = new changeObjective_pe(TrainKind.Football);
                _changeObjFrame.Show();
            }
            
            public DateTime Date
            {
                get
                {
                    return date;
                }
                set
                {
                    date = value;
                }
            }
            

            public bool HasObjective
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
           /* public void GetLog()
            {
                Console.WriteLine("PhEdu:\n");
                Console.WriteLine("Annually " + AnnuallyObj.ToString());
                Console.WriteLine("Monyhly " + MonthlyObj.ToString());
                Console.WriteLine("Daily " + DailyObj.ToString());

                Console.WriteLine("HasObjective " + HasObjective);
            }*/
            public void SetObjectiveTime(int months, int daysPerMonth, int hours, int minutes, int seconds)
            {
                if (HasObjective)
                {
                    obDaily = new dailyObj
                    {
                        Required = new TimeSpan(hours, minutes, seconds),
                        Completed = new TimeSpan()
                    };
                    obMonthly = new monthlyObj
                    {
                        Required = daysPerMonth,
                        Completed = 0
                    };
                    obAnnually = new annuallyObj
                    {
                        Required = months,
                        Completed = 0
                    };
                }
            }


            public DateTime BeginTime
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
            public DateTime EndTime
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
            public TimeSpan CurrentTime
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
            public void StartTraining()
            {
                _trainingFrame = new onTrainingFrame(TrainKind.Football);

                _mainFrame.Hide();
                _trainingFrame.Show();

                _trainingStarted = DateTime.Now;
            }
            public void StopTraining()
            {
                _trainingFinished = DateTime.Now;

                _mainFrame.Show();
                _trainingFrame.Hide();


            }
        }

        public static MainWindow MainFrame
        {
            get
            {
                return _mainFrame;
            }
        }
        public static void InitMainWin()
        {
            exersicePE = new ExersicePE();
            exersiceFootball = new ExersiceFootball();
            actualDate = DateTime.Today;

            _mainFrame = new MainWindow();
            PE.BeginTime = new DateTime(1, 1, 1, 0, 0, 0);
            PE.CurrentTime = new TimeSpan(0, 0, 0);
            //PE.Objective.Progress = new DateTime(1, 1, 1, 0, 0, 0);
            PE.EndTime = new DateTime();

            Football.BeginTime = new DateTime(1, 1, 1, 0, 0, 0);
            Football.CurrentTime = new TimeSpan(0, 0, 0);
            //ExersiceFootball.Objective.Progress = new DateTime(1, 1, 1, 0, 0, 0);
            Football.EndTime = new DateTime();

            Football.Date = DateTime.Today;
            PE.Date = DateTime.Today;

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
        public static DateTime GetMaxDate(DateTime[] dates)
        {
            DateTime max = new DateTime();
            if(dates.Length != 0)
            {
                max = dates[0];
                for(int i = 0; i < dates.Length - 1; i++)
                {
                    if (dates[i] > max)
                        max = dates[i];
                }
            }
            return max;
        }
    }

}

