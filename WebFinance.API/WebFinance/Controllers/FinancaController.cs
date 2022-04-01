using Microsoft.AspNetCore.Mvc;
using WebFinance.Data;
using WebFinance.Models;

namespace WebFinance.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FinancaController : ControllerBase
    {
        private DataContext? _dataContext;

        public void PessoaController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("api/getfinanca")]
        public ActionResult<IEnumerable<Financa>> GetResult()
        {
            _dataContext = new DataContext();

            var data = _dataContext.GetFinanca();

            return data.ToList();
        }

        [HttpPost("api/postfinanca")]
        public async Task<ActionResult<IEnumerable<Financa>>> InsertFinanca(Financa financa)
        {
            _dataContext = new DataContext();

            _dataContext.Financa.Add(financa);
            await _dataContext.SaveChangesAsync();

            return Created("Objeto financa", financa);

        }

        [HttpPut("api/putfinanca")]
        public async Task<ActionResult<IEnumerable<Financa>>> UpdateFinanca(Financa financa)
        {
            _dataContext = new DataContext();

            _dataContext.Financa.Update(financa);
            await _dataContext.SaveChangesAsync();

            return Ok("Updated!");
        }

        [HttpDelete("api/deletefinanca")]
        public async Task<ActionResult> Delete([FromBody] Financa financa)
        {
            _dataContext = new DataContext();

            if (financa == null)
            {
                return BadRequest("Not found!");
            }

            _dataContext.Financa.Remove(financa);
            await _dataContext.SaveChangesAsync();

            return Ok("Deleted!");
        }
    }
}
