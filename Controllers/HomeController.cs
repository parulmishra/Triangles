using Microsoft.AspNetCore.Mvc;
using System;
using Triangles.Models;

namespace Triangles.Controllers
{
  public class HomeController : Controller
  {
      [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

      [Route("/determine_triangle")]
        public ActionResult DetermineTriangles()
        {
            Triangle myTriangle = new Triangle();
            myTriangle.SetSide1(Int32.Parse(Request.Query["side1"]));
            myTriangle.SetSide2(Int32.Parse(Request.Query["side2"]));
            myTriangle.SetSide3(Int32.Parse(Request.Query["side3"]));
            //myTriangle.determineTriangle();
            return View(myTriangle);
        }
  }
}
