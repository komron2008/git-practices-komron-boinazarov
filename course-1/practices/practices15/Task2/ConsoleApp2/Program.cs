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
            var zooPark = new Zoo(5);
            zooPark.Add(new Dog("Рекс"));
            zooPark.Add(new Cat("Снежок"));
            zooPark.Add(new Elephant("Балу"));

            Console.WriteLine("=== Звуки ===");
            zooPark.MakeAllSounds();

            Console.WriteLine("=== Кормим ===");
            zooPark.FeedAll();

        }

        
    }
    

}
