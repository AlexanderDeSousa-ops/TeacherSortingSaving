using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPrep
{
    public class GenericClass<T , S>
    {
        private T x;
        private S y;

        public GenericClass()
        {
            x = default(T);
            y = default(S);
        }
        public GenericClass(T x, S y)
        {
            this.x = x;
            this.y = y;
        }
        public S Gety()
        {
            return y;
        }
        public void SetY(S y)
        {
            this.y = y;
        }
        public T GetX()
        {
            return x;
        }
        public void SetX(T x)
        {
            this.x = x;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"the value of x is: {x}");
            Console.WriteLine($"the value of y is: {y}");
        }
    }
}
