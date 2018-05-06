using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HomeController.Models
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private string _email;
    private string _phoneNumber;
    private string _address;
    private string _birthDate;

    public Contact (string name, string email, string phoneNumber, string address, string birthDate)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
      _address = address;
      _birthDate = birthDate;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public string GetBirthDate()
    {
      return _birthDate;
    }
    public void SetBirthDate(string newBirthdate)
    {
      _birthDate = newBirthdate;
    }
    public static List<Contact> GetAll()
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
