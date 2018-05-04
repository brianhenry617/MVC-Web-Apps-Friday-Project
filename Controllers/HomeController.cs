using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Contact.Models;

namespace Contact.Controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List <Contact> all Contacts = Contact.GetAll();
      return View(allContacts);
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
      return View("Index");
    }
    
    [HttpPost("contact/clear")]
    public ActionResult Clear()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
