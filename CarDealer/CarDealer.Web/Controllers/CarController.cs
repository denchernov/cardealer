using System.Web.Mvc;

namespace CarDealer.Web.Controllers
{
    using CarDealer.Web.Model;

    using Glass.Mapper.Sc.Web.Mvc;

    public class CarController : Controller
    {
        public ActionResult List()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetContextItem<CarList>();
            return View("~/Views/CarDealer/Components/CarList.cshtml", model);
        }

        // GET
        public ActionResult Details()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetContextItem<Car>();
            return View("~/Views/CarDealer/Components/CarDetails.cshtml", model);
        }
    }
}