﻿using PetCare.Domain.Comunication;
using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Services
{
    public class TypeProductService : ITypeProductService
    {
        private readonly ITypeProductRepository _typeProductRepository;
        private readonly IUnitOfWork _unitOfWork;


        public TypeProductService(ITypeProductRepository typeProductRepository, IUnitOfWork unitOfWork)
        {
            _typeProductRepository = typeProductRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TypeProduct>> ListAsync()
        {
            return await _typeProductRepository.ListAsync();
        }

        public async Task<TypeProductResponse> SaveAsync(TypeProduct typeProduct)
        {
            var typeProductDB = _typeProductRepository.FindByName(typeProduct.Name);
            try
            {
              //  if (typeProductDB == null)
               // {
                    await _typeProductRepository.AddAsyn(typeProduct);
                    await _unitOfWork.CompleteAsync();

                    return new TypeProductResponse(typeProduct);
               // }

             //   return new TypeProductResponse("Name used. Insert another name");
            }
            catch (Exception ex)
            {
                return new TypeProductResponse($"An error ocurred while saving : {ex.Message}");
            }
        }
    }
}
