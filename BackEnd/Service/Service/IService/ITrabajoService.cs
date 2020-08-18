using Database.BD.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.IService
{
    public interface ITrabajoService
    {
        Task<List<TrabajoDTO>> GetAll();
        Task<TrabajoDTO> GetForId(int id);
        Task<int> Add(TrabajoDTO trabajo);
        Task<TrabajoDTO> Update(TrabajoDTO trabajo);
        int Remove(int idTrabajo);
    }
}
