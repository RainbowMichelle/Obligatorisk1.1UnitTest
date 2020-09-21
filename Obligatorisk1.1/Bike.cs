using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Obligatorisk1._1
{
    public class Bike
    {
        private int _id;
        private string _color;
        private int _price;
        private int _gear;


        public Bike(int id, string color, int price, int gear)
        {
            ID = id;
            Color = color;
            Price = price;
            Gear = gear;
        }


        public int ID
        {
            get { return _id; }
            set 
            {
                    _id = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set 
            {
                if (value.Length < 1)
                {
                    throw new Exception("please insert a color");
                }
                else
                {
                    _color = value;
                }
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("please insert a price (price cannot be negative values");
                }
            }
        }

        public int Gear
        {
            get { return _gear; }
            set 
            {
                if (value >= 3 && value <= 32)
                {
                    _gear = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("please insert numbers of gears (between 3 and 32)");
                }
            }
        }


    }
}
