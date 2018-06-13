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
            //set { birthDate.Year = value; }
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
            Console.WriteLine("First name: {1}, last name: {2}, date of birth: {3}", firstName, lastName, birthDate);
        }
    }
}