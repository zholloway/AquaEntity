using AquaEntity.DataContext;
using AquaEntity.Models;
using AquaEntity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AquaEntity.Controllers
{
    public class AquariumController : ApiController
    {
        public static AquaContext database = new AquaContext();
        AquariumServices aquariumServices = new AquariumServices(database);

        //GET
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(aquariumServices.GetAllAquariums());
        }

        //CREATE
        [HttpPut]
        public IHttpActionResult Create(Aquarium aq)
        {
            aquariumServices.CreateAquarium(aq);
            return Ok("Successfully created");
        }

        //UPDATE
        [HttpPost]
        public IHttpActionResult Update(Aquarium aq)
        {
            aquariumServices.UpdateAquarium(aq);
            return Ok("Successfully updated");
        }

        //DELETE
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            aquariumServices.DeleteAquarium(id);
            return Ok("Successfully deleted");
        }
    }
}
