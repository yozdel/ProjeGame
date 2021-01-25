using ProjeGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string ReleaseYear { get; set; }
        public double price { get; set; }


    }
}
