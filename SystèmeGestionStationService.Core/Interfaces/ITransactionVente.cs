using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SystèmePharmacie.Core.Entities;
using SystèmePharmacie.SharedKernel.Interfaces;

namespace SystèmePharmacie.Core.Interfaces
{
    public interface ITransactionVente : IAsyncRepository<TransactionVente>
    {
    }
}
