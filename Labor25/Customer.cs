using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    public class Customer : Client, Imethods //ОБОБЩЕНИЕ(generalization), РЕАЛИЗАЦИЯ(realization)
    {
        public double Space { get; set; }
        public int Floor { get; set; }
        public int Room { get; set; }
        public double Market_price { get; set; }

        public List<Flat> cflat = new List<Flat>(); //КОМПОЗИЦИЯ

        public Customer() { }
        public Customer(string a, string b, string c, int d)
        {
            this.Name = a;
            this.ID = b;
            this.Age = d;
            this.Phone = c;
        }

        public void setCriteria(double a, int b, int c, double d)
        {
            this.Space = a;
            this.Floor = b;
            this.Room = c;
            this.Market_price = d;
        }
        public void getFlat()
        {
            foreach (var person in cflat)
                person.getFlat();
        }
        public void deleteFlat(Flat r)
        {
            cflat.Remove(r);
        }
        public void getINFO()
        {
            Console.WriteLine("Покупатель — " + Name + ". Паспорт — " + ID + ". Возраст " + Age + " лет. Телефон — " + Phone + "\n");
        }
        public Flat Choosing(List<Flat> r) // ВЫБОРКА ПОДХОДЯЩЕЙ КВАРТИРЫ ИЗ СПИСКА КВАРТИР
        {
            Random rand = new Random();
            List<Flat> flats = new List<Flat>();
            Flat newFlat;
            for(int i=0;i<r.Count;i++)
            if (r[i].Floor >= this.Floor && r[i].Room >= this.Room && r[i].Space >= this.Space && r[i].Market_price <= this.Market_price)
                flats.Add(r[i]);

           
           return newFlat = flats[rand.Next(flats.Count)];
        }
    }
}
