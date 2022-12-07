using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    internal class Истребитель : Авиасредство, IMaxHeight
    {
        protected int weaponCount;
        public Истребитель(string pName, int pPrice, int pMaxHeight, int pWeaponCount) : base(pName, pPrice, pMaxHeight)
        {
            weaponCount = pWeaponCount;
        }
        new public void GetMaxHeight()
        {
            Console.WriteLine("Максимальная высота истребителя: " + maxHeight.ToString());
        }
        override public string GetName()
        {
            return name + " Количество оружия: " + weaponCount.ToString();
        }
    }
}
