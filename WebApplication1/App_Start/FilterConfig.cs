using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class FilterConfig
    {
        //comment added
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
