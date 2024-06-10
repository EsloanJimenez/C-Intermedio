using JustGrill.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JustGrill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleado empleado;
        public EmpleadoController(IEmpleado empleado)
        {
            this.empleado = empleado;
        }
        // GET: api/<EmpleadoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var empleado = this.empleado.GetEmpleados();

            return Ok(empleado);
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
