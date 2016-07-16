using System;
using System.Collections.Generic;

namespace AddressFinder.Objects
{
  public class Contact
  {
    private string _name;
    private int _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact>{};

    public Contact(string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public void string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(int newPhoneNumber)
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
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact FindContact(int searchId)
    {
      return _instances[searchId -1];
    }

  }
 }
