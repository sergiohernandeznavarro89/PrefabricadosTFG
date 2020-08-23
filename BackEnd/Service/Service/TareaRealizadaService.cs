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
    public class TareaRealizadaService : ITareaRealizadaService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public TareaRealizadaService(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }        

        public async Task<List<TareaRealizadaDTO>> GetAll()
        {
            IQueryable<TareaRealizada> query = _context.TareasRealizadas.AsNoTracking();

            List<TareaRealizadaDTO> resultado = await query.ProjectTo<TareaRealizadaDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return resultado;
        }

        public async Task<TareaRealizadaDTO> GetForId(int id)
        {
            IQueryable<TareaRealizada> query = _context.TareasRealizadas.Where(c => c.IdTareaRealizada == id).AsNoTracking();

            TareaRealizadaDTO resultado = await query.ProjectTo<TareaRealizadaDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();

            return resultado;
        }

        public async Task<int> Add(TareaRealizadaDTO tareaRealizadaDto)
        {
            var tareaRealizada = _mapper.Map<TareaRealizada>(tareaRealizadaDto);
            _context.TareasRealizadas.Add(tareaRealizada);
            await _context.SaveChangesAsync();

            return tareaRealizada.IdTareaRealizada;
        }

        public async Task<TareaRealizadaDTO> Update(TareaRealizadaDTO tareaRealizadaDto)
        {
            TareaRealizada tareaRealizada = _context.TareasRealizadas.FirstOrDefault(item => item.IdTareaRealizada == tareaRealizadaDto.IdTareaRealizada);
            if (tareaRealizada != null)
            {
                _context.Update(tareaRealizada);

                tareaRealizada.FechaRealizacion = tareaRealizadaDto.FechaRealizacion;
                tareaRealizada.HorasDedicadas = tareaRealizadaDto.HorasDedicadas;
                tareaRealizada.IdPedido = tareaRealizadaDto.IdPedido;
                tareaRealizada.IdEmpleado = tareaRealizadaDto.IdEmpleado;
                tareaRealizada.IdTrabajo = tareaRealizadaDto.IdTrabajo;
                tareaRealizada.IdNomina = tareaRealizadaDto.IdNomina;
                tareaRealizada.ParesRealizados = tareaRealizadaDto.ParesRealizados;

                _context.SaveChanges();
            }
                            
            return tareaRealizadaDto;
        }

        public int Remove(int idTareaRealizada)
        {
            TareaRealizada tareaRealizada = _context.TareasRealizadas.FirstOrDefault(item => item.IdTareaRealizada == idTareaRealizada);

            if (tareaRealizada != null)
            {
                _context.TareasRealizadas.Remove(tareaRealizada);
                _context.SaveChanges();
            }

            return idTareaRealizada;
        }
    }
}
