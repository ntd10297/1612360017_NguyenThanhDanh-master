using System.Web;
using System.Web.Mvc;

namespace _1612360017_NguyenThanhDanh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
