using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class Student : DataBase
    {
        private double grade;
        private string group;

        public Student(int id, string name, string surname, double grade , string group ) : base(id, name, surname)
        {
            this.grade = grade;
            this.group = group;
        }

        public double GetGrade()
        {
            return grade;
        }
        public void SetGrade(double grade)
        {
            this.grade = grade;
        }
        public string GetGroup()
        {
            return group;
        }
        public void SetGroup(string group)
        {
            this.group = group;
        }

        public void GradeCheck(double grade)
        {
            if (grade >= 100 || grade < 0)
            {
                throw new Exception("grade cannot be less than zero or more than 100");
            }
            if(grade < 60)
            {
                Console.WriteLine("failed");
            }
            else
            {
                Console.WriteLine("passed");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Grade: {grade}     Group: {group}");
        }
    }
}
