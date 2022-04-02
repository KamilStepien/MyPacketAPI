using MyPacket.Domain;

namespace MyPacket.Application.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAllTransactions();
        Transaction CreateTransaction(Transaction transaction);
    }
}
