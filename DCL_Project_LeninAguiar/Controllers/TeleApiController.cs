using DCL_Project_LeninAguiar.Domain;
using DCL_Project_LeninAguiar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DCL_Project_LeninAguiar.Controllers
{
    public class TeleApiController : ApiController
    {
        // GET: api/TeleApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TeleApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TeleApi
        public SellOutViewModel Post([FromBody]TeleEntryViewModel value)
        {
            SellOutViewModel result = new SellOutViewModel();
            try {
                result.bill = Tellecomunication.GetPayBill(value.usedseconds);
            }
            catch(Exception ex)
            {
                result.message = ex.Message;
            }
            return result;
        }

        // PUT: api/TeleApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TeleApi/5
        public void Delete(int id)
        {
        }
    }
}
