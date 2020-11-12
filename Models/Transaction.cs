using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionsApi.Models
{
    public class Transaction
    {
        public int idTransactions { get; set; }
        public string User { get; set; }
        public int Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public bool IsEnd { get; set; }
        public bool IsReturned { get; set; }
    }
}