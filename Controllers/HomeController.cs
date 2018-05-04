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

//       List<Contact> allContact = Contact.GetAll();
//       return View(allContact);
//     }
//
//     [HttpGet("/Home/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }
//     [HttpPost("/Home")]
//     public ActionResult Create()
//     {
//       Contact newContact = new Contact (Request.Form["name"], Request.Form["email"], Request.Form["phoneNumber"], Request.Form["address"], Request.Form["birthDate"]);
//       newContact.Save();
//       List<Contact> allContact = Contact.GetAll();
//       return View("Home", allContact);
//     }
//
//     [HttpPost("/Home/delete")]
//     public ActionResult DeleteAll()
//     {
//       Contact.ClearAll();
//       return View();
//     }
//
//   }
// }
