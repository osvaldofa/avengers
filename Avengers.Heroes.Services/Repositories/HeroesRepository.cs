using Avengers.Heroes.Data.Entities;
using Avengers.Heroes.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Heroes.Data.Data
{
    public class HeroesRepository : IHeroesRepository
    {
        private List<Hero> heroesDatabase;

        public HeroesRepository()
        {
            heroesDatabase = new List<Hero>();
            heroesDatabase.Add(new Hero(1, "Superman"));
            heroesDatabase.Add(new Hero(2, "Batman"));
            heroesDatabase.Add(new Hero(3, "Capitão América"));
            heroesDatabase.Add(new Hero(4, "Homem de Ferro"));
        }

        public Hero GetHeroById(int id)
        {
            return heroesDatabase.Find(x => x.Id == id);
        }

        public List<Hero> GetHeroes()
        {
            return heroesDatabase;
        }
    }
}
