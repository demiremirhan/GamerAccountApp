using System;
using System.Collections.Generic;
using GamerAccountApp.Entities;
using GamerAccountApp.Interfaces;
using GamerAccountApp.ManagerServices;

namespace GamerAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer1 = new OldCustomer() { TcNo = "12151413162", PlayerName = "James", PlayerLastName = "Herson", BirthYear = 1996, ParticipantDate = 2015 };
            ICustomer customer2 = new OldCustomer() { TcNo = "13151416253", PlayerName = "Lonate", PlayerLastName = "dovar", BirthYear = 2000, ParticipantDate = 2016 };
            ICustomer customer3 = new OldCustomer() { TcNo = "87898685425", PlayerName = "Lorem", PlayerLastName = "Ipsum", BirthYear = 1999, ParticipantDate = 2016 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            GameManager gameManager = new GameManager();


            gameManager.Add(new Game() {GameName = "talent2", GameType = "Rpg", GamePrice = 24.99, ReleasedTime = 2023});
            gameManager.Add(new Game() { GameName = "orpto", GameType = "Action", GamePrice = 58.99, ReleasedTime = 2022 });
            gameManager.Add(new Game() { GameName = "thortum", GameType = "Story", GamePrice = 299, ReleasedTime = 2021 });

            
            customerManager.ListCustomer();
            gameManager.ListGame();
            
        }
    }
}
