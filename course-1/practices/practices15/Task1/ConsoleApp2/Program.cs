using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo =
{
    new Dog("Шарик"),
    new Cat("Мурка"),
    new Elephant("Дамбо"),
    new Animal("Неопознанный")
};

            foreach (var a in zoo)
            {
                a.MakeSound(); // у каждого -- свой результат
            }

        }

        
    }
    

}
