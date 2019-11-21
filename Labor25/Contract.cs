using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor25
{
    public class Contract
    {

        public void SignContract(Customer customer, List<Flat> r)
        {
           Flat newflat=customer.Choosing(r);
            Seller seller = new Seller();
            seller.deleteFlat(newflat);
            Console.WriteLine(customer+" заключил договор на квартиру "+ newflat);
            Console.WriteLine(customer + " отклонил договор");
        }
    }
}
