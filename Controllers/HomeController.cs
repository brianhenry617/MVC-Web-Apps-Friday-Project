using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Contact.Models;

namespace Home.Controller
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
