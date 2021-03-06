﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Car
    {
         public string Name { get; set; }
        public string CarCode { get; set; }
        public string ProductDate { get; set; }
        public User Owner { get; set; }
        public int PathNumber = 0;

        public Car(string Name, string CarCode, string ProductDate, User Owner)
        {
            this.Name = Name;
            this.CarCode = CarCode;
            this.ProductDate = ProductDate;
            this.Owner = Owner;


        }
        public bool IsValid()
        {

            bool B1 = int.TryParse(CarCode.Substring(0, 2), out int n);
            bool B2 = int.TryParse(CarCode.Substring(3), out int m);
            bool B3 = char.IsUpper(CarCode[2]);

            if (!B1 || !B2 || !B3)
            {
                return false;
            }
            return true;
        }
        public bool IsNative()
        {
            if (this.CarCode[CarCode.Length - 1] == this.CarCode[CarCode.Length - 2])
                return true;

            return false;


        }
        public bool IsIn()
        {
            this.PathNumber++;
            if ((PathNumber % 2 == 0 && IsNative()) || (PathNumber % 2 == 1 && IsNative() == false))
                return true;

            return false;
        }
    }
}
