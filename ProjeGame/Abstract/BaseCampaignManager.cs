using ProjeGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Abstract
{
    public abstract class BaseCampaignManager : ICampaignManager
    {
        public virtual void calculate(Game game)
        {
            Console.Write("İndirimli Fiyat : ");
        }
    }
}
