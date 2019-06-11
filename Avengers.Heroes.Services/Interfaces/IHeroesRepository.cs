using Avengers.Heroes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Heroes.Data.Interfaces
{
    public interface IHeroesRepository
    {
        Hero GetHeroById(int id);

        List<Hero> GetHeroes();
    }
}
