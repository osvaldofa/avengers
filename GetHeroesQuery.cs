using System;
using MediatR;

namespace Avengers.Heroes.Queries
{

    public class GetHeroesQuery : IRequest<GetHeroesResponse>
    {
        public GetHeroesQuery()
        {
        }
    }

}
