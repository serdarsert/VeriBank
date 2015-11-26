using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VeriBank.Business.Transactions.MoneyTransfer;

namespace VeriBank.Web.WebApi
{
    [RoutePrefix("api/MoneyTransfer")]
    public class MoneyTransferController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(MoneyTransferRequest request)
        {
            MoneyTransferTransaction transaction = new MoneyTransferTransaction();
            MoneyTransferResponse response = new MoneyTransferResponse();
            transaction.Execute(request, response);
            if (response.Result.IsSuccess)
                return Ok(response);
            else
                return NotFound(); // Can return result status.
        }

        [HttpGet]
        public MoneyTransferRequest Get()
        {
            return new MoneyTransferRequest();
        }
    }
}
