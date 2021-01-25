using ProjeGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeGame.Entities
{
    public class Player : IEntity
    {

        public int Id { get; set; }
        public string NationaltyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Type { get; set; }


    }
}
