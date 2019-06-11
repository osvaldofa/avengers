using Avengers.Heroes.Data.Entities;
using Avengers.Heroes.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Heroes.Domain.Services
{
    public class HeroesService : IHeroesService
    {
        private IHeroesRepository _heroesRepository;

        public HeroesService(IHeroesRepository heroesRepository)
        {
            _heroesRepository = heroesRepository;
        }

        public string GetHero(int heroId)
        {
            return _heroesRepository.GetHeroById(heroId).Name;
        }

        public string[] GetHeroes()
        {
            List<Hero> heroes = _heroesRepository.GetHeroes();
            string[] heroNames = null;

            if (heroes != null && heroes.Count > 0)
            {
                heroNames = new string[heroes.Count];
                for (int i = 0; i < heroes.Count; i++)
                {
                    heroNames[i] = heroes[i].Name;
                }
            }
            return heroNames;
        }
    }
}
