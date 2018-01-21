using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace JoeAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JoeAbpControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}