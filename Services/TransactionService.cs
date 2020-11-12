using TransactionApi.Data;
using TransactionApi.IServices;
using TransactionApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionsApi.Data;
using TransactionsApi.Models;

namespace TransactionApi.Services
{
    public class TransactionService : ITransactionService
    {
        ApplicationDbContext dbContext;

        public TransactionService(ApplicationDbContext _db)
        {
            dbContext = _db;
        }

        public async Task<string> AddTransaction(Transaction Transaction)
        {
            dbContext.Transaction.Add(Transaction);
            await dbContext.SaveChangesAsync();

            return await Task.FromResult("");
        }

        public async Task<string> DeleteTransaction(int id)
        {
            var Transaction = dbContext.Transaction.FirstOrDefault(x => x.idTransaction == id);
            dbContext.Entry(Transaction).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return await Task.FromResult("");
        }

        public async Task<Transaction> GetTransactionByIdAsync(string id)
        {
            var Transaction = await dbContext.Transaction.FindAsync(id);

            if (Transaction == null)
            {

            }

            return Transaction;
        }


        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await dbContext.Transaction.ToListAsync();
        }

        public Transaction UpdateTransaction(Transaction Transaction)
        {
            dbContext.Entry(Transaction).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Transaction;
        }

    }
}
