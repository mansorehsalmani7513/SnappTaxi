using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Snapp.Core.Securities;

using Snapp.DataAccessLayer.Entites;
using Snapp.Core.Interfaces;
using Snapp.Core.Services;
using Snapp.Core.ViewModels;

namespace Snapp.Site.Controllers
{
    public class AccountController : Controller
    {
        private IAccount _account;

        public AccountController(IAccount account)
        {
            _account = account;
        }

        public IActionResult Test(string id)
        {
            bool result = CheckNationalCode.CheckCode(id);

            return Content(result.ToString());
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _account.RegisterUser(viewModel);

                if (user != null)
                {
                    return RedirectToAction(nameof(Active));
                }                
            }

            return View(viewModel);
        }

        public IActionResult Driver()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Driver(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _account.RegisterDriver(viewModel);

                if (user != null)
                {
                    return RedirectToAction(nameof(Active));
                }
            }

            return View(viewModel);
        }



        public IActionResult Active()
        {
            ViewBag.IsError = false;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Active(ActiveViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _account.ActiveUser(viewModel);

                if (user != null)
                {
                    ViewBag.IsError = false;

                    // احراز هویت و ورود به داشبورد
                }
            }

            ViewBag.IsError = true;

            return View(viewModel);
        }
    }
}
