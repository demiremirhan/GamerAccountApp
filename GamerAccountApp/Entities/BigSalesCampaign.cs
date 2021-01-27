using System;
using System.Collections.Generic;
using System.Text;
using GamerAccountApp.Interfaces;

namespace GamerAccountApp.Entities
{
    class BigSalesCampaign : ICampaignService
    {
        public void SaleDiscount(Game games)
        {
            games.GamePrice -= games.GamePrice * (0.2);
            Console.WriteLine("Discount 20% for Everyone");
        }

        public void SaleInfo(Game games)
        {

            Console.WriteLine(" Awesome discount is " +games.GameName + games.GamePrice);
        }
    }
}
