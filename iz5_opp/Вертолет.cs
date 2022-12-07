using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class Вертолет : Авиасредство, IMaxHeight
    {
        protected bool isMilitary;
        public Вертолет(string pName, int pReseaseYear, int pMaxHeight, bool pIsMilitary) : base(pName, pReseaseYear, pMaxHeight)
        {
            isMilitary = pIsMilitary;
        }
        new public void GetMaxHeight()
        {
            Console.WriteLine("Максимальная высота вертолета: " + maxHeight.ToString());
        }
        override public string GetName()
        {
            return name + " Максимальная высота полета вертолета: " + maxHeight.ToString();
        }
    }
}
