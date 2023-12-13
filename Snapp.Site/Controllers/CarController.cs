using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Snapp.Core.Interfaces;
using Snapp.Core.Services;
using Snapp.Core.ViewModels.Admin;

using Snapp.DataAccessLayer.Entites;

namespace Snapp.Site.Controllers
{
    public class CarController : Controller
    {
        private IAdmin _admin;

        public CarController(IAdmin admin)
        {
            _admin = admin;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _admin.GetCars();

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _admin.AddCar(viewModel);

                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _admin.GetCarById(id);

            CarViewModel viewModel = new CarViewModel()
            {
                Name = result.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, CarViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                bool result = _admin.UpdateCar(id, viewModel);

                if (result == true)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(viewModel);
        }

        public IActionResult Delete(Guid id)
        {
            _admin.DeleteCar(id);

            //if (result == true)
            //{
            //    return RedirectToAction(nameof(Index));
            //}

            return RedirectToAction(nameof(Index));
        }
    }
}
