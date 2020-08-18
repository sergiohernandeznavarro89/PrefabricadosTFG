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
    public class TrabajosController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITrabajoService _trabajoService;

        public TrabajosController(ITrabajoService trabajoService, IMapper mapper)
        {
            _trabajoService = trabajoService ?? throw new ArgumentNullException(nameof(trabajoService));
            _mapper = mapper;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<TrabajoDTO> response = await _trabajoService.GetAll();

            return Ok(response);
        }
        
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetForId(int id)
        {
            TrabajoDTO response = await _trabajoService.GetForId(id);

            return Ok(response);
        }

        [Route("api/[controller]")]
        [HttpPost]
        public async Task<ActionResult<TrabajoDTO>> Add(TrabajoDTO trabajo)
        {
            var response = await _trabajoService.Add(trabajo);
            trabajo.IdTrabajo = response;
            return Ok(trabajo);
        }

        [Route("api/[controller]")]
        [HttpPut]
        public async Task<ActionResult<TrabajoDTO>> Edit(TrabajoDTO trabajo)
        {
            TrabajoDTO response = await _trabajoService.Update(trabajo);             
            return Ok(response);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<int>> Remove(int id)
        {
            var response = _trabajoService.Remove(id);
            return Ok(id);
        }
    }
}
