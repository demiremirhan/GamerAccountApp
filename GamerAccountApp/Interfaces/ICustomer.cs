using System;
using System.Collections.Generic;
using System.Text;

namespace GamerAccountApp.Interfaces
{
    interface ICustomer
    {
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
