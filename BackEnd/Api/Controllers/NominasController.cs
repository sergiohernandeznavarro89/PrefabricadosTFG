using AutoMapper;
using Database.BD.Context;
using Database.BD.Models;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;
using Service.Service.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class NominasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INominaService _nominaService;

        public NominasController(INominaService nominaService, IMapper mapper)
        {
            _nominaService = nominaService ?? throw new ArgumentNullException(nameof(nominaService));
            _mapper = mapper;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<NominaDTO> response = await _nominaService.GetAll();

            return Ok(response);
        }
        
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetForId(int id)
        {
            NominaDTO response = await _nominaService.GetForId(id);

            return Ok(response);
        }

        [Route("api/[controller]")]
        [HttpPost]
        public async Task<ActionResult<NominaDTO>> Add(NominaDTO nomina)
        {
            var response = await _nominaService.Add(nomina);
            nomina.IdNomina= response;
            return Ok(nomina);
        }

        [Route("api/[controller]")]
        [HttpPut]
        public async Task<ActionResult<NominaDTO>> Edit(NominaDTO nomina)
        {
            NominaDTO response = await _nominaService.Update(nomina);             
            return Ok(response);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<int>> Remove(int id)
        {
            var response = _nominaService.Remove(id);
            return Ok(id);
        }
    }
}
