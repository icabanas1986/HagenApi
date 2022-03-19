using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HagenApi.Data;
using HagenApi.Data.Models;
using HagenApi.Data.Interfaces;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using HagenApi.Models.Responses;
using HagenApi.Models.Request;

namespace HagenApi.Data.Services
{
    public class JobServices : IJobServices
    {
        private HagebContext dbContext;
        public JobServices(HagebContext _dbContext)
        {
            dbContext = _dbContext;
        }
        
        #region vacantes
        public async Task<GeneralResponse> AddRecord(AddRecord request)
        {
            try
            {
                Registro registro = new Registro()
                {
                    Contraseña = request.contrasena,
                    Email = request.correo
                };
                dbContext.Registros.Add(registro);
                var inserted = await dbContext.SaveChangesAsync();
                if(!Convert.ToBoolean(inserted))
                {
                    return new GeneralResponse()
                    {
                        CodigoEstatus = 400,
                        Descripcion = "Error al insertar"
                    };
                }
                return new GeneralResponse()
                    {
                        CodigoEstatus = 200,
                        Descripcion = "id|" + registro.Id
                    };
            }
            catch (System.Exception ex)
            {
                return new GeneralResponse()
                    {
                        CodigoEstatus = 400,
                        Descripcion = ex.InnerException!=null?ex.InnerException.Message:ex.Message
                    };
            }
        }

        #endregion vacantes
    }
}