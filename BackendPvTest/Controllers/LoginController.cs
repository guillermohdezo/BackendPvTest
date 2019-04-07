using BackendPvTest.EntityDB;
using BackendPvTest.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BackendPvTest.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public async Task<LoginResponce> CheckLogin(JObject request)
        {
            string userName = request["UserName"].ToString();
            EntityContext entityContext = new EntityContext();
            var user = entityContext.Usuarios.Where(e => e.NombreUsuario.Equals(userName)).FirstOrDefault();
            return new LoginResponce() { State = true, Type = user.Tipo, UserName = user.NombreUsuario };
        }
    }
}
