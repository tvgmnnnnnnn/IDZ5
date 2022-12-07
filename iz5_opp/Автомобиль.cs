using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class Автомобиль : ТехСредство, IPrice
    {
        protected int maxSpeed;
        public Автомобиль(string pName, int pPrice, int pMaxSpeed) : base(pName, pPrice)
        {
            maxSpeed = pMaxSpeed;
        }

        override public string GetName()
        {
            return name + "Максимальная скорость машины: " + maxSpeed.ToString();
        }

        public void GetPrice()
        {
            Console.WriteLine("Цена: " + price);
        }
    }
}
