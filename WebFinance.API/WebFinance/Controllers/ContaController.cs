using Microsoft.AspNetCore.Mvc;
using WebFinance.Data;
using WebFinance.Models;


namespace WebFinance.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private DataContext? _dataContext;

        public void PessoaController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getconta")]
        public ActionResult<IEnumerable<Conta>> GetResult()
        {
            _dataContext = new DataContext();

            var conta = _dataContext.GetConta();

            return conta.ToList();
        }

        [HttpPost("api/postconta")]
        public async Task<ActionResult> InsertConta([FromBody] Conta conta)
        {
            _dataContext = new DataContext();

            _dataContext.Conta.Add(conta);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto conta", conta);
        }

        [HttpPut("api/putconta")]
        public async Task<ActionResult> UpdateConta([FromBody] Conta conta)
        {
            _dataContext = new DataContext();

            if (conta == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Conta.Update(conta);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

        [HttpDelete("api/deleteconta")]
        public async Task<ActionResult> DeleteConta([FromBody] Conta conta)
        {
            _dataContext = new DataContext();

            if (conta == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Conta.Remove(conta);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");
        }
    }
}
