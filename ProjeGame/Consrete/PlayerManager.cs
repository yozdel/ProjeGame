using ProjeGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Consrete
{
    class PlayerManager
    {
        List<Player> players = new List<Player>() { };
        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine("{0} {1}, isimli oyuncu sisteme eklendi.", player.FirstName, player.LastName);
        }

        public void Delete(int Id)
        {
            foreach (var player in players)
            {
                if (player.Id == Id)
                {
                    players.Remove(player);
                    Console.WriteLine("{0} {1}, isimli oyuncu sistemden silindi.", player.FirstName, player.LastName);
                    break;
                }

                /*else
                {
                    continue;
                }*/
            }
        }
        public void ListPlayer()
        {
            
            foreach (var player in players)
            {
                
                Console.WriteLine("{0}.Id'li\nAd Soyad : {1} {2}\nTc No : {3}\nDoğum Yılı : {4}\nTipi : {5}\n", player.Id, player.FirstName, player.LastName, player.NationaltyId, player.DateOfBirth,player.Type);
                
                
            }
        }

    }
}
