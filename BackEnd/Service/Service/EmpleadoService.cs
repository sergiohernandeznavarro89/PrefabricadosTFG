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
    public class EmpleadoService : IEmpleadoService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public EmpleadoService(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }        

        public async Task<List<EmpleadoDTO>> GetAll()
        {
            IQueryable<Empleado> query = _context.Empleados.AsNoTracking();

            List<EmpleadoDTO> resultado = await query.ProjectTo<EmpleadoDTO>(_mapper.ConfigurationProvider).ToListAsync();

            return resultado;
        }

        public async Task<EmpleadoDTO> GetForId(int id)
        {
            IQueryable<Empleado> query = _context.Empleados.Where(c => c.IdEmpleado == id).AsNoTracking();

            EmpleadoDTO resultado = await query.ProjectTo<EmpleadoDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();

            return resultado;
        }

        public async Task<int> Add(EmpleadoDTO empleadoDto)
        {
            var empleado = _mapper.Map<Empleado>(empleadoDto);
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();

            return empleado.IdEmpleado;
        }

        public async Task<EmpleadoDTO> Update(EmpleadoDTO empleadoDto)
        {
            Empleado empleado = _context.Empleados.FirstOrDefault(item => item.IdEmpleado == empleadoDto.IdEmpleado);
            if (empleado != null)
            {
                _context.Update(empleado);
                
                empleado.Nif = empleadoDto.Nif;
                empleado.IBAN = empleadoDto.IBAN;
                empleado.Nombre = empleadoDto.Nombre;
                empleado.Poblacion = empleadoDto.Poblacion;
                empleado.Provincia = empleadoDto.Provincia;
                empleado.Telefono = empleadoDto.Telefono;
                empleado.Apellidos = empleadoDto.Apellidos;
                empleado.CodPostal = empleadoDto.CodPostal;
                empleado.Direccion = empleadoDto.Direccion;
                empleado.Email = empleadoDto.Email;                
              
                _context.SaveChanges();
            }
                            
            return empleadoDto;
        }

        public int Remove(int idEmpleado)
        {
            Empleado empleado = _context.Empleados.FirstOrDefault(item => item.IdEmpleado == idEmpleado);

            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }

            return idEmpleado;
        }
    }
}
