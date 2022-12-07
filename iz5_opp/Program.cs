using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz5_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ТехСредство>();
            var t1 = new ТехСредство("Трактор", 2549200);
            var t2 = new Автомобиль("Автобус", 24000000, 220);
            t2.GetPrice();
            var t3 = new Авиасредство("Квадрокоптер", 25200, 5002);
            t3.GetMaxHeight();
            var t4 = new Истребитель("Истребитель-2000", 500000, 2500, 9);
            t4.GetMaxHeight();
            var t5 = new Самолет("Стрела", 9999999, 7990, 24);
            t5.GetMaxHeight();
            var t6 = new Вертолет("Вертолет", 8000000, 8000, false);
            t6.GetMaxHeight();
            var t7 = new ЛегковойАвтомобиль("Honda", 1200000, 290, true);
            t7.GetPrice();
            var t8 = new ГрузовойАвтомобиль("Грузовик", 8599000, 200, 2200);
            t8.GetPrice();
            Console.WriteLine();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);
            list.Add(t4);
            list.Add(t5);
            list.Add(t6);
            list.Add(t7);
            list.Add(t8);
            foreach (var item in list)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
