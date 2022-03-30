using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebFinance.Data;
using WebFinance.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebFinance.Controllers
{
    [ApiController]
    [Route("[controller]")]
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


        [HttpPost("api/create")]
        public async Task<ActionResult> Cadastro([FromBody]Pessoa pessoa)
        {
            _dataContext = new DataContext();

            _dataContext.Pessoas.Add(pessoa);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto pessoa", pessoa) ;
        }
    }
}