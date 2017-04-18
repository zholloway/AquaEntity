using AquaEntity.DataContext;
using AquaEntity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AquaEntity.Controllers
{
    public class AquaticLifeController : ApiController
    {
        public static AquaContext database = new AquaContext();
        AquaticLifeServices aquaticLifeServices = new AquaticLifeServices(database);

        [HttpGet]
        public IHttpActionResult Get(int aquariumID)
        {
            return Ok(aquaticLifeServices.GetFishFromAquarium(aquariumID));
        }
    }
}
