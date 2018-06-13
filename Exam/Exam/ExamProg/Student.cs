using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
        public int checkCreditNum
        {
            get { return creditBookNum;}
            set
            {
                    if (creditBookNum <= 999999999)
                        throw new Exception("Entered value is less or equal then 999999999 OR bigger then 9999999999");
                    if (creditBookNum > 999999999)
                        throw new Exception("Entered value is less or equal then 999999999 OR bigger then 9999999999");   
            }
        }

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
            Console.WriteLine("Education degree: {0}, group name: {1}, average point: {2}" , Convert.ToString(degree), groupName, averagePoint);
        }   
        
        public IEnumerable<string> ByExams(bool exams)
        {
            foreach (var b in this.passedExams)
            {
                if (b.differential == exams)
                    yield return b.subjectName;
               
            }
        }
    }
}