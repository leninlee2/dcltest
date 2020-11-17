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
    public class SellApiController : ApiController
    {
        // GET: api/SellApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SellApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SellApi
        public SellOutViewModel Post([FromBody] SellEntryViewModel entry)
        {
            //tratar os dados e realizar calculo
            SellOutViewModel result = new SellOutViewModel();
            double basesalary = 0;
            double endsalary = 0;
            try {
                string[] values = entry.value.Split(';');
                Double.TryParse(entry.basesalary, out basesalary);
                if (basesalary > 0 && values.Length > 0)
                {
                    List<SellViewModel> sellViewModels = new List<SellViewModel>();
                    values.ToList().ForEach(f =>
                    {
                        if (!String.IsNullOrEmpty(f))
                            sellViewModels.Add(new SellViewModel() { price = Double.Parse(f) });
                    });
                    endsalary = Sellers.GetEndSalary(basesalary, 100, sellViewModels);
                    result.endsalary = endsalary;
                }
            }
            catch(Exception ex)
            {
                result.message = ex.Message;
            }
            return result;
        }

        // PUT: api/SellApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SellApi/5
        public void Delete(int id)
        {
        }
    }
}
