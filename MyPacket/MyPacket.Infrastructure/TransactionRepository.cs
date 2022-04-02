using MyPacket.Application.Repositories;
using MyPacket.Domain;

namespace MyPacket.Infrastructure
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MyPacketDbContext _myPacketDbContext;

        public TransactionRepository(MyPacketDbContext myPacketDbContext)
        {
            _myPacketDbContext = myPacketDbContext;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            _myPacketDbContext.Transactions.Add(transaction);
            _myPacketDbContext.SaveChanges();

            return transaction;
        }

        public List<Transaction> GetAllTransactions()
        {
            return _myPacketDbContext.Transactions.ToList();
        }
    }
}
