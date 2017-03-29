using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using moneycontrol.Models;
using System.Threading.Tasks;

namespace moneycontrol.Controllers
{
    public class InterestController : ApiController
    {
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, Type=typeof(double))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type= typeof(ErrorBody))]
        [Route("api/Interest/Simple/{p}/{r}/{t}")]
        public IHttpActionResult Simple(int p, int r, int t)
        {
            if(t < 0)
            {
                return Content(HttpStatusCode.BadRequest, new ErrorBody("E0001", "Time cannot be negative or zero."));
            }
            if(r < 0)
            {
                return Content(HttpStatusCode.BadRequest, new ErrorBody("E0002", "Rate of interest cannot be negative or zero."));
            }

            if (p < 0)
            {
                return Content(HttpStatusCode.BadRequest, new ErrorBody("E0003", "Principal cannot be negative or zero."));
            }

            double interest = (p * r * t) / 100;
            return Content(HttpStatusCode.OK, interest);
        }
    }
}
