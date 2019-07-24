using System;
namespace homeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile automobile = new Automobile("BWB", "525", 240, 2050, "WHITE", 3300000, "Sedan");
            Automobile automobile1 = new Automobile("AUDI", "A6", 210, 2010, "Black", 4600000, "Sedan");
            Console.WriteLine(automobile.CarAssemblyYear);
            Console.WriteLine(automobile.CarColor);
            automobile.ChangeColor(ref automobile);
            Console.WriteLine(automobile.CarColor);
            Console.WriteLine(Automobile._carCount);
            Console.WriteLine(Automobile._totalCarPrice);
            automobile.Initialization();
            automobile.Print();
            Console.ReadKey();
        }
    }
    //метод обьявленный вне класса
    public partial class Automobile
    {
        //Метод вывода в консоль
        public void Print()
        {
            Console.WriteLine(CarBrand + "  " + CarModel + "  " + CarPower + "  " + CarAssemblyYear
                + "  " + CarColor + "  " + CarPrice + "  " + CarBodyType);
        }
    }
}
