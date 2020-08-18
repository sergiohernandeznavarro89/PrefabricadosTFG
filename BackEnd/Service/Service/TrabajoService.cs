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
    public class TrabajoService : ITrabajoService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public TrabajoService(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }        

        public async Task<List<TrabajoDTO>> GetAll()
        {
            IQueryable<Trabajo> query = _context.Trabajos.AsNoTracking();

            List<TrabajoDTO> resultado = await query.ProjectTo<TrabajoDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return resultado;
        }

        public async Task<TrabajoDTO> GetForId(int id)
        {
            IQueryable<Trabajo> query = _context.Trabajos.Where(c => c.IdTrabajo == id).AsNoTracking();

            TrabajoDTO resultado = await query.ProjectTo<TrabajoDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();

            return resultado;
        }

        public async Task<int> Add(TrabajoDTO trabajoDto)
        {
            var trabajo = _mapper.Map<Trabajo>(trabajoDto);
            _context.Trabajos.Add(trabajo);
            await _context.SaveChangesAsync();

            return trabajo.IdTrabajo;
        }

        public async Task<TrabajoDTO> Update(TrabajoDTO trabajoDto)
        {
            Trabajo trabajo = _context.Trabajos.FirstOrDefault(item => item.IdTrabajo == trabajoDto.IdTrabajo);
            if (trabajo != null)
            {
                _context.Update(trabajo);

                trabajo.Nombre = trabajoDto.Nombre;
                trabajo.Descripcion = trabajoDto.Descripcion;
                trabajo.Nombre = trabajoDto.Nombre;
                trabajo.Precio = trabajoDto.Precio;                

                _context.SaveChanges();
            }

            return trabajoDto;
        }

        public int Remove(int idTrabajo)
        {
            Trabajo trabajo = _context.Trabajos.FirstOrDefault(item => item.IdTrabajo == idTrabajo);

            if (trabajo != null)
            {
                _context.Trabajos.Remove(trabajo);
                _context.SaveChanges();
            }

            return idTrabajo;
        }
    }
}
