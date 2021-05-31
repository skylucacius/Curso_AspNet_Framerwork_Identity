using System.Web;
using System.Web.Mvc;

namespace Curso_AspNet_Framerwork_Identity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
