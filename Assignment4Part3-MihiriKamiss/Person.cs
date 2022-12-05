using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Part3_MihiriKamiss
{
    internal class Person
    {
        //private member fields
        private string _name;
        private DateTime _birthdate;

        //public accessors and muttators 
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length >= 5 && value.Length > 0)
                {
                    _name = value;
                }
                else if(value.Length < 5)
                {
                    throw new Exception("Invalid name (min 5 characters)");
                }
                else
                {
                    throw new Exception("Name must contain 5 or more characters");
                }
            }
        }//end of Name

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set {
                if(value > DateTime.Now)
                {
                    _birthdate = value;
                }
                else
                {
                    throw new Exception("Birthdate cannot be in the future");
                }
            }
        }//end of Birthdate

        public int CurrentAge
        {
            get {
                int age = Convert.ToInt32((DateTime.Now - _birthdate).Days - ((DateTime.Now - _birthdate).Days % 365.242199));
                return age; }
        }//end of CurrentAge

        //Constructors
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            Birthdate = birthDate;
        }//end of Person

        public int AgeOn(DateTime onDate)
        {
            int age;

            age = Convert.ToInt32((DateTime.Now - onDate).Days - ((DateTime.Now - onDate).Days % 365.242199));
            return age;
        }//end of AgeOn

        public string AstrologicalSign()
        {
            string sign;
            int month = _birthdate.Month,
                day = _birthdate.Day;

            if((month == 3 && day >= 21) || (month == 4 && day >= 19))
            {
                sign = "Aries";
            }
            else if((month == 4 && day <= 20) || (month >= 5 && day >= 20))
            {
                sign = "Taurus";
            }
            else if ((month == 5 && day <= 21) || (month >= 6 && day >= 21))
            {
                sign = "Gemini";
            }
            else if ((month == 6 && day <= 22) || (month >= 7 && day >= 22))
            {
                sign = "Cancer";
            }
            else if ((month == 7 && day <= 23) || (month >= 8 && day >= 22))
            {
                sign = "Leo";
            }
            else if ((month == 8 && day <= 23) || (month >= 9 && day >= 22))
            {
                sign = "Virgo";
            }
            else if ((month == 9 && day <= 23) || (month >= 10 && day >= 22))
            {
                sign = "Libra";
            }
            else if ((month == 10 && day <= 23) || (month >= 11 && day >= 22))
            {
                sign = "Scorpio";
            }
            else if ((month == 11 && day <= 23) || (month >= 12 && day >= 21))
            {
                sign = "Sagitarius";
            }
            else if ((month == 12 && day <= 22) || (month >= 1 && day >= 19))
            {
                sign = "Capricorn";
            }
            else if ((month == 1 && day <= 20) || (month >= 2 && day >= 18))
            {
                sign = "Aquarius";
            }
            else
            {
                sign = "Pisces";
            }

            return sign;

        }//end of AstrologicalSign

        public string ChineseZodiac




    }
}
