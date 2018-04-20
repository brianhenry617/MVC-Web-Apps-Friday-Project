using System.Collections.Generic;
using System;

namespace ContactList.Models
{
  public class Contact
  {
    private string _description;
    private static List<Contact> _instances = new Contact<Item> {};

    public Contact (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static Contact<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
