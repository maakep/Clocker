using System.Web;
using System.Web.Mvc;

namespace ClockerWebapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //idk
            filters.Add(new HandleErrorAttribute());
        }
    }
}
