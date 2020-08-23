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
    public class NominaService : INominaService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public NominaService(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }

        public async Task<List<NominaDTO>> GetAll()
        {
            IQueryable<Nomina> query = _context.Nominas.AsNoTracking();

            List<NominaDTO> resultado = await query.ProjectTo<NominaDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return resultado;
        }

        public async Task<NominaDTO> GetForId(int id)
        {
            IQueryable<Nomina> query = _context.Nominas.Where(c => c.IdNomina == id).AsNoTracking();

            NominaDTO resultado = await query.ProjectTo<NominaDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();

            return resultado;
        }

        public async Task<int> Add(NominaDTO nominaDTO)
        {
            var nomina = _mapper.Map<Nomina>(nominaDTO);
            _context.Nominas.Add(nomina);
            await _context.SaveChangesAsync();

            return nomina.IdNomina;
        }

        public async Task<NominaDTO> Update(NominaDTO nominaDTO)
        {
            Nomina nomina = _context.Nominas.FirstOrDefault(item => item.IdNomina == nominaDTO.IdNomina);
            if (nomina != null)
            {
                _context.Update(nomina);

                nomina.IdEmpleado = nominaDTO.IdEmpleado;
                nomina.IdTrabajo = nominaDTO.IdTrabajo;
                nomina.Importe = nominaDTO.Importe;                

                _context.SaveChanges();
            }

            return nominaDTO;
        }

        public int Remove(int idNomina)
        {
            Nomina nomina = _context.Nominas.FirstOrDefault(item => item.IdNomina == idNomina);

            if (nomina != null)
            {
                _context.Nominas.Remove(nomina);
                _context.SaveChanges();
            }

            return idNomina;
        }
    }
}
