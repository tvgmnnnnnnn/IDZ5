using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class ЛегковойАвтомобиль : Автомобиль, IPrice
    {
        protected bool isAuto;
        public ЛегковойАвтомобиль(string pName, int pPrice, int pMaxSpeed, bool pIsAuto) : base(pName, pPrice, pMaxSpeed)
        {
            isAuto = pIsAuto;
        }
        override public string GetName()
        {
            return name + " Максимальная скорость легковой машины: " + maxSpeed.ToString();
        }
        new public void GetPrice()
        {
            Console.WriteLine("Цена легкового автомобиля: " + price);
        }
    }
}
