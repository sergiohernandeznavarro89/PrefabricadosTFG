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
    public class EmpleadosController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmpleadoService _empleadoService;

        public EmpleadosController(IEmpleadoService empleadoService, IMapper mapper)
        {
            _empleadoService = empleadoService ?? throw new ArgumentNullException(nameof(empleadoService));
            _mapper = mapper;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<EmpleadoDTO> response = await _empleadoService.GetAll();

            return Ok(response);
        }
        
        [Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetForId(int id)
        {
            EmpleadoDTO response = await _empleadoService.GetForId(id);

            return Ok(response);
        }

        [Route("api/[controller]")]
        [HttpPost]
        public async Task<ActionResult<EmpleadoDTO>> Add(EmpleadoDTO empleado)
        {
            var response = await _empleadoService.Add(empleado);
            empleado.IdEmpleado = response;
            return Ok(empleado);
        }

        [Route("api/[controller]")]
        [HttpPut]
        public async Task<ActionResult<EmpleadoDTO>> Edit(EmpleadoDTO empleado)
        {
            EmpleadoDTO response = await _empleadoService.Update(empleado);             
            return Ok(response);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public async Task<ActionResult<int>> Remove(int id)
        {
            var response = _empleadoService.Remove(id);
            return Ok(id);
        }
    }
}
