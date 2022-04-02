using MyPacket.Application.Repositories;
using MyPacket.Domain;

namespace MyPacket.Infrastructure
{
    public class TransactionRepository : ITransactionRepository
    {
        public static List<Transaction> transactions = new List<Transaction>()
        {
            new Transaction {Id = 1, Date = DateTime.Now, Amount = 100.02 },
            new Transaction {Id = 2, Date = DateTime.Now, Amount = 20.12 },
            new Transaction {Id = 3, Date = DateTime.Now, Amount = 59.32 }

        };

        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }
    }
}
