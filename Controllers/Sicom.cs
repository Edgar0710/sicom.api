using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sicom.Bussines.iBusiness;
using Sicom.Model;
using Sicom.Model.helpers;

namespace Sicom.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class Sicom : ControllerBase
    {
        ISicomBusiness sicomBusiness;
        public Sicom(ISicomBusiness _sicomBusiness)
        {
            sicomBusiness = _sicomBusiness;
        }
        /// <summary>
        /// Inicio de sesion
        /// </summary>
        /// <param name="user_name">Nick del usuario</param>
        /// <param name="password">Contrseña</param>
        /// <returns>Datos de los usuarios</returns>
        [HttpGet, Route("Login")]
        public ResponseModel<object> Login(string user_name,string password)
        {
          

            return sicomBusiness.Login(user_name, password); ;
        }
        /// <summary>
        /// Registro de usuario
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellido_paterno">Apellido Paterno</param>
        /// <param name="apellido_materno">Apellido Materno</param>
        /// <param name="correo">Correo general</param>
        /// <param name="userName">Nick de usuario para login</param>
        /// <param name="password">contraseña</param>
        /// <param name="tipo_cuenta">1: FREE, 2:Premium</param>
        /// <returns>Identificador del usuario -1 error</returns>
        [HttpPost, Route("RegistrarUsuario")]
        public ResponseModel<int> RegistrarUsuario(string nombre, string apellido_paterno, string apellido_materno, string correo, string userName, string password, int tipo_cuenta)
        {

            return sicomBusiness.RegistrarUusuario(nombre, apellido_paterno, apellido_paterno, correo, userName, password, tipo_cuenta);
            
        }
        /// <summary>
        /// Insertar  receptor
        /// </summary>
        /// <param name="nombre_receptor"></param>
        /// <param name="email_receptor"></param>
        /// <param name="us_id"></param>
        /// <returns></returns>
        [HttpPost, Route("RegistrarReceptor")]
        public ResponseModel<int> RegistrarReceptor(string nombre_receptor, string email_receptor, int us_id)
        {

            return sicomBusiness.RegistrarREceptor(nombre_receptor, email_receptor, us_id);

        }
        /// <summary>
        /// Obtener lis de receptores 
        /// </summary>
        /// <param name="us_id"></param>
        /// <returns></returns>
        [HttpGet, Route("ListarMisReceptores")]
        public ResponseModel<object> ListarMisReceptores(int us_id)
        {


            return sicomBusiness.GetMyReceptores(us_id);
        }
    }
}
