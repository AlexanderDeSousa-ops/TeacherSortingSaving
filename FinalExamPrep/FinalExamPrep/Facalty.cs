using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class Facalty : DataBase
    {
        private int yearsWorked;
        private int TaskesCompleted;

        public Facalty(int id, string name, string surname, int yearsWorked, int TaskesCompleted) : base(id, name, surname)
        {
            this.yearsWorked = yearsWorked;
            this.TaskesCompleted = TaskesCompleted;
        }

        public int GetYearsWorked()
        {
            return yearsWorked;
        }
        public void SetYearsWorked(int yearsWorked)
        {
            this.yearsWorked = yearsWorked;
        }
        public int GetTaskesCompleted()
        {
            return TaskesCompleted;
        }
        public void SetTaskesCompleted(int taskesCompleted)
        {
            this.TaskesCompleted = taskesCompleted;
        }

        public void TaskesCheck(int TaskesCompleted)
        {
            if(TaskesCompleted < 0 || TaskesCompleted > 100)
            {
                throw new Exception("taskes completed cannot be less than zero or more than 100");
            }
            if(TaskesCompleted  > 10)
            {
                Console.WriteLine("beginner");
            }
            else if(TaskesCompleted >= 10 && TaskesCompleted < 50)
            {
                Console.WriteLine("intermeiant");
            }
            else
            {
                Console.WriteLine("expert");
            }
        }
        public override void ShowInfo()
        {

            base.ShowInfo();
            Console.WriteLine($"Years Worked: {yearsWorked}");
            Console.WriteLine($"Taskes Completed: {TaskesCompleted}");
        }
    }
}
