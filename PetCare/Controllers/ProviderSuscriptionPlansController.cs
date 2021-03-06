﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Pkcs;
using PetCare.Domain.Models;
using PetCare.Domain.Services;
using PetCare.Extensions;
using PetCare.Resources;

namespace PetCare.Controllers
{
    [Authorize]
    [Route("api/providers/{providerId}/suscriptionplans")]
    public class ProviderSuscriptionPlansController : ControllerBase
    {
        private readonly ISuscriptionPlanService _suscriptionPlanService;
        private readonly IMapper _mapper;
        


        public ProviderSuscriptionPlansController(ISuscriptionPlanService suscriptionPlanService, IMapper mapper)
        {
            _suscriptionPlanService = suscriptionPlanService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<SubscriptionPlan>> GetAllAsync()
        {
            var suscriptionPlan = await _suscriptionPlanService.ListAsync();
            return suscriptionPlan;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] SaveSubscriptionPlan resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());


            var suscriptionPlan = _mapper.Map<SaveSubscriptionPlan, SubscriptionPlan>(resource);
            var result = await _suscriptionPlanService.SaveAsync(suscriptionPlan);
            if (!result.Success)
                return BadRequest(result.Message);
            var Resource = _mapper.Map<SubscriptionPlan, SubscriptionPlanResource>(result.SuscriptionPlan);
            return Ok(Resource);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveSubscriptionPlan resource)
        {
            var servicesPlan = _mapper.Map<SaveSubscriptionPlan, SubscriptionPlan>(resource);
            var result = await _suscriptionPlanService.UpdateAsync(id, servicesPlan);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var Resource = _mapper.Map<SubscriptionPlan, SubscriptionPlanResource>(result.SuscriptionPlan);
            return Ok(Resource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _suscriptionPlanService.DeleteAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            var Resource = _mapper.Map<SubscriptionPlan, SubscriptionPlanResource>(result.SuscriptionPlan);
            return Ok(Resource);
        }


    }
}