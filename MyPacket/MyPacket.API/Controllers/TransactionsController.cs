using Microsoft.AspNetCore.Mvc;
using MyPacket.Application.Services;
using MyPacket.Domain;
using SerilogTimings;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPacket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ILogger<TransactionsController> _logger;
        private readonly ITransactionService _transactionService;

        public TransactionsController(ILogger<TransactionsController> logger,ITransactionService transactionService)
        {
            _logger = logger;
            _transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> Get()
        {
            _logger.LogInformation("Get all Transactions");
            var result = _transactionService.GetAllTransactions();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Transaction> PostTransation(Transaction transaction)
        {
            _logger.LogInformation("Create transation");
            var result = _transactionService.CreateTransaction(transaction);
            return Ok(result);
        }
    }
}
