using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Heroes.Domain.Services
{
    public interface IHeroesService
    {
         string GetHero(int heroId);

        string[] GetHeroes();

    }
}
