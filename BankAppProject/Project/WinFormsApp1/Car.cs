using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Car
    {
        public string price { get; set; }
        public string carDealer { get; set; }
        public string typeOfEngine { get; set; }
        public string kmDriven { get; set; }
        public string color { get; set; }

        public string model { get; set; }
        public Car() { }
        public Car(string price, string carDealer, string typeOfEngine, string kmDriven, string color, string model)
        {
            this.price = price;
            this.carDealer = carDealer;
            this.typeOfEngine = typeOfEngine;
            this.kmDriven = kmDriven;
            this.color = color;
            this.model = model;
        }
        public bool CheckIfFilled()
        {
            if (price=="" || carDealer=="" || typeOfEngine =="" || kmDriven == ""|| color =="" || model =="")
            {
                return false;
            }
            else { return true; }
        }
    }
}
