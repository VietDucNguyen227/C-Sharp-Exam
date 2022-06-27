using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Exam
{
    class Product
    {

        private string _id;
        private string _name;
        private double _price;

        public Product(string id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

        public override string ToString()
        {
            return String.Format("Product's ID: {0} || Product's Name: {1} || Product's Price: {2,6:C}", _id, _name, _price);
        }
    }
}
