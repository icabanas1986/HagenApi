using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HagenApi.Data.Models;
using HagenApi.Models.Responses;
using HagenApi.Models.Request;
namespace HagenApi.Data.Interfaces
{
    public interface IJobServices
    {
        Task<GeneralResponse> AddRecord(AddRecord request);
        Task<GeneralResponse> AddPersonal(AddPersonal request);
    }
}