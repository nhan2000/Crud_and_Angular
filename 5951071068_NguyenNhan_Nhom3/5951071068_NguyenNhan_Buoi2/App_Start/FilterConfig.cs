using System.Web;
using System.Web.Mvc;

namespace _5951071068_NguyenNhan_Buoi2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
