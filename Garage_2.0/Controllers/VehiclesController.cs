#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage_2._0.Data;
using Garage_2._0.Models;

namespace Garage_2._0.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly Garage_2_0Context _context;

        public VehiclesController(Garage_2_0Context context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        public async Task<IActionResult> Index0()
        {
            return View(await _context.Vehicle.ToListAsync());
        }



        public async Task<IActionResult> Index10()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        public async Task<IActionResult> Index20()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        public async Task<IActionResult> Index30()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        public async Task<IActionResult> Index40()
        {
            return View(await _context.Vehicle.ToListAsync());
        }


        public async Task<IActionResult> Search(string regNo, int vehicleType)
        {
            var model = string.IsNullOrWhiteSpace(regNo) ?
                               _context.Vehicle :
                               _context.Vehicle.Where(m => m.RegNo.StartsWith(regNo));

            model = vehicleType == 0 ?
                    model :
                    model.Where(m => (int)m.vehicleType == vehicleType);

            return View(nameof(Index), await model.ToListAsync());
        }

        public async Task<IActionResult> Search0(string regNo, int vehicleType)
        {
            var model = string.IsNullOrWhiteSpace(regNo) ?
                               _context.Vehicle :
                               _context.Vehicle.Where(m => m.RegNo.StartsWith(regNo));

            model = vehicleType == 0 ?
                    model :
                    model.Where(m => (int)m.vehicleType == vehicleType);

            return View(nameof(Index0), await model.ToListAsync());
        }




        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create0()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parked,vehicleType,RegNo,ArrivalTime,Brand,Model,NoOfWheels,Color")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                 var myReg = _context.Vehicle.Where(a => a.RegNo == vehicle.RegNo).Single();

                if (myReg == null)
                {
                    _context.Add(vehicle);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index10));

                }
                if(myReg != null)
                {
                    return RedirectToAction(nameof(Index40));

                }
               


            }
            return View(vehicle);
        }









        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parked,vehicleType,RegNo,ArrivalTime,Brand,Model,NoOfWheels,Color")] Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index20));

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

           

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index30));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }
    }
}
