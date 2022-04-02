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

        public Transaction CreateTransaction(Transaction transaction)
        {
            _transactionRepository.CreateTransaction(transaction);
            return transaction;
        }

        public List<Transaction> GetAllTransactions()
        {
            var transactios = _transactionRepository.GetAllTransactions();

            return transactios;
        }
    }
}
