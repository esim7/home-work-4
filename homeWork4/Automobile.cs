using System;
namespace homeWork4
{
    public partial class Automobile
    {
        //константная переменная дабы не использовать магические числа
        const int thisYear = 2019;

        private string _carBrand;
        private string _carModel;
        private int _power;
        private int _assemblyYear;
        private string _color;
        private int _price;
        private string _bodyType;
        //статические поля 
        //1. Общая соимость автомобилей данного класса 2. Количесвто автомобилей данного класса
        public static double _totalCarPrice;
        public static int _carCount;

        public Automobile()
        {
            CarBrand = "";
            CarModel = "";
            CarPrice = 0;
            //Увеличение стати-их полей класса при создании обьекта
            _totalCarPrice += _price;
            _carCount++;
        }
        public Automobile(string carBrand, string carModel, int price)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarPrice = price;
            _totalCarPrice += _price;
            _carCount++;
        }
        public Automobile(string carBrand, string carModel, int power, int assemblyYear, string color, int price, string bodyType)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarPower = power;
            if (assemblyYear > thisYear)
            {
                CarAssemblyYear = thisYear;
            }
            else
            {
                CarAssemblyYear = assemblyYear;
            }
            CarColor = color;
            CarPrice = price;
            CarBodyType = bodyType;
            _totalCarPrice += _price;
            _carCount++;
        }
        //Статический конструктор
        static Automobile()
        {
            _totalCarPrice = 0;
            _carCount = 0;
        }
        public string CarBrand
        {
            get
            {
                return _carBrand;
            }
            set
            {
                _carBrand = value;
            }
        }
        public string CarModel
        {
            get
            {
                return _carModel;
            }
            set
            {
                _carModel = value;
            }
        }
        public int CarPower
        {
            get
            {
                return _power;
            }
            set
            {
                _power = value;
            }
        }
        public int CarAssemblyYear
        {
            get
            {
                return _assemblyYear;
            }
            set
            {
                _assemblyYear = value;
            }
        }
        public string CarColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public int CarPrice
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string CarBodyType
        {
            get
            {
                return _bodyType;
            }
            set
            {
                _bodyType = value;
            }
        }

        //Метод в который передается аргумент по ссылке
        public void ChangeColor(ref Automobile automobile)
        {
            Console.WriteLine("Введите новый цвет автомобиля");
            string temp = Console.ReadLine();
            automobile._color = temp;
        }
        //3 метода управления классом
        //Метод инициализирующий поля класса
        public void Initialization()
        {
            string temp;
            int tmp;
            Console.WriteLine("Введите марку автомобиля: ");
            temp = Console.ReadLine();
            CarBrand = temp;
            Console.WriteLine("Введите модель автомобиля: ");
            temp = Console.ReadLine();
            CarModel = temp;
            Console.WriteLine("Введите мощность двигателя в л.с: ");
            tmp = int.Parse(Console.ReadLine());
            CarPower = tmp;
            Console.WriteLine("Введите год выпуска автомобиля: ");
            tmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цвет автомобиля: ");
            temp = Console.ReadLine();
            CarColor = temp;
            Console.WriteLine("Введите стоимость в тенге: ");
            tmp = int.Parse(Console.ReadLine());
            CarPrice = tmp;
            Console.WriteLine("Введите тип кузова: ");
            temp = Console.ReadLine();
            CarBodyType = temp;
        }
       
        //Перегруженные операторы > и < для сравнения двух автомобилей по цене
        public static bool operator !=(Automobile right, Automobile left)
        {
            if (right.CarPrice != left.CarPrice)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Automobile right, Automobile left)
        {
            if (right.CarPrice == left.CarPrice)
            {
                return true;
            }
            return false;
        }
    }
}
