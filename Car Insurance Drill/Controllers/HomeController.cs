using Car_Insurance_Drill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Drill.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string DUI, int speedingTickets, string coveragetype, int? total)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(DUI) || string.IsNullOrEmpty(coveragetype))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var quote = new AutoInsuranceQuote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUI = DUI;
                    quote.SpeedingTickets = speedingTickets;
                    quote.CoverageType = coveragetype;
                    quote.Total = total;



                    total = 50;     // sets quote total to $50 to start with
                    var currentDay = DateTime.Today;        // sets current date to calculate age for customer
                    var age = currentDay.Year - dateOfBirth.Year;       // calculates customers age
                    if (age > 100)
                    {
                        total = total + 25;         //  if customer is over 100 years of age adding $25 to total quote
                    }
                    else if (age < 18)
                    {
                        total = total + 100;        // if customer is below 18 years of age, adding $100 to total quote
                    }
                    else if (age < 25)
                    {
                        total = total + 25;         // if customer is under 25 years of age, adding $25 to total quote
                    }
                    else
                    {
                        total = total + 0;
                    }

                    if (carYear < 2000)
                    {
                        total = total + 25;         // if Car's Year is under the year 2000, adding $25 to total quote
                    }
                    else if (carYear > 2015)
                    {
                        total = total + 25;         // if Car's Year is above the year 2015, adding $25 to the total quote
                    }

                    if (carMake == "Porsche")
                    {
                        total = total + 25;         // if Car's Make is a Porsche, adding $25 to the total quote
                    }

                    if (carMake == "Porsche" || carModel == "911 Carrera")      // if Car's Make is a Porsche, and Car's Model is a "911 Carrerra", adding $25 to total
                    {
                        total = total + 25;
                    }

                    if (speedingTickets > 0)
                    {
                        total = total + (speedingTickets * 10);         // takes total number of speeding tickets the customer has and multiplies it by 10, to add $10 per ticket
                    }

                    if (DUI == "Yes" || DUI == "Ya" || DUI == "Yeah" || DUI == "yes" || DUI == "ya" || DUI == "yeah")
                    {
                        total = total + (total * 25 / 100);         // adds 25% to total by multiplying by 25 and dividing by 100
                    }
                    else
                    {
                        total = total + 0;
                    }

                    if (coveragetype == "Yes" || coveragetype == "Ya" || coveragetype == "Yeah" || coveragetype == "yes" || coveragetype == "ya" || coveragetype == "yeah")
                    {
                        total = total + (total * 50 / 100);         // adds 50% to total by multiplying by 50 and dividing by 100
                    }
                    else
                    {
                        total = total + 0;
                    }

                    quote.Total = total;

                    db.AutoInsuranceQuotes.Add(quote);
                    db.SaveChanges();

                    ViewBag.Total = total;

                    return View("Success");
                }
            }
        }
    }
}