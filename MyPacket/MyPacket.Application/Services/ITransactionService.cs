using MyPacket.Domain;

namespace MyPacket.Application.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
        Transaction CreateTransaction(Transaction transaction);
    }
}
