using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionApi.IServices;

namespace TransactionApi.Services
{
    public static class TransactionServices
    {
        public static IServiceCollection RegisterMyServices(this IServiceCollection services) => services
                    .AddTransient<ITransactionService, TransactionService>();
    }
}
