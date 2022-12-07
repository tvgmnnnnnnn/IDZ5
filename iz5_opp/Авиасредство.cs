using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class Авиасредство : ТехСредство, IMaxHeight
    {
        protected int maxHeight;
        public Авиасредство(string pName, int pPrice, int pMaxHeight) : base(pName, pPrice)
        {
            maxHeight = pMaxHeight;
        }
        public void GetMaxHeight()
        {
            Console.WriteLine("Максимальная высота: " + maxHeight.ToString());
        }
        override public string GetName()
        {
            return name + " Максимальная высота полета: " + maxHeight.ToString();
        }
    }
}
