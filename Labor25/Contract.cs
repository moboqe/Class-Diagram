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
            r.Remove(newflat);
            if (newflat!=null)
            Console.WriteLine(customer.Name+" заключил договор на квартиру по адресу "+ newflat.Address+". На сумму "+(newflat.Market_price+Company.Margin)+" рублей. Маржа агенства составила "+ Company.Margin + " рублей");
            else  Console.WriteLine(customer.Name + " отклонил договор");
        }
    }
}
