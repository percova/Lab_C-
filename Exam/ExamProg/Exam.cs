using System;

namespace ExamProg
{
    public class Exam
    {
        public int termNum;
        public string subjectName;
        public string teacherName;
        public int points;
        public bool differential;
        public System.DateTime passDate;

        public Exam(int termNum, string subjectName, string teacherName, int points, DateTime passDate)
        {
            this.termNum = termNum;
            this.subjectName = subjectName;
            this.teacherName = teacherName;
            this.points = points;
            this.passDate = passDate;
        }
        public Exam()
        {
            this.termNum = 0 ;
            subjectName = "subject";
            this.teacherName = "teacher";
            this.points = 0;
            this.passDate = DateTime.Today;
        }

        public override string ToString()
        {
            return subjectName + "  " + teacherName + "  " + points;
        }
    }
}