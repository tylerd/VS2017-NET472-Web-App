using System.Web;
using System.Web.Mvc;

namespace VS2017_NET472_Web_App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
