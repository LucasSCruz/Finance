using Microsoft.AspNetCore.Mvc;
using WebFinance.Models;

namespace WebFinance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
      [HttpGet]
      public IEnumerable<Pessoa> pessoa()
        {
            return new List<Pessoa>();
        }


    }
}