using ProjeGame.Abstract;
using ProjeGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Consrete
{
    public class GameManager
    {

        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("{0} isimli oyun eklendi.", game.Name);
        }

        public void Delete(int Id)
        {
            foreach (var game in games)
            {
                if (game.Id == Id)
                {
                    games.Remove(game);
                    Console.WriteLine("{0} , isimli oyun sistemden silindi.", game.Name);
                    break;
                }
            }

        }

        public void ListGame()
        {
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0} Id'li Oyun\nOyun Adı : {1}\nÇıkış Yılı : {2}\nOyunun Türü : {3}\nOyunun Fiyatı : {4}", game.Id, game.Name, game.ReleaseYear, game.Type, game.price);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }

        public void Sales(Game game,Player player)
        {
            switch (player.Type)
            {
                case 1:
                    BaseCampaignManager standartCampaignManager = new StandartCampaignManager();
                    standartCampaignManager.calculate(game);
                    Console.WriteLine("{0} adlı oyun {1} fiyatına {2} oyuncusu tarafından alındı.",game.Name,game.price,player.FirstName);
                    break;
                case 2:
                    BaseCampaignManager studentCampaignManager = new StudentCampaignManager();
                    studentCampaignManager.calculate(game);
                    Console.WriteLine("{0} adlı oyun {1} fiyatına {2} oyuncusu tarafından alındı.", game.Name, game.price, player.FirstName);
                    break;
                case 3:
                    BaseCampaignManager endOfYearCampaignManager = new EndOfYearCampaignManager();
                    endOfYearCampaignManager.calculate(game);
                    Console.WriteLine("{0} adlı oyun {1} fiyatına {2} oyuncusu tarafından alındı.", game.Name, game.price, player.FirstName);
                    break;
            }
        }
    }
}
