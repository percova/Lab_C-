using System;

namespace ExamProg
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public System.DateTime birthDate;

        public int birthYear
        {
            get { return birthDate.Year; }
            set { new DateTime(value, birthDate.Month, birthDate.Day); }
        }

        public Person()
        {
            this.firstName = "first name";
            this.lastName = "last name";
            this.birthDate = DateTime.Today;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public virtual void printFullInfo()
        {
            Console.WriteLine("First name: {0}, last name: {1}, date of birth: {2}", firstName, lastName, birthDate);
        }

        public int ageCount()
        {
            var daysTillNow = (DateTime.Today.Year * 100 + DateTime.Today.Month) * 100 + DateTime.Today.Day;
            var daysFromBirth = (birthDate.Year * 100 + birthDate.Month) * 100 + birthDate.Day;
            return (daysTillNow - daysFromBirth) / 10000;
        }
    }
}