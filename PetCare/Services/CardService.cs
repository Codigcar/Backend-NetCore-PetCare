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
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IUnitOfWork _unitOfWork;


        public CardService(ICardRepository cardRepository, IUnitOfWork unitOfWork)
        {
            _cardRepository = cardRepository;
            _unitOfWork = unitOfWork;
        }



        public async Task<IEnumerable<Card>> ListAsync()
        {
            return await _cardRepository.ListAsync();
        }

        public async Task<CardResponse> SaveAsync(Card card)
        {
            try
            {
                await _cardRepository.AddAsyn(card);
                await _unitOfWork.CompleteAsync();

                return new CardResponse(card);
            }
            catch (Exception ex)
            {
                return new CardResponse($"An error ocurred while saving the category: {ex.Message}");
            }
        }

        public async Task<CardResponse> UpdateAsync(int id, Card card)
        {
            var existingCard = await _cardRepository.FindByIdAsync(id);

            if (existingCard == null)
                return new CardResponse("Category not found");

            existingCard.Name = card.Name;

            try
            {
                _cardRepository.Update(existingCard);
                await _unitOfWork.CompleteAsync();

                return new CardResponse(existingCard);
            }
            catch (Exception ex)
            {
                return new CardResponse($"An error ocurred while updating the Category: {ex.Message}");
            }
        }

        public async Task<CardResponse> DeleteAsync(int id)
        {
            var existingCategory = await _cardRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new CardResponse("Category not found.");

            try
            {
                _cardRepository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();
                return new CardResponse(existingCategory);
            }
            catch (Exception ex)
            {
                return new CardResponse($"An error ocurred while deleting the Category: {ex.Message}");
            }
           
        }
    }
}