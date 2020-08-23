using Database.BD.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.IService
{
    public interface INominaService
    {
        Task<List<NominaDTO>> GetAll();
        Task<NominaDTO> GetForId(int id);
        Task<int> Add(NominaDTO nomina);
        Task<NominaDTO> Update(NominaDTO nomina);
        int Remove(int idNomina);
    }
}
