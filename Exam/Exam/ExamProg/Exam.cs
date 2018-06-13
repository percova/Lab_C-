using System;

namespace ExamProg
{
    public class Exam : IMarkName
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

        public string NationalScaleName()
        {
            /*switch (points)
            {
                    case 0 - 60 :
                        return "погано";
                    case 60 - 64 :
                        return "достатньо";
                    case 65 - 73 :
                        return "задовільно";
                    case 74 :
                        return "задовільно";
                    case 75 - 82 :
                        return "добре";
                    case 83 - 84 :
                        return "добре";
                    case 85 - 94 :
                        return "дуже добре";
                    case 95 - 100 :
                        return "відмінно";
                    default:
                        return "Not correct core was puted";
            }*/
            if (points > 0 && points < 60)
                return "погано";
            if (points >= 60 && points < 65)
                return "достатньо";
            if (points >= 65 && points < 74)
                return "задовiльно";
            if (points >= 75 && points < 85)
                return "добре";
            if (points >= 85 && points < 95)
                return "дуже добре";
            if (points >= 95 && points <= 100)
                return "вiдмiнно";
            else
            {
                return "Not rorrect score";
            }
        }

        public string EctsScaleName()
        {
            /*switch (points)
            {
                case 0 - 59:
                    return "F";
                case 60 - 64:
                    return "E";
                case 65 - 71:
                    return "D";
                case 72 - 74:
                    return "D";
                case 75 - 83:
                    return "C";
                case 84:
                    return "C";
                case 85 - 94:
                    return "B";
                case 95 - 100:
                    return "A";
                default:
                    return "Not correct core was puted";

            }*/
            if (points > 0 && points < 60)
                return "F";
            if (points >= 60 && points < 65)
                return "E";
            if (points >= 65 && points < 74)
                return "D";
            if (points >= 75 && points < 85)
                return "C";
            if (points >= 85 && points < 95)
                return "B";
            if (points >= 95 && points <= 100)
                return "A";
            else
            {
                return "Not rorrect score";
            }
        }
    }
}