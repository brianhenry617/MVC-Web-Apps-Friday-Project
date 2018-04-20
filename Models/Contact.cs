using System.Collections.Generic;
using System.IO;
using System;

namespace ContactList.Models
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phoneNumber;
    private string _address;
    private string _birthDate;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string email, string phoneNumber, string address, string _birthDate)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
      _address = address;
      _birthDate = _birthDate;
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
      return _phoneNumber
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
      _birthDate = newBirthDate;
    }
    public static Item<Contact> GetAll()
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
