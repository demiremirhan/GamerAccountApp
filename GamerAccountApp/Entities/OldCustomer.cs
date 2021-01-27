using System;
using System.Collections.Generic;
using System.Text;
using GamerAccountApp.Interfaces;

namespace GamerAccountApp.Entities
{
    class OldCustomer : ICustomer
    {
        public double ParticipantDate { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
