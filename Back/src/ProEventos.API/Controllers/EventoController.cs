using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public Evento Get()
        {
            return "ex get";
        }

        
        [HttpPost]
        public string Post()
        {
            return "ex post";
        }

        
        [HttpPut]
        public string Put(int id)
        {
            return $"ex put com id = {id}";
        }

        
        [HttpDelete]
        public string Delete()
        {
            return "ex delete";
        }
    }
}
