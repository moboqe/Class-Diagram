using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    class Customer : Client //ОБОБЩЕНИЕ(generalization)
    {
        public List<Flat> cflat = new List<Flat>(); //КОМПОЗИЦИЯ

        public Customer() { }
        public Customer(string a, string b, string c, int d)
        {
            this.Name = a;
            this.ID = b;
            this.Age = d;
            this.Phone = c;
        }

        public void setFlat(Flat newRoom)
        {
            cflat.Add(newRoom);
        }
        public void getFlat()
        {
            foreach (var person in cflat)
                person.getFlat();
        }
        public void deleteRoom(Flat r)
        {
            cflat.Remove(r);
        }
        public void getINFO()
        {
            Console.WriteLine("Покупатель — " + Name + ". Паспорт — " + ID + ". Возраст " + Age + " лет. Телефон — " + Phone + "\n");
        }
    }
}
