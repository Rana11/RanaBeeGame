using System.Web.Mvc;
using BeeGame.ServiceLayer.Builders;

namespace BeeGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly BeeBuilder BeeBuilder = new BeeBuilder();

        public ActionResult Index()
        {
            var model = BeeBuilder.Build();

            return View(model);
        }

        [HttpPost]
        public ActionResult Hit()
        {
            var data = BeeBuilder.Hit();

            return new JsonResult { JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = data};
        }
    }
}