using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VeriBank.Business.Transactions.MoneyTransfer;

namespace VeriBank.Web.WebApi
{
    public class MoneyTransferController : ApiController
    {
        public IHttpActionResult Post([FromBody]MoneyTransferRequest request)
        {
            MoneyTransferTransaction transaction = new MoneyTransferTransaction();
            MoneyTransferResponse response = new MoneyTransferResponse();
            transaction.Execute(request, response);
            if (response.Result.IsSuccess)
                return Ok(request);
            else
                return NotFound(); // Can return result status.
        }
    }
}
