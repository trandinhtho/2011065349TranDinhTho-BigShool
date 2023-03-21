using System.Web;
using System.Web.Mvc;

namespace _2011065349TranDinhTho_BigShool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
