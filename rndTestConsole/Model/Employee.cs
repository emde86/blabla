//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Newtonsoft.Json;
//using System.ComponentModel;
//using System.Collections.ObjectModel;

//namespace rndTestConsole.Model
//{
//    public class Employee : ICloneable, INotifyPropertyChanged
//    {
//        public event PropertyChangedEventHandler PropertyChanged;
//        public void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//        private int _id;
//        [JsonProperty("employeeId")]
//        public int id
//        {
//            get { return _id; }
//            set
//            {
//                if (value != _id)
//                {
//                    _id = value;
//                    NotifyPropertyChanged("id");
//                }
//            }
//        }

//        private int _employeeNumber;
//        [JsonProperty("employeeNumber")]
//        public int EmployeeNumber
//        {
//            get { return _employeeNumber; }
//            set
//            {
//                if (value != _employeeNumber)
//                {
//                    _employeeNumber = value;
//                    NotifyPropertyChanged("EmployeeNumber");
//                }
//            }
//        }

//        private string _login;
//        [JsonProperty("login")]
//        public string Login
//        {
//            get { return _login; }
//            set
//            {
//                if (value != _login)
//                {
//                    _login = value;
//                    NotifyPropertyChanged("Login");
//                }
//            }
//        }

//        private string _source;
//        [JsonProperty("source")]
//        public string Source
//        {
//            get { return _source; }
//            set
//            {
//                if (value != _source)
//                {
//                    _source = value;
//                    NotifyPropertyChanged("Source");
//                }
//            }
//        }

//        private string _email;
//        [JsonProperty("eMail")]
//        public string Email
//        {
//            get { return _email; }
//            set
//            {
//                if (value != _email)
//                {
//                    _email = value;
//                    NotifyPropertyChanged("Email");
//                }
//            }
//        }

//        private string _firstName;
//        [JsonProperty("firstName")]
//        public string FirstName
//        {
//            get { return _firstName; }
//            set
//            {
//                if (value != _firstName)
//                {
//                    _firstName = value;
//                    NotifyPropertyChanged("FirstName");
//                }
//            }
//        }

//        private string _lastName;
//        [JsonProperty("lastName")]
//        public string LastName
//        {
//            get { return _lastName; }
//            set
//            {
//                if (value != _lastName)
//                {
//                    _lastName = value;
//                    NotifyPropertyChanged("LastName");
//                }
//            }
//        }

//        private ServiceDate _birthday;
//        [JsonProperty("birthday")]
//        public ServiceDate Birthday
//        {
//            get { return _birthday; }
//            set
//            {
//                if (value != _birthday)
//                {
//                    _birthday = value;
//                    NotifyPropertyChanged("Birthday");
//                }
//            }
//        }

//        private ServiceDate _startDate;
//        [JsonProperty("startDate")]
//        public ServiceDate StartDate
//        {
//            get { return _startDate; }
//            set
//            {
//                if (value != _startDate)
//                {
//                    _startDate = value;
//                    NotifyPropertyChanged("StartDate");
//                }
//            }
//        }

//        private string _company;
//        [JsonProperty("company")]
//        public string Company
//        {
//            get { return _company; }
//            set
//            {
//                if (value != _company)
//                {
//                    _company = value;
//                    NotifyPropertyChanged("Company");
//                }
//            }
//        }

//        private string _hobbies;
//        [JsonProperty("hobbies")]
//        public string Hobbies
//        {
//            get { return _hobbies; }
//            set
//            {
//                if (value != _hobbies)
//                {
//                    _hobbies = value;
//                    NotifyPropertyChanged("Hobbies");
//                }
//            }
//        }

//        private string _status;
//        [JsonProperty("status")]
//        public string Status
//        {
//            get { return _status; }
//            set
//            {
//                if (value != _status)
//                {
//                    _status = value;
//                    NotifyPropertyChanged("Status");
//                }
//            }
//        }

//        private string _phone;
//        [JsonProperty("phone")]
//        public string Phone
//        {
//            get { return _phone; }
//            set
//            {
//                if (value != _phone)
//                {
//                    _phone = value;
//                    NotifyPropertyChanged("Phone");
//                }
//            }
//        }

//        private string _mobile;
//        [JsonProperty("mobile")]
//        public string Mobile
//        {
//            get { return _mobile; }
//            set
//            {
//                if (value != _mobile)
//                {
//                    _mobile = value;
//                    NotifyPropertyChanged("Mobile");
//                }
//            }
//        }

//        private ServiceDate _changeDate;
//        [JsonProperty("changedAt")]
//        public ServiceDate ChangeDate
//        {
//            get { return _changeDate; }
//            set
//            {
//                if (value != _changeDate)
//                {
//                    _changeDate = value;
//                    NotifyPropertyChanged("ChangeDate");
//                }
//            }
//        }

//        [JsonProperty("roles")]
//        public ObservableCollection<string> Roles { get; set; }

//        private int _currentWorkHours;
//        [JsonProperty("currentWorkHours")]
//        public int CurrentWorkHours
//        {
//            get { return _currentWorkHours; }
//            set
//            {
//                if (value != _currentWorkHours)
//                {
//                    _currentWorkHours = value;
//                    NotifyPropertyChanged("CurrentWorkHours");
//                }
//            }
//        }

//        private int _contractualWorkHours;
//        [JsonProperty("contractualWorkHours")]
//        public int ContractualWorkHours
//        {
//            get { return _contractualWorkHours; }
//            set
//            {
//                if (value != _contractualWorkHours)
//                {
//                    _contractualWorkHours = value;
//                    NotifyPropertyChanged("ContractualWorkHours");
//                }
//            }
//        }

//        private int _currentVacationDays;
//        [JsonProperty("CurrentVacationDays")]
//        public int CurrentVacationDays
//        {
//            get { return _currentVacationDays; }
//            set
//            {
//                if (value != _currentVacationDays)
//                {
//                    _currentVacationDays = value;
//                    NotifyPropertyChanged("CurrentVacationDays");
//                }
//            }
//        }

//        private int _contractualVacationDays;
//        [JsonProperty("ContractualVacationDays")]
//        public int ContractualVacationDays
//        {
//            get { return _contractualVacationDays; }
//            set
//            {
//                if (value != _contractualVacationDays)
//                {
//                    _contractualVacationDays = value;
//                    NotifyPropertyChanged("ContractualVacationDays");
//                }
//            }
//        }

//        private string _street;
//        [JsonProperty("street")]
//        public string Street
//        {
//            get { return _street; }
//            set
//            {
//                if (value != _street)
//                {
//                    _street = value;
//                    NotifyPropertyChanged("Street");
//                }
//            }
//        }

//        private string _city;
//        [JsonProperty("city")]
//        public string City
//        {
//            get { return _city; }
//            set
//            {
//                if (value != _city)
//                {
//                    _city = value;
//                    NotifyPropertyChanged("City");
//                }
//            }
//        }

//        private string _zipCode;
//        [JsonProperty("zip")]
//        public string ZipCode
//        {
//            get { return _zipCode; }
//            set
//            {
//                if (value != _zipCode)
//                {
//                    _zipCode = value;
//                    NotifyPropertyChanged("ZipCode");
//                }
//            }
//        }


//        public object Clone()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
