using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.Identity.Client;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
      
        private readonly InsureeContext _context;

        public InsureeController(InsureeContext context)
        {
            _context = context;
        }


        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(_context.Insuree.ToList());
        }



        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree); //calculate the quote based on the user input
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }



        //HELPER METHODS//

        public decimal CalculateQuote(Insuree insuree)
        {
            insuree.Quote = 50.0M; //initialize the base cost of insurance

            //Get age based on birthdate
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            //check if the birthday has occurred this year
            if (insuree.DateOfBirth > DateTime.Now.AddYears(-age))
            {
                age--;
            }


            //check if user is 18 or younger
            if (age <= 18) 
            {
               insuree.Quote += 100.0M; 
            }
            //check if user is between 19 and 25
            else if (19 <= age && age <= 25)
            {
                insuree.Quote += 50.0M;
            }
            //check if user is 25 or older
            else if (age >= 26)
            {
                insuree.Quote += 25.0M;
            }

            //check if car year is after 2000
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25.0M;
            }
            //check if car year is before 2015
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25.0M;
            }

            //check if car make is a porsche
            if (insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase)) //ignore case will allow upper and lower case letters
            {
                insuree.Quote += 25.0M;

                //if the car make is a porche aand the model is 911 Carrera
                if (insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    insuree.Quote += 25.0M;
                }
            }

            //if speeding tickets is more than 0
            if (insuree.SpeedingTickets > 0)
            {
                insuree.Quote += insuree.SpeedingTickets * 10; //multiplpy number of tickets by 10 then add that to the basecost
            }

            //if user has a DUI add 25% of base cost to the total
            if (insuree.DUI.Equals("yes" , StringComparison.OrdinalIgnoreCase))
            {
                insuree.Quote *= 1.25M;
            }

            //if user wants full coverege add 50%
            if (insuree.CoverageType.Equals("full", StringComparison.OrdinalIgnoreCase))
            {
                insuree.Quote *= 1.5M;
            }

            return insuree.Quote; //return the total cost of insurance

            
            //insuree.Quote = (Decimal)InsuranceQuote;
            //return insuree.Quote;

            //return View("AdminView");

        }

    }
}
