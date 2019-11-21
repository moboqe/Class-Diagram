using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    public class Seller : Client, Imethods //ОБОБЩЕНИЕ(generalization), РЕАЛИЗАЦИЯ(realization)
    {
        public List<Flat> sflat = new List<Flat>(); //КОМПОЗИЦИЯ

        public Seller() { }
        public Seller(string a, string b, string c, int d)
        {
            this.Name = a;
            this.ID = b;
            this.Age = d;
            this.Phone = c;
        }
        public void setFlat(Flat newRoom)
        {
            sflat.Add(newRoom);
        }
        public void getFlat()
        {
            foreach (var person in sflat)
                person.getFlat();
        }
        public void deleteFlat(Flat r)
        {
            sflat.Remove(r);
        }

        public void getINFO()
        {
            Console.WriteLine("Продавец — " + Name+ ". Паспорт — " + ID+". Возраст "+Age+ " лет. Телефон — " + Phone+"\n");
        }

    }
}
