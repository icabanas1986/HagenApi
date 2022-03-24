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
        private HagenContext dbContext;
        public JobServices(HagenContext _dbContext)
        {
            dbContext = _dbContext;
        }
        
        #region vacantes
        public async Task<GeneralResponse> AddPersonal(AddPersonal request)
        {
            try
            {
                 DatosUsuario datos = new DatosUsuario()
                 {
                     Nombre1 = request.Nombre,
                     Nombre2 = request.Nombre2,
                     Apellido1 = request.Apellido,
                     Apellido2 = request.Apellido2,
                     FechaNacimiento = request.Nacimiento,
                     EstadoCivil = request.EstadoCivil,
                     Telefono = request.telefono,
                     Pais = request.idPais,
                     Estado = request.idEstado,
                     Municipio = request.idMunicipio,
                     Direccion = request.Direccion,
                     Nacionalidad = request.Nacionalidad,
                     FechaRegistro = DateTime.Now,
                     FechaActualizacion = DateTime.Now,
                     AceptaTerminos = true,
                     IdUsuario = request.idUsuario
                 };
                 dbContext.DatosUsuarios.Add(datos);
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
                        Descripcion = "id|" + request.idUsuario
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
        public async Task<GeneralResponse> AddRecord(AddRecord request)
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    Contrasena = request.contrasena,
                    Correo = request.correo,
                    FechaRegistro = DateTime.Now
                };
                dbContext.Usuarios.Add(usuario);
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
                        Descripcion = "id|" + usuario.IdUsuario
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
 