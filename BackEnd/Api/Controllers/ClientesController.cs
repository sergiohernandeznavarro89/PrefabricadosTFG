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
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ClientesController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<ClienteDTO> response = await _clienteService.GetAll();

            return Ok(response);
        }
    }
}
