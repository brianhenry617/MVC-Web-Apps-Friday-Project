using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HomeController.Models;

namespace HomeController
{
  public class ContactController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List <Contact> all = Contact.GetAll();
      //all is variable for <contact>
      return View(all);
    }

    [HttpGet("/contact/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/contact")]
    public ActionResult Create()
    {
      Contact newContact = new Contact(Request.Form["name"], Request.Form["email"], Request.Form["phoneNumber"], Request.Form["address"], Request.Form["birthDate"]);
      List <Contact> allContacts = Contact.GetAll();
      return View("Index", allContacts);
    }

    [HttpPost("contact/clear")]
    public ActionResult Clear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
