﻿using Microsoft.EntityFrameworkCore;
using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Persistence.Context;
using Renci.SshNet.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Persistence.Repositories
{
    public class PaymentRepository : BaseRepository, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {

        }

        public async Task AddAsyn(Payment Payment)
        {
            await _context.Payments.AddAsync(Payment);
        }

        public async Task<Payment> FindByIdAsync(int id)
        {
            return await _context.Payments.FindAsync(id);
        }

        public async Task<IEnumerable<Payment>> ListAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<IEnumerable<Payment>> ListByServicesProviderIdAsync(int sproviderId) =>
            await _context.Payments
            .Where(p => p.ServicesProviderForeignKey== sproviderId)
            .Include(p => p.ServicesProvider)
            .ToListAsync();
        

        public void Remove(Payment Payment)
        {
            _context.Payments.Remove(Payment);
        }

        public async Task SaveByServicesProviderIdAsync(int sproviderId, Payment Payment)
        {
            var servicesProvider = await _context.ServicesProviders.FindAsync(sproviderId);
            Payment.ServicesProviderForeignKey = servicesProvider.Id;
            await _context.Payments.AddAsync(Payment);
        }

        public void Update(Payment Payment)
        {
            _context.Update(Payment);
        }
    }
}
