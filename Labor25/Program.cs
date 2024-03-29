﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    class Program
    {

        static void Main(string[] args)
        {

            Company.PrintName(); // Вывод названия Агенства недвижимости
            Company comp = new Company();
            Contract contr = new Contract();

            Customer customer1 = new Customer("Кирилл", "1234 567890", "8(952)6540912", 24);
            customer1.setCriteria(60, 1, 3, 2400000);
            customer1.getINFO();
            Seller seller1 = new Seller("Ульяна", "0987 654321", "8(912)3709211", 26);
            seller1.getINFO();
            

            Flat fl1 = new Flat("Ленина, 20", 85.1, 1, 3, 3400000);

            seller1.setFlat(fl1);

            seller1.getFlat();
                                  

            Customer customer2 = new Customer("Александр", "1352 409876", "8(922)1127612", 55);
            customer2.setCriteria(85.1, 2, 3, 3400000);
            customer2.getINFO();
            Seller seller2 = new Seller("Павел", "1234 098765", "8(919)1916537", 41);
            seller2.getINFO();

            Flat fl2 = new Flat("Островского, 32", 120.5, 2, 4, 1200000);

            seller2.setFlat(fl2);

            seller2.getFlat();

            Seller seller3 = new Seller("Павел", "1234 098765", "8(919)1916537", 41);
            seller2.getINFO();

            Flat fl3 = new Flat("Уральская, 10", 100.5, 12, 4, 2200000);

            seller3.setFlat(fl3);

            seller3.getFlat();



            comp.AddToBase(seller1);
            comp.ShowFlats();
            comp.AddToBase(seller2);
            comp.ShowFlats();
            comp.AddToBase(seller3);
            comp.ShowFlats();

            contr.SignContract(customer1, Company.flat);
            contr.SignContract(customer2, Company.flat);


            Console.ReadLine();

        }
    }
}
