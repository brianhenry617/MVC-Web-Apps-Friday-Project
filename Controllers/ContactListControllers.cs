using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContactList.Models;

namespace ContactList.Controllers
{
  public class ContactController : Controller
  {

    // [HttpGet("/Contact")]
    // public ActionResult Index()
    // {
    //   // List<Contact> allContact = Contact.GetAll();
    //   // return View(allContact);
    // }

    [HttpGet("/Contact/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    // [HttpPost("/Contact")]
    // public ActionResult Create()
    // {
    //   Contact newContact = new Contact (Request.Form["new-Contact"]);
    //   newContact.Save();
    //   Contact<Contact> allContact = Contact.GetAll();
    //   return View("Index", allContact);
    // }
    //
    // [HttpPost("/Contact/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Contact.ClearAll();
    //   return View();
    // }

  }
}
