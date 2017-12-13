using FunkyFadz.Contracts;
using FunkyFadz.Models;
using FunkyFadz.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunkyFadz.WebMVC.Controllers
{   
   
    public class FunkyFadzController : Controller
    {

        private readonly Lazy<IFunkyFadzService> _funkyFadzService;

        public FunkyFadzController()
        {
            _funkyFadzService = new Lazy<IFunkyFadzService>(FunkyFadzService);
                
        }


        /// <summary>
        /// Principally used for testing
        /// </summary>
        /// <param name="funkyFadzService"></param>
        public FunkyFadzController(Lazy<IFunkyFadzService> funkyFadzService)
        {
            _funkyFadzService = funkyFadzService;
        }


        // GET: FunkyFadz
        [AllowAnonymous]
        public ActionResult Index()
        {
            var model = _funkyFadzService.Value.GetFunkyFadz();


            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FunkyFadzCreateModel model)
        {

            if (!ModelState.IsValid) return View(model);

            if (_funkyFadzService.Value.CreateFunkyFadz(model)) 
            {
                TempData["SaveResult"] = "Sick Fad!! Thanks!!.";
                return RedirectToAction("Index");
            };


            ModelState.AddModelError("", "Your Fad could not be created :(.");

            return View(model);

            
        }

        //GET method for Edit
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            var model = _funkyFadzService.Value.GetFunkyFadzById(id);

            return View(model);
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            var detail = _funkyFadzService.Value.GetFunkyFadzById(id);
            var model =
                new FunkyFadzEditModel
                {
                    FunkyFadzId = detail.FunkyFadzId,
                    FadType = detail.FadType,
                    Description = detail.Description,
                    Year = detail.Year,
                };

            return View(model);
        }

        //POst method for Edit
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (int id, FunkyFadzEditModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.FunkyFadzId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }


            if (_funkyFadzService.Value.UpdateFunkyFadz(model))
            {
                TempData["SaveResult"] = "Your Fad was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Fad could not be updated.");
            return View(model);
        }


        [ActionName("Delete")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var model = _funkyFadzService.Value.GetFunkyFadzById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            _funkyFadzService.Value.DeleteFunkyFadz(id);

            TempData["SaveResult"] = "Your Fad was deleted!";

            return RedirectToAction("Index");
        }

        private IFunkyFadzService FunkyFadzService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new FunkyFadzService(userId);
            return service;
        }

    }
}