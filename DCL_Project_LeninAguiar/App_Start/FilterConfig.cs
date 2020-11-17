using System.Web;
using System.Web.Mvc;

namespace DCL_Project_LeninAguiar
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
