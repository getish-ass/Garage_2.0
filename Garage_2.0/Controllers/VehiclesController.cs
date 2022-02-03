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
using Garage_2._0.Models.ViewModel;


namespace Garage_2._0.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly Garage_2_0Context _context;

        public VehiclesController(Garage_2_0Context context)
        {
            _context = context;
        }

        // GET: Overview Vehicles ; Pekka asks: Is this used 2022-02-02 ?
        public async Task<IActionResult> Overview()
        {
            var viewModel = _context.Vehicle.Select(e => new VehicleIndexViewModel
            {
                Id = e.Id,
                Parked = e.Parked,
                RegNo = e.RegNo,
                ArrivalTime = e.ArrivalTime,
                VehicleType = e.VehicleType
            });


        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var model = new DataModel
            {
                Vehicles = await _context.Vehicle.ToListAsync(),
                VehicleTypes = await GetVehiclesTypeAsync()
            };
            return View(model);
        }

        private async Task<IEnumerable<SelectListItem>> GetVehiclesTypeAsync()
        {
            return await _context.Vehicle
                                 .Select(m => m.VehicleType)
                                 .Distinct()
                                 .Select(g => new SelectListItem
                                 {
                                     Text = g.ToString(),
                                     Value = g.ToString()
                                 })
                                 .ToListAsync();
        }

        public async Task<IActionResult> Search(DataModel dataModel)
        {
            var model = string.IsNullOrWhiteSpace(dataModel.RegNo) ?
                              _context.Vehicle :
                              _context.Vehicle.Where(m => m.RegNo.StartsWith(dataModel.RegNo));


            model = dataModel.VehicleType == null ?
                          model :
                          model.Where(m => m.VehicleType == dataModel.VehicleType);

            var searchResult = await model.ToListAsync();

            var viewModel = new DataModel
            {
                Vehicles = searchResult
            };

            return View(nameof(Index), viewModel);

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

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parked,RegNo,ArrivalTime,Brand,Model,NoOfWheels,Color")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parked,RegNo,ArrivalTime,Brand,Model,NoOfWheels,Color")] Vehicle vehicle)
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
                return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }

        // Pekka: not used 2022-02-02
        public bool RegNoExists(string regNo)
        {
            return _context.Vehicle.Any(v => v.RegNo == regNo);
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.Id == id);
        }
    }
}
