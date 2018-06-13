using System;

namespace ExamProg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Victoria", "Bondar", new DateTime(1998, 11, 23),
                    Student.Education.Bachelor, 6302, groupName: "IP-63");
                //Console.WriteLine(student.checkCreditNum);

                Exam subj1 = new Exam(4, "Data bases", "Nedash", 95, (DateTime.Today));
                Exam subj2 = new Exam(3, "OOP", "Muha", 80, new DateTime(2018, 01, 15));
                Exam subj3 = new Exam(4, "Algo", "Maxim", 85, new DateTime(2018, 06, 22));
                Exam[] examList = new[] {subj1, subj2, subj3};
                student.addExams(examList);
                Console.WriteLine(student.ToString());
                student.printFullInfo();

                Console.WriteLine("Data base mark in national scale = " + subj1.NationalScaleName());
                Console.WriteLine("OOP mark in ECTS scale = " + subj2.EctsScaleName());
                Console.WriteLine(student.ageCount());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}