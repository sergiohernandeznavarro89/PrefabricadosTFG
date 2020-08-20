using Database.BD.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.IService
{
    public interface ITareaRealizadaService
    {
        Task<List<TareaRealizadaDTO>> GetAll();
        Task<TareaRealizadaDTO> GetForId(int id);
        Task<int> Add(TareaRealizadaDTO tareaRealizada);
        Task<TareaRealizadaDTO> Update(TareaRealizadaDTO tareaRealizada);
        int Remove(int idTareaRealizada);
    }
}
