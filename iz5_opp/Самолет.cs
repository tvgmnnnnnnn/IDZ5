using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class Самолет : Авиасредство, IMaxHeight
    {
        protected int maxCapacity;
        public Самолет(string pName, int pReseaseYear, int pMaxHeight, int pMaxCapacity) : base(pName, pReseaseYear, pMaxHeight)
        {
            maxCapacity = pMaxCapacity;
        }

        new public void GetMaxHeight()
        {
            Console.WriteLine("Максимальная высота: " + maxHeight.ToString());
        }

        override public string GetName()
        {
            return name + " Максимальная высота полета данного самолета: " + maxHeight.ToString();
        }
    }
}
