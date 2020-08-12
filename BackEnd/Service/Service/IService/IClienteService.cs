using Database.BD.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.IService
{
    public interface IClienteService
    {
        Task<List<ClienteDTO>> GetAll();
    }
}
