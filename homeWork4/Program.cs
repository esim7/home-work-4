using System;
namespace homeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = 5;
            Automobile[] array = new Automobile[arrSize];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Automobile();
                array[i].Initialization();
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Print();
            }
            Console.WriteLine("Общее количество автомобилей = " + Automobile._carCount + "\n" + "Общая стоимость всех автомобилей = " + Automobile._totalCarPrice + " тенге");
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
