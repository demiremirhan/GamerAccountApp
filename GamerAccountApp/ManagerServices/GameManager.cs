using System;
using System.Collections.Generic;
using System.Text;
using GamerAccountApp.Entities;

namespace GamerAccountApp.ManagerServices
{
    class GameManager
    {
        List<Game> games = new List<Game>() { };

        public void Add(Game games)
        {
            Console.WriteLine("{0}  game added.", games.GameName);

        }
        public void ListGame()
        {
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0}.Oyun\nOyun Adı:{1}\nÇıkış Yılı:{2}\nOyunun Türü:{3}\nOyunun Fiyatı:{4}\nOyunun İnceleme Puanı:{5}", i, game.GameName, game.ReleasedTime, game.GameType, game.GamePrice);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }
    }
}
