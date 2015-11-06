using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contacts.Data;
using Contacts.Models;

namespace Contacts.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // retrieve all the contact
            var repo = Factory.CreateContactRepository();
            var contacts = repo.GetAll();

            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact()
        {
            // create a contact
            var c = new Contact();

            // get data from input fields
            c.Name = Request.Form["Name"];
            c.PhoneNumber = Request.Form["PhoneNumber"];

            // create the repo
            var repo = Factory.CreateContactRepository();

            // add the contact
            repo.Add(c);

            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            // retrieve contact id we passed in
            int contactId = int.Parse(RouteData.Values["id"].ToString());

            var repo = Factory.CreateContactRepository();
            var contact = repo.GetById(contactId);

            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact()
        {
            // create a new contact 
            var c = new Contact();

            // set the values from the form
            c.Name = Request.Form["Name"];
            c.PhoneNumber = Request.Form["PhoneNumber"];
            c.ContactID = int.Parse(Request.Form["ContactID"]);

            // edit contact in repo
            var repo = Factory.CreateContactRepository();
            repo.Edit(c);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteContact()
        {
            // get contact from form
            int contactID = int.Parse(Request.Form["ContactID"]);

            // delete contact
            var repo = Factory.CreateContactRepository();
            repo.Delete(contactID);

            // update index page
            var contacts = repo.GetAll();
            return View("Index", contacts);
        }
    }
}