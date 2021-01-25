using ProjeGame.Consrete;
using ProjeGame.Entities;
using System;
using System.Collections.Generic;

namespace ProjeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            GameManager gameManager = new GameManager();
            List<Player> players = new List<Player>();
            Player player1 = new Player();
            player1.Id = 1;
            player1.NationaltyId = "12345678901";
            player1.FirstName = "Yasin";
            player1.LastName = "ÖZDEL";
            player1.DateOfBirth=  new DateTime(1997,4,28);
            player1.Type = 1;
            players.Add(player1);

            Player player2 = new Player();
            player2.Id = 2;
            player2.NationaltyId = "12345678902";
            player2.FirstName = "Hasan";
            player2.LastName = "ÖZDEL";
            player2.DateOfBirth = new DateTime(1996, 4, 28);
            player2.Type = 2;
            players.Add(player2);

            Player player3 = new Player();
            player3.Id = 3;
            player3.NationaltyId = "12345678903";
            player3.FirstName = "Harun";
            player3.LastName = "ÖZDEL";
            player3.DateOfBirth = new DateTime(1995, 4, 28);
            player3.Type = 3;
            players.Add(player3);

            foreach (var player in players)
            {
                playerManager.Add(player);
            }

            Game game1 = new Game() { Id = 1, Type = 1, Name = "Minecraft", ReleaseYear = "2017", price = 110 };
            Game game2 = new Game() { Id = 2, Type = 2, Name = "Counter-Strike", ReleaseYear = "2000", price = 150 };
            Game game3 = new Game() { Id = 3, Type = 3, Name = "Cyberpunk 2077", ReleaseYear = "2020", price = 175 };
            Game game4 = new Game() { Id = 4, Type = 1, Name = "Grand Theft Auto V", ReleaseYear = "2013", price = 90 };
            Game game5 = new Game() { Id = 5, Type = 2, Name = "Red Dead Redemption 2", ReleaseYear = "2018", price = 50 };
            Game game6 = new Game() { Id = 6, Type = 3, Name = "Call of Duty: Modern Warfare", ReleaseYear = "2019", price = 200 };

            List<Game> games = new List<Game>();
            foreach (var game in games)
            {
                gameManager.Add(game);
            }

            gameManager.Sales(game4, player2);// kullanıcı tipine göre indirim uyguluyor.
        }
    }
}
