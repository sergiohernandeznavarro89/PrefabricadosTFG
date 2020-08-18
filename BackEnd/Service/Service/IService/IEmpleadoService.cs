using Database.BD.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.IService
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoDTO>> GetAll();
        Task<EmpleadoDTO> GetForId(int id);
        Task<int> Add(EmpleadoDTO empleado);
        Task<EmpleadoDTO> Update(EmpleadoDTO empleado);
        int Remove(int idEmpleado);
    }
}
