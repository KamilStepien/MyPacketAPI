using MyPacket.Application.Repositories;
using MyPacket.Domain;

namespace MyPacket.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public List<Transaction> GetAllTransactions()
        {
            var transactios = _transactionRepository.GetAllTransactions();

            return transactios;
        }
    }
}
