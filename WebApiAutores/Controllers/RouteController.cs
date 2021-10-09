using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAutores.DTOs;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RouteController: ControllerBase
    {
        private readonly IAuthorizationService authorizationService;

        public RouteController(IAuthorizationService authorizationService)
        {
            this.authorizationService = authorizationService;
        }

        [HttpGet(Name = "ObtenerRoot")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<DatoHATEOAS>>> Get()
        {
            var datosHATEOAS = new List<DatoHATEOAS>();

            var esAdmin = await authorizationService.AuthorizeAsync(User, "esAdmin");

            datosHATEOAS.Add(new DatoHATEOAS(enlace: Url.Link("ObtenerRoot", new { })
                , descripcion: "self", metodo: "GET"));

            datosHATEOAS.Add(new DatoHATEOAS(enlace: Url.Link("obtenerAutores", new { }), descripcion: "autores"
                 , metodo: "GET"));

            if (esAdmin.Succeeded)
            {


                datosHATEOAS.Add(new DatoHATEOAS(enlace: Url.Link("crearAutor", new { }), descripcion: "crear-autor"
                    , metodo: "POST"));
            }


            return datosHATEOAS;
        }
    }
}
