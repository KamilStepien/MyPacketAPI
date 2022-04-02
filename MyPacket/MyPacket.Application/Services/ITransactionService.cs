using MyPacket.Domain;

namespace MyPacket.Application.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
    }
}
