﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetCare.Domain.Models;
using PetCare.Domain.Services;
using PetCare.Extensions;
using PetCare.Resources;
using PetCare.Resources.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Controllers
{
    [Route("api/providers/{providerId}/services/{serviceId}/availability")]
    public class ProviderServiceAvailavilityController : ControllerBase
    {
        private readonly IProviderService _providerService;
        private readonly IAvailabilityService _availabilityService;
        private readonly IMapper _mapper;

        public ProviderServiceAvailavilityController(IProviderService providerService,IAvailabilityService availabilityService, IMapper mapper)
        {
            _availabilityService = availabilityService;
            _providerService = providerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AvailabilityResource>> GetByProviderIdAndServiceIdAsync(int providerId, int serviceId)
        {
            var providers = await _availabilityService.ListByProviderIdAndServiceIdAsync(providerId, serviceId);
            var resources = _mapper.Map<IEnumerable<Availability>, IEnumerable<AvailabilityResource>>(providers);
            return resources;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(int providerId, int serviceId, [FromBody] SaveAvailabilityResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var Productid = await _providerService.FindByIdAsync(providerId);
            if (!Productid.Success)
                return BadRequest(Productid.Message);
            var availability = _mapper.Map<SaveAvailabilityResource, Availability>(resource);
            var result = await _availabilityService.SaveByServiceIdAsync(providerId, serviceId, availability);
            if (!result.Success)
                return BadRequest(result.Message);
            var AvailabilityResource = _mapper.Map<Availability, AvailabilityResource>(result.Availability);
            return Ok(AvailabilityResource);
        }
    }
}
