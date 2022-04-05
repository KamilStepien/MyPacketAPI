using MyPacket.Application.DTOs.TransactionDto;
using MyPacket.Application.Repositories;

namespace MyPacket.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public TransactionResponse CreateTransaction(CreateTransactionRequest request)
        {
            var result = _transactionRepository.CreateTransaction(request);
            return result;
        }

        public void DeleteTransactionById(int transactionId)
        {
            _transactionRepository.DeleteTransactionById(transactionId);
        }

        public TransactionResponse GetTransactionById(int id)
        {
            var result = _transactionRepository.GetTransactionById(id);
            return result;
        }

        public List<TransactionResponse> GetTransactions()
        {
            var transactios = _transactionRepository.GetTransactions();
            return transactios;
        }

        public TransactionResponse UpdateTransaction(int transactionId, UpdateTransactionRequest request)
        {
            var result = _transactionRepository.UpdateTransaction(transactionId, request);
            return result;
        }
    }
}
