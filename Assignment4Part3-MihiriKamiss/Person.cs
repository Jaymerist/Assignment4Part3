using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4Part3_MihiriKamiss
{
    public class Person
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
                //_name = value if the length is more than 5 and 
                if(string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new Exception("Name cannot be blank");
                }
                else if (value.Length < 5)
                {
                    throw new Exception("Name must contain 5 or more characters");
                }
                else
                {
                    _name = value;
                }
            }
        }//end of Name

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                //if birthday was in the past from the current date, _birthdate = value
                if (value < DateTime.Now)
                {
                    _birthdate = value;
                }
                else
                {
                    throw new Exception("BirthDate cannot be in the future");
                }
            }
        }//end of Birthdate

        public int CurrentAge
        {
            get
            {
                //find number of days Person has been alive
                TimeSpan interval = DateTime.Now - _birthdate;

                //Find number of years in a whole number based on days lived
                int age = Convert.ToInt32(Math.Floor(interval.Days / 365.242199));
                return age;
            }
        }//end of CurrentAge

        //Constructors
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            Birthdate = birthDate;
        }//end of Person

        public int AgeOn(DateTime onDate)
        {
            //find number of days Person has been alive when onDate
            TimeSpan interval = onDate - _birthdate;

            //Find number of years in a whole number based on days lived onDate
            int age = Convert.ToInt32(Math.Floor(interval.Days / 365.242199));
            return age;
        }//end of AgeOn

        public string AstrologicalSign()
        {
            string sign;
            int month = _birthdate.Month,
                day = _birthdate.Day;

            if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {
                sign = "Aries";
            }
            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {
                sign = "Taurus";
            }
            else if (month == 5 && day <= 21 || month == 6 && day <= 21)
            {
                sign = "Gemini";
            }
            else if (month == 6 && day >= 22 || month == 7 && day <= 22)
            {
                sign = "Cancer";
            }
            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {
                sign = "Leo";
            }
            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {
                sign = "Virgo";
            }
            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {
                sign = "Libra";
            }
            else if (month == 10 && day >= 23 || month == 11 && day <= 22)
            {
                sign = "Scorpio";
            }
            else if (month == 11 && day >= 23 || month == 12 && day <= 21)
            {
                sign = "Sagittarius";
            }
            else if (month == 12 && day >= 22 || month == 1 && day <= 19)
            {
                sign = "Capricorn";
            }
            else if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                sign = "Aquarius";
            }
            else
            {
                sign = "Pisces";
            }

            return sign;

        }//end of AstrologicalSign

        public string ChineseZodiac()
        {
            int year = _birthdate.Year;
            string zodiac;

            if(year % 12 == 0)
            {
                zodiac = "Monkey";
            }
            else if (year % 12 == 1)
            {
                zodiac = "Rooster";
            }
            else if (year % 12 == 2)
            {
                zodiac = "Dog";
            }
            else if (year % 12 == 3)
            {
                zodiac = "Pig";
            }
            else if (year % 12 == 4)
            {
                zodiac = "Rat";
            }
            else if (year % 12 == 5)
            {
                zodiac = "Ox";
            }
            else if (year % 12 == 6)
            {
                zodiac = "Tiger";
            }
            else if (year % 12 == 7)
            {
                zodiac = "Rabbit";
            }
            else if (year % 12 == 8)
            {
                zodiac = "Dragon";
            }
            else if (year % 12 == 9)
            {
                zodiac = "Snake";
            }
            else if (year % 12 == 10)
            {
                zodiac = "Horse";
            }
            else
            {
                zodiac = "Sheep";
            }

            return zodiac;
        }




    }
}
