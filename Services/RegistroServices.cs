using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HagenApi.Models;
using HagenApi.Interfaces;
using HagenApi.Data.Interfaces;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using HagenApi.Models.Responses;
using HagenApi.Models.Request;

namespace HagenApi.Services
{
    public class RegistroServices : IRegistroServices
    {
        IJobServices jobServices;
        public RegistroServices(IJobServices _jobServices)
        {
            jobServices = _jobServices;
        }

        public async Task<GeneralResponse> AgregaRegistro(AddRecord request)
        {
            var response = await jobServices.AddRecord(request);
            return response;
        }
    }
}