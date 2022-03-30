using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebFinance.Data;
using WebFinance.Models;
using System.Collections.Generic;

namespace WebFinance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : ControllerBase
    {
        
        private DataContext _dataContext;

        public void PessoaController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> pessoa()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetPessoas();


            return data.ToList();
        }


        [HttpPost]
        public async Task<IActionResult> Cadastro([Bind("Codigo,Nome")] Pessoa pessoa)
        {
            _dataContext = new DataContext();

            _dataContext.Pessoas.Add(pessoa);

            return Created("Pessoas", pessoa);
        }
    }
}