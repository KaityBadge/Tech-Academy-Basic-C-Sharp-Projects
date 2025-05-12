using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
      
        private readonly InsureeContext _context;

        public InsureeController(InsureeContext context)
        {
            _context = context;
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
                insuree.Id = Guid.NewGuid();
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
            int age = insuree.Age;
            decimal InsuranceQuote = 50; //initialize the base cost of insurance

            //check if user is 18 or younger
            if (age <= 18) 
            {
               InsuranceQuote += 100; 
            }

            //check if user is between 19 and 25
            if (19 <= age && age <= 25)
            {
                InsuranceQuote += 50;
            }

            //check if user is 25 or older
            if (age >= 26)
            {
                InsuranceQuote += 25;
            }

            //check if car year is after 2000
            if (insuree.CarYear < 2000)
            {
                InsuranceQuote += 25;
            }
            //check if car year is before 2015
            if (insuree.CarYear > 2015)
            {
                InsuranceQuote += 25;
            }

            //check if car make is a porsche
            if (insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase)) //ignore case will allow upper and lower case letters
            {
                InsuranceQuote += 25;

                //if the car make is a porche aand the model is 911 Carrera
                if (insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    InsuranceQuote += 25;
                }
            }

            //if speeding tickets is more than 0
            if (insuree.SpeedingTickets > 0)
            {
                InsuranceQuote += insuree.SpeedingTickets * 10; //multiplpy number of tickets by 10 then add that to the basecost
            }

            //if user has a DUI add 25% of base cost to the total
            if (insuree.DUI.Equals("yes" , StringComparison.OrdinalIgnoreCase))
            {
                InsuranceQuote *= 1.25M;
            }

            //if user wants full coverege add 50%
            if (insuree.CoverageType.Equals("full", StringComparison.OrdinalIgnoreCase))
            {
                InsuranceQuote *= 1.50M;
            }

            return insuree.Quote;

        }

    }
}
