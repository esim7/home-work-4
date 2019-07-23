using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4
{
    class Automobile
    {
        private string _carBrand;
        private string _carModel;
        private int _power;
        private int _assemblyYear;
        private string _color;
        private double _price;
        private string _bodyType;

        public Automobile()
        {
            _carBrand = "";
            _carModel = "";
        }
        public Automobile(string carBrand, string carModel, int power, int assemblyYear)
        {
            _carBrand = carBrand;
            _carModel = carModel;
            _power = power;
            _assemblyYear = assemblyYear;
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
