using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_01_Encapsulation.Models
{
    internal class PersonV1
    {
        private string _Firstname;
        private string _Lastname;
        private DateTime _Birthdate;

        public string GetFirstname()
        {
            return _Firstname;
        }
        public void SetFirstname(string value)
        {
            _Firstname = value;
        }

        public string GetLastname()
        {
            return _Lastname.ToUpper();
        }
        public void SetLastname(string value)
        {
            _Lastname = value;
        }

        public DateTime GetBirthdate()
        {
            return _Birthdate;
        }
        public void SetBirthdate(DateTime value)
        {
            _Birthdate = value;
        }
        public int GetAge()
        {
            int age =  DateTime.Today.Year - _Birthdate.Year;

            DateTime currentBirthday = new DateTime(
                DateTime.Today.Year,
                _Birthdate.Month,
                _Birthdate.Day
            );
            if(DateTime.Today.CompareTo(currentBirthday) > 0 )
            {
                age--;
            }

            return age;
        }


    }
}
