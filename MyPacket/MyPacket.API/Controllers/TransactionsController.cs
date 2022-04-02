using Microsoft.AspNetCore.Mvc;
using MyPacket.Application.Services;
using MyPacket.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPacket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> Get()
        {
            var result = _transactionService.GetAllTransactions();
            return Ok(result);
        }
    }
}
