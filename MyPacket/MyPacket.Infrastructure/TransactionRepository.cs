using MyPacket.Application.DTOs.TransactionDto;
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

        public TransactionResponse CreateTransaction(CreateTransactionRequest request)
        {
            var transaction = new Transaction
            {
                Name = request.Name,
                Amount = request.Amount,
                Description = request.Description,
                IsExpense = request.IsExpense
            };

            _myPacketDbContext.Transactions.Add(transaction);
            _myPacketDbContext.SaveChanges();

            return new TransactionResponse
            {
                Id = transaction.Id,
                Name = transaction.Name,
                Amount = transaction.Amount,
                Description = transaction.Description,
                IsExpense = transaction.IsExpense,
                CreatedDate = transaction.CreatedDate,
                UpdatedDate = transaction.UpdatedDate
            };
        }

        public void DeleteTransactionById(int transactionId)
        {
            var transaction = _myPacketDbContext.Transactions.Find(transactionId);
            if (transaction != null)
            {
                _myPacketDbContext.Transactions.Remove(transaction);
                _myPacketDbContext.SaveChanges();
            }
           
        }

        public TransactionResponse GetTransactionById(int id)
        {
            var transaction = _myPacketDbContext.Transactions.Find(id);
            if (transaction != null)
            {
                return new TransactionResponse
                {
                    Id = transaction.Id,
                    Name = transaction.Name,
                    Amount = transaction.Amount,
                    Description = transaction.Description,
                    IsExpense = transaction.IsExpense,
                    CreatedDate = transaction.CreatedDate,
                    UpdatedDate = transaction.UpdatedDate
                };
            }

            return null;
        }

        public List<TransactionResponse> GetTransactions()
        {
            return _myPacketDbContext.Transactions.Select(t => new TransactionResponse
            {
                Id = t.Id,
                Name = t.Name,
                Amount = t.Amount,
                Description = t.Description,
                IsExpense = t.IsExpense,
                CreatedDate = t.CreatedDate,
                UpdatedDate = t.UpdatedDate
            }).ToList();
        }

        public TransactionResponse UpdateTransaction(int transactionId, UpdateTransactionRequest request)
        {
            var transaction = _myPacketDbContext.Transactions.Find(transactionId);
            if (transaction != null)
            {
                transaction.Name = request.Name;
                transaction.Amount = request.Amount;
                transaction.Description = request.Description;
                transaction.IsExpense = request.IsExpense;
                _myPacketDbContext.SaveChanges();

                return new TransactionResponse
                {
                    Id = transaction.Id,
                    Name = transaction.Name,
                    Amount = transaction.Amount,
                    Description = transaction.Description,
                    IsExpense = transaction.IsExpense,
                    CreatedDate = transaction.CreatedDate,
                    UpdatedDate = transaction.UpdatedDate
                };
            }

            return null;
        }
    }
}
