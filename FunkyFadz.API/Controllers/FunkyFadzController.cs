using FunkyFadz.Models;
using FunkyFadz.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FunkyFadz.API.Controllers
{
    [Authorize]
    public class FunkyFadzController : ApiController
    {   
        //GET / api/note
        public IHttpActionResult GetAll()
        {
            FunkyFadzService funkyFadzService = CreateFunkyFadz();

            var FunkyFadz = funkyFadzService.GetFunkyFadz();

            return Ok(FunkyFadz);
        }

        public IHttpActionResult Get(int id)
        {
            var funkyFadzService = CreateFunkyFadz();
            var quote = funkyFadzService.GetFunkyFadzById(id);
            return Ok(quote);
        }

        public IHttpActionResult Post(FunkyFadzCreateModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var service = CreateFunkyFadz();

            if (!service.CreateFunkyFadz(model))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(FunkyFadzEditModel Fad)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateFunkyFadz();

            if (!service.UpdateFunkyFadz(Fad))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete (int id)
        {
            var service = CreateFunkyFadz();

            if (!service.DeleteFunkyFadz(id))
                return InternalServerError();

            return Ok();
        }


        private FunkyFadzService CreateFunkyFadz()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var funkyFadzService = new FunkyFadzService(userId);
            return funkyFadzService;
        }

        

    }
}
