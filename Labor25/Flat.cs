using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    public class Flat
    {
        public string Address { get; set; }
        public string Space { get; set; }
        public string Floor { get; set; }
        public int Room { get; set; }
        public int Market_price { get; set; }
        public Flat() { }
        public Flat(string a, string b, string c, int d, int e)
        {
            Address = a;
            Space = b;
            Floor = c;
            Room = d;
            Market_price = e;
        }
        public void getFlat()
        {
            Console.WriteLine("Квартира по адресу " + Address + ". С общей площадью " + Space + " квадратных метров. На " + Floor + " этаже. " + Room + " комнаты. По цене " + Market_price + " рублей\n");
        }

    }
}