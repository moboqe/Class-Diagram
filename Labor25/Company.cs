using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    class Company
    {
        public static List<Flat> flat = new List<Flat>(); //КОМПОЗИЦИЯ

        private static string c_name { get; } = "Гранат";
        public static void PrintName()
        {
            Console.Write("Агенство недвижимости ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(c_name+"\n");
            Console.ResetColor();
        }

        public void ShowFlats()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Список квартир в базе агенства: \n");
            Console.ResetColor();
            int i = 0;
            foreach (var person in flat)
            {
                Console.Write("\n"+(i + 1)+". ");
                person.getFlat();
                i++;
            }
        }

        public void AddToBase(Seller obj)
        {
            // targetList.AddRange(sourceList);

            flat.AddRange(obj.sflat);
        }

    }
}
