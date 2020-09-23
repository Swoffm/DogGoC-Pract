using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DogGo.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogRepository _dogRepository;

        public DogController(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }


        [Authorize]
        public ActionResult Index()
        {
            int ownerId = GetCurrentUserId();

            List<Dog> dogs = _dogRepository.GetDogsByOwnerId(ownerId);

            return View(dogs);
        }



        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }

        public ActionResult Create()
        {
           
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dog dog)
        {
            try
            {
                // update the dogs OwnerId to the current user's Id 
                dog.OwnerId = GetCurrentUserId();

                _dogRepository.AddDog(dog);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(dog);
            }
        }





    }
}
