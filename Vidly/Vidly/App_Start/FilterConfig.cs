using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //ne dozvoljava pristup stranici ukoliko nismo registrovani i logirani
            filters.Add(new AuthorizeAttribute());
            //Ova linija zabranjuje pristup stranici preko http protokola 
            //moramo koristiti https protokol
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
