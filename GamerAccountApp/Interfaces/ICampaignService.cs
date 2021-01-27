using System;
using System.Collections.Generic;
using System.Text;
using GamerAccountApp.Entities;

namespace GamerAccountApp.Interfaces
{
    interface ICampaignService
    {
        void SaleDiscount(Game games);
        void SaleInfo(Game games);
    }
}
