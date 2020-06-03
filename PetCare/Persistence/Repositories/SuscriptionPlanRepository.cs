﻿using Microsoft.EntityFrameworkCore;
using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Persistence.Repositories
{
    public class SuscriptionPlanRepository : BaseRepository, ISuscriptionPlanRepository
    {
        public SuscriptionPlanRepository(AppDbContext context) : base(context)
        {

        }

        public async Task AddAsyn(SubscriptionPlan suscriptionPlan)
        {
            await _context.SuscriptionPlans.AddAsync(suscriptionPlan);
        }

        public async Task<SubscriptionPlan> FindByIdAsync(int id)
        {
            return await _context.SuscriptionPlans.FindAsync(id);
        }

        public async Task<IEnumerable<SubscriptionPlan>> ListAsync()
        {
            return await _context.SuscriptionPlans.ToListAsync();
           // return await _context.SuscriptionPlans.Include(x => x.SuscriptionPlan).ToListAsync();
        }

        public void Remove(SubscriptionPlan suscriptionPlan)
        {
            _context.SuscriptionPlans.Remove(suscriptionPlan);
        }

        public void Update(SubscriptionPlan suscriptionPlan)
        {
            _context.Update(suscriptionPlan);
            
        }

    }
}
