using System.Web;
using System.Web.Mvc;

namespace Brings_Canteen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Authorize attribute already added to some controllers, but not all
            filters.Add(new AuthorizeAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
