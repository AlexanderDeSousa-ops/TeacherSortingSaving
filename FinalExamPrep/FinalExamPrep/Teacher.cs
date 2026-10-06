using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class Teacher : DataBase , IBonusEligible
    {
        private string subject;
        private int experience;

        public Teacher(int id, string name, string surname, string subject, int experience) : base(id, name, surname)
        {
            
            this.subject = subject;
            this.experience = experience;
        }

        public string GetSubject()
        {
            return subject;
        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }
        public int GetExperience()
        {
            return experience;
        }
        public void SetExperience(int experience)
        {
            this.experience = experience;
        }

        public void ExperienceCheck(int experience)
        {
            if(experience < 0 || experience > 50)
            {
                throw new Exception("experience must be between 0 and 50");
            }

            if(experience < 5)
            {
                Console.WriteLine("new teacher");
            }
            else if(experience >= 5 && experience < 15)
            {
                Console.WriteLine("junoir teacher");
            }
            else
            {
                Console.WriteLine("experienced teacher");   
            }


        }

        public override void ShowInfo()
        {

            base.ShowInfo();
            Console.WriteLine($"Subject: {subject}    Experience: {experience} years");
        }

        public double CalculateBonus()
        {
            return experience * 1000;
        }

        public string GetProformanceLevel()
        {
            if (experience < 5)
            {
                return "New Teacher";
            }
            else if (experience >= 5 && experience < 15)
            {
                return "Junior Teacher";
            }
            else
            {
                return "Experienced Teacher";
            }
        }
    }
}
