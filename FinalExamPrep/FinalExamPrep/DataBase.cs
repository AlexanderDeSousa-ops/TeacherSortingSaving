using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class DataBase
    {
        private int id;
        private string name;
        private string surname;

        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public DataBase(int id, string name, string surname)
        {
            if(id <= 0 || id > 500)
            {
                throw new Exception("id must be between 1 and 500");
            }
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new Exception("name and surname cannot be null or empty");
            }
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
        public DataBase(DataBase d) //copy
        {
            id = d.id;
            name = d.name;
            surname = d.surname;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID: {id}    Name: {name}    Surname: {surname}");
        }

    }
}
