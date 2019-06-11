using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Heroes.Data.Entities
{
    public class Hero
    {
        public int Id { set; get; }
        public string Name { get; set; }

        public Hero(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
