//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using Newtonsoft.Json;

//namespace rndTestConsole.Model
//{
//    public class ServiceDate : INotifyPropertyChanged
//    {
//        public event PropertyChangedEventHandler PropertyChanged;
//        public void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//        private int _date;
//        [JsonProperty("date")]
//        public int Date
//        {
//            get { return _date; }
//            set
//            {
//                if (value != _date)
//                {
//                    _date = value;
//                    NotifyPropertyChanged("Date");
//                }
//            }
//        }

//        private int _day;
//        [JsonProperty("day")]
//        public int Day
//        {
//            get { return _day; }
//            set
//            {
//                if (value != _day)
//                {
//                    _day = value;
//                    NotifyPropertyChanged("Day");
//                }
//            }
//        }

//        private int _hours;
//        [JsonProperty("hours")]
//        public int Hours
//        {
//            get { return _hours; }
//            set
//            {
//                if (value != _hours)
//                {
//                    _hours = value;
//                    NotifyPropertyChanged("Hours");
//                }
//            }
//        }

//        private int _minutes;
//        [JsonProperty("minutes")]
//        public int Minutes
//        {
//            get { return _minutes; }
//            set
//            {
//                if (value != _minutes)
//                {
//                    _minutes = value;
//                    NotifyPropertyChanged("Minutes");
//                }
//            }
//        }

//        private int _month;
//        [JsonProperty("month")]
//        public int Month
//        {
//            get { return _month; }
//            set
//            {
//                if (value != _month)
//                {
//                    _month = value;
//                    NotifyPropertyChanged("Month");
//                }
//            }
//        }

//        private int _seconds;
//        [JsonProperty("seconds")]
//        public int Seconds
//        {
//            get { return _seconds; }
//            set
//            {
//                if (value != _seconds)
//                {
//                    _seconds = value;
//                    NotifyPropertyChanged("Seconds");
//                }
//            }
//        }

//        private long _timeTick;
//        [JsonProperty("time")]
//        public long TimeTick
//        {
//            get { return _timeTick; }
//            set
//            {
//                if (value != _timeTick)
//                {
//                    _timeTick = value;
//                    NotifyPropertyChanged("TimeTick");
//                }
//            }
//        }

//        private int _timezoneOffset;
//        [JsonProperty("timezoneOffset")]
//        public int TimezoneOffset
//        {
//            get { return _timezoneOffset; }
//            set
//            {
//                if (value != _timezoneOffset)
//                {
//                    _timezoneOffset = value;
//                    NotifyPropertyChanged("TimezoneOffset");
//                }
//            }
//        }

//        private int _year;
//        [JsonProperty("year")]
//        public int Year
//        {
//            get { return _year; }
//            set
//            {
//                if (value != _year)
//                {
//                    _year = value;
//                    NotifyPropertyChanged("Year");
//                }
//            }
//        }

//        public DateTime SystemDate
//        {
//            get
//            {
//                return new DateTime(621355968000000000L + ( (this.TimeTick - (this.TimezoneOffset * 60000)) * 10000) );
//            }
//        }
//    }
//}
