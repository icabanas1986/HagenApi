using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HagenApi.Data.Models;
using HagenApi.Models.Responses;
using HagenApi.Models.Request;
namespace HagenApi.Interfaces
{
    public interface IRegistroServices
    {
        Task<GeneralResponse> AgregaRegistro(AddRecord request);
        Task<GeneralResponse> AgregaDatosPersonales(AddPersonal request);
    }
}