using ProjeGame.Abstract;
using ProjeGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Consrete
{
    class EndOfYearCampaignManager : BaseCampaignManager
    {
        double campaignRate = 0.20;
        public override void calculate(Game game)
        {
            game.price -= game.price * campaignRate;
            Console.WriteLine("Kampanya Uygulanmış Oyun Fiyatı : {0}", game.price);
        }
    }
}
