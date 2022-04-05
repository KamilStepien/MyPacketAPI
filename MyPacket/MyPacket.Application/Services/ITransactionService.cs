using MyPacket.Application.DTOs.TransactionDto;

namespace MyPacket.Application.Services
{
    public interface ITransactionService
    {
        List<TransactionResponse> GetTransactions();
        TransactionResponse GetTransactionById(int id);
        void DeleteTransactionById(int transactionId);
        TransactionResponse CreateTransaction(CreateTransactionRequest request);
        TransactionResponse UpdateTransaction(int transactionId, UpdateTransactionRequest request);
    }
}
