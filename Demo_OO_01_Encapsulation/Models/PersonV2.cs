namespace Demo_OO_01_Encapsulation.Models
{
    internal class PersonV2
    {
        // Champs (Fields)
        private string _Firstname;
        private string _Lastname;

        // Props
        // - Prop full
        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }

        // - Prop full
        public string Lastname
        {
            get { return _Lastname.ToUpper(); }
            set { _Lastname = value; }
        }


        // - Auto Prop
        public DateTime BirthDate { get; set; }

        // - Calc Prop
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - BirthDate.Year;

                DateTime currentBirthday = new DateTime(
                    DateTime.Today.Year,
                    BirthDate.Month,
                    BirthDate.Day
                );
                if (DateTime.Today.CompareTo(currentBirthday) > 0)
                {
                    age--;
                }

                return age;
            }
        }
    }
}
