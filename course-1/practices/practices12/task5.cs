using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var transport = new Transport();
            var car = new Car();
            var tesla = new ElectricCat();

            transport.Drive();
            car.Drive();
            tesla.Drive();
        }
    }

    public class Transport
    {
        public virtual void Drive()
        {
            Console.WriteLine("Транспорт движется");
        }
    }
    public class Car : Transport
    {
        public override void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class ElectricCat : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Электромобиль тихо едет на батарее");
        }
    }
}
