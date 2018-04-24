using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Home.Models;

namespace Home.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/Home")]
    public ActionResult Index()
    {
      List<Contact> allContact = Contact.GetAll();
      return View(allContact);
    }

    [HttpGet("/Home/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/Home")]
    public ActionResult Create()
    {
      Contact newContact = new Contact (Request.Form["new-Contact"]);
      newContact.Save();
      List<Contact> allContact = Contact.GetAll();
      return View("Index", allContact);
    }

    [HttpPost("/Home/delete")]
    public ActionResult DeleteAll()
    {
      Contact.ClearAll();
      return View();
    }

  }
}
