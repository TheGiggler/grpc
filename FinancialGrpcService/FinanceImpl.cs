using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Utils;

namespace Financial
{
    public class FinanceImpl: FinancialTransaction.FinancialTransactionBase
    {
        public override Task<TransactionResponse> ProcessTransaction(TransactionRequest request, ServerCallContext context)
        {
            return base.ProcessTransaction(request, context);
        }

        public override Task ProcessTransactionStream(IAsyncStreamReader<TransactionRequest> requestStream, IServerStreamWriter<TransactionResponse> responseStream, ServerCallContext context)
        {
            return base.ProcessTransactionStream(requestStream, responseStream, context);
        }
    }
}
