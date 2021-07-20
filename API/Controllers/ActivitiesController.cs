using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<activity>>> GetActivities()
        {
            return await _context.Activites.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<activity>> GetActivity(Guid id)
        {
            return await _context.Activites.FindAsync(id);
        }
    }
}