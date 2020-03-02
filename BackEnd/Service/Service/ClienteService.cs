using AutoMapper;
using AutoMapper.QueryableExtensions;
using Database.BD.Context;
using Database.BD.Models;
using Microsoft.EntityFrameworkCore;
using Service.DTO;
using Service.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ClienteService : IClienteService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public ClienteService(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }

        public async Task<List<ClienteDTO>> GetAll()
        {
            IQueryable<Cliente> query = _context.Clientes.AsNoTracking();

            List<ClienteDTO> resultado = await query.ProjectTo<ClienteDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return resultado;
        }
    }
}
