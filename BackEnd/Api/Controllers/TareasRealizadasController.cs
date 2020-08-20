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
    public class TareasRealizadasController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITareaRealizadaService _tareaRealizadaService;

        public TareasRealizadasController(ITareaRealizadaService tareaRealizadaService, IMapper mapper)
        {
            _tareaRealizadaService = tareaRealizadaService ?? throw new ArgumentNullException(nameof(tareaRealizadaService));
            _mapper = mapper;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<TareaRealizadaDTO> response = await _tareaRealizadaService.GetAll();

            return Ok(response);
        }
        
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetForId(int id)
        {
            TareaRealizadaDTO response = await _tareaRealizadaService.GetForId(id);

            return Ok(response);
        }

        [Route("api/[controller]")]
        [HttpPost]
        public async Task<ActionResult<TareaRealizadaDTO>> Add(TareaRealizadaDTO tareaRealizada)
        {
            var response = await _tareaRealizadaService.Add(tareaRealizada);
            tareaRealizada.IdTareaRealizada = response;
            return Ok(tareaRealizada);
        }

        [Route("api/[controller]")]
        [HttpPut]
        public async Task<ActionResult<TareaRealizadaDTO>> Edit(TareaRealizadaDTO tareaRealizada)
        {
            TareaRealizadaDTO response = await _tareaRealizadaService.Update(tareaRealizada);             
            return Ok(response);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<int>> Remove(int id)
        {
            var response = _tareaRealizadaService.Remove(id);
            return Ok(id);
        }
    }
}
