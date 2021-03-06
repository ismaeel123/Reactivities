using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistance;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, activity>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activites.FindAsync(request.Id);
            }
        }

    }
}