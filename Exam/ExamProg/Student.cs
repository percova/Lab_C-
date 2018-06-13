using System;
using System.Collections.Generic;

namespace ExamProg
{
    public class Student : Person
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation
        }

        public Education degree;
        public string groupName;
        public int creditBookNum;
        public System.Collections.Generic.List<Exam> passedExams = new List<Exam>();

        private double averagePoint
        {
            get
            {
                int sum = 0;
                foreach (Exam ex in passedExams)
                {
                    sum += ex.points;
                }

                return (double)(sum / passedExams.Count);
            }
        }

        public Student(string firstName, string lastName, DateTime birthDate, Education degree, int creditBookNum, string groupName) : base(firstName, lastName, birthDate)
        {
            this.degree = degree;
            this.creditBookNum = creditBookNum;
            this.groupName = groupName;
        }
        public Student()
        {
            this.degree = Education.Bachelor;
            this.creditBookNum = 0000;
            this.groupName = "XX-XX";
        }

        public void addExams(Exam[] examList)
        {
            passedExams.AddRange(examList);
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + groupName;
        }

        public override void printFullInfo()
        {
            Console.WriteLine("group name: {1}, number of credit book: {2}, average point: {3}" , Convert.ToString(degree), groupName, creditBookNum, averagePoint);
        }   
    }
}