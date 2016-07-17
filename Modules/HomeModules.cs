using Nancy;
using AddressFinder.Objects;
using System.Collections.Generic;


namespace AddressFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/new_contact"] = _ => {
        return View["new_contact.cshtml"];
      };

      Get["/display_contact"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["display_contact.cshtml", allContacts];
      };

      Post["/added_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phoneNumber"], Request.Form["contact-address"]);
        newContact.Save();
        return View["added_contact.cshtml", newContact];
      };

      Post["/contacts_deleted"] = _ => {
        Contact.ClearAll();
        return View["deleted_contact.cshtml"];
      };

    }
  }
}
