using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4
{ 
    class Automobile
    {
        //константная переменная дабы не использовать магические числа
        const int thisYear = 2019;

        private string _carBrand;
        private string _carModel;
        private int _power;
        private int _assemblyYear;
        private string _color;
        private double _price;
        private string _bodyType;
        //статические поля 
        //1. Общая соимость автомобилей данного класса 2. Количесвто автомобилей данного класса
        public static double _totalCarPrice;
        public static int _carCount;

        public Automobile()
        {
            _carBrand = "";
            _carModel = "";
            _price = 0;
            _totalCarPrice += _price;
            _carCount++;
        }
        public Automobile(string carBrand, string carModel, int power, int assemblyYear, string color, double price, string bodyType)
        {
            _carBrand = carBrand;
            _carModel = carModel;
            _power = power;
            if (_assemblyYear > thisYear)
            {
                _assemblyYear = thisYear;
            }
            else
            {
                _assemblyYear = assemblyYear;
            }
            _color = color;
            _price = price;
            _bodyType = bodyType;
            //При создании обекта класса статические переменные будут увеличены
            _totalCarPrice += _price;
            _carCount++;
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
        public int Power
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
        public int AssemblyYear
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
            public string Color
        {
            get
            {
                return _color; ;
            }
            set
            {
                _color = value;
            }
        }
        public double Price
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
        public string BodyType
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

    }
}
