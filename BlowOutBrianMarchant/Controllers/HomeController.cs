using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlowOutBrianMarchant.DAL;
using BlowOutBrianMarchant.Models;

namespace BlowOutBrianMarchant.Controllers
{
    public class HomeController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rentals()
        {
            return View(db.Instruments.ToList());
        }

        // GET: Home/Create(Client)
        public ActionResult Create()
        {
            ViewBag.States = db.States.ToList();
            return View();
        }

        //POST: Home/Create(Client)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID,ClientFirstName,ClientLastName,ClientAddress,ClientCity,ClientStateID,ClientZip,ClientEmail,ClientPhone")] Client client, int id)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                db.SaveChanges();

                //find the instrument based on the id that was passed from the rentals view
                Instrument instrument = db.Instruments.Find(id);
                //set the clientid field in the instruments table to be the clientid from the new
                //client that we are creating with this create method
                instrument.ClientID = client.ClientID;
                //save changes to instrument database
                db.Entry(instrument).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Summary", new { ClientID = client.ClientID, InstrumentID = instrument.InstrumentID });
            }

            return View(client);
        }

        public ActionResult Summary(int ClientID, int InstrumentID)
        {
            Client client = db.Clients.Find(ClientID);
            Instrument instrument = db.Instruments.Find(InstrumentID);

            ViewBag.Client = client;
            ViewBag.Instrument = instrument;
            ViewBag.TotalRental = instrument.InstrumentPrice * 18;
            return View();
        }
    }
}