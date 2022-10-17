using ControlFin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlFin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
       public static List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstados()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado)
        {
            lista.Add(estado);

            return "Estado cadastrado com sucesso!";
        }

        [HttpPut]
        public string PutEstado(Estado estado)
        {
            Estado estadoTodo = lista.Where(x => x.Singla == estado.Singla).FirstOrDefault();
            estadoTodo.Nome = estado.Nome;

            return "Estado atualizado com sucesso!";
        }


        [HttpDelete]
        public string DeleteEstado(Estado estado)
        {
            Estado estadoTodo = lista.Where(x => x.Singla == estado.Singla).FirstOrDefault();
            lista.Remove(estadoTodo);

            return "Estado excluido com sucesso!";
        }
    }
}
