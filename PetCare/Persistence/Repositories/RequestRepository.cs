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
        public class RequestRepository : BaseRepository, IRequestRepository
        {
            public RequestRepository(AppDbContext context) : base(context)
            {

            }

        public async Task<PersonRequest> FindByIdAsync(int id)
        {
            return await _context.Requests.FindAsync(id);
        }

        public async Task<IEnumerable<PersonRequest>> ListByCustomerIdAsync(int personProfileId) =>
                await _context.Requests
                .Where(p => p.PersonProfileId == personProfileId)
                .Include(p => p.PersonProfile)
                .ToListAsync();

            public async Task<IEnumerable<PersonRequest>> ListByProductIdAsync(int productId) =>
                await _context.Requests
                .Where(p => p.ProductId == productId)
                .Include(p => p.Product)
                .ToListAsync();

            public async Task SaveByCustomerIdAsync(PersonRequest request)
            {
                // var customer = await _context.Customers.FindAsync(customerId);
                // request.CustomerId = customer.Id;
                await _context.Requests.AddAsync(request);
            }

        public void Update(PersonRequest request)
        {
            _context.Update(request);
        }
    }
 
}
