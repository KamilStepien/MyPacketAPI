using Microsoft.AspNetCore.Mvc;
using MyPacket.Application.DTOs.TransactionDto;
using MyPacket.Application.Services;

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
        public ActionResult<List<TransactionResponse>> GetTransactions()
        {
            _logger.LogInformation("Get transactions");
            var result = _transactionService.GetTransactions();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<List<TransactionResponse>> GetTransactionById(int id)
        {
            _logger.LogInformation("Get transaction {id}", id);
            var result = _transactionService.GetTransactionById(id);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<TransactionResponse> Create(CreateTransactionRequest request)
        {
            _logger.LogInformation("Create transation");
            var result = _transactionService.CreateTransaction(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<TransactionResponse> Update(int id ,UpdateTransactionRequest request)
        {
            _logger.LogInformation("Update transation {id}", id);
            var result = _transactionService.UpdateTransaction(id, request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation("Delete transation {id}", id);
            _transactionService.DeleteTransactionById(id);
            return NoContent();
        }
    }
}
