﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetCare.Domain.Models;
using PetCare.Domain.Services;
using PetCare.Extensions;
using PetCare.Resources;

namespace PetCare.Controllers
{
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;
        private readonly IMapper _mapper;

        public PetController(IPetService petService, IMapper mapper)
        {
            _petService = petService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PetResource>> GetAllAsync()
        {

            var customers = await _petService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Pet>, IEnumerable<PetResource>>(customers);
            return resources;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] SavePetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());


            var pet = _mapper.Map<SavePetResource, Pet>(resource);
            var result = await _petService.SaveAsync(pet);
            if (!result.Success)
                return BadRequest(result.Message);
            var petResource = _mapper.Map<Pet, PetResource>(result.Pet);
            return Ok(petResource);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SavePetResource resource)
        {
            var pet = _mapper.Map<SavePetResource, Pet>(resource);
            var result = await _petService.UpdateAsync(id, pet);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var petResource = _mapper.Map<Pet, PetResource>(result.Pet);
            return Ok(petResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _petService.DeleteAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var categoryResource = _mapper.Map<Pet, PetResource>(result.Pet);
            return Ok(categoryResource);
        }
    }
}