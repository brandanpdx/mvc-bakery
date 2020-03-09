using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/pastryForm")]
    public ActionResult Pastry() { return View(); }

    [Route("/breadForm")]
    public ActionResult Bread() { return View(); }

    [Route("/PastryConfirm")]
    public ActionResult PastryConfirm(int pastryquantity, int pastryprice) 
    { 
      Pastry newPastry = new Pastry();
      newPastry.PastryQuantity = pastryquantity;
      newPastry.PastryPrice = pastryprice;
      newPastry.PastryCalc(pastryquantity);
      
      return View(newPastry); 
    }

    [Route("/BreadConfirm")]
    public ActionResult BreadConfirm(int breadquantity, int breadprice) 
    { 
      Bread newBread = new Bread();
      newBread.BreadQuantity = breadquantity;
      newBread.BreadPrice = breadprice;
      newBread.BreadCalc(breadquantity);
      return View(newBread);
    }


  }
}
