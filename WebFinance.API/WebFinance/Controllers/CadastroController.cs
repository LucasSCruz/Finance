using Microsoft.AspNetCore.Mvc;
using WebFinance.Data;
using WebFinance.Models;

namespace WebFinance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        
        private DataContext? _dataContext;

        public void PessoaController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getpessoa")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoa()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetPessoas();

            return data.ToList();
        }


        [HttpPost("api/create")]
        public async Task<ActionResult> Cadastro([FromBody]Pessoa pessoa)
        {
            _dataContext = new DataContext();

            _dataContext.Pessoa.Add(pessoa);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto pessoa", pessoa) ;
        }

        [HttpPut("api/atualizapessoa")]
        public async Task<ActionResult> Atualiza([FromBody] Pessoa pessoa)
        {
            _dataContext = new DataContext();

            if (pessoa == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Pessoa.Update(pessoa);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

        [HttpDelete("api/deletepessoa")]
        public async Task<ActionResult> Delete([FromBody] Pessoa pessoa)
        {
            _dataContext = new DataContext();

            if(pessoa == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Pessoa.Remove(pessoa);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");

        }
    }
}