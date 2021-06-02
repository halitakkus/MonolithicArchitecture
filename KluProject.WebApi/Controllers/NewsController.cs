using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KluCareer.BusineesLayer.Abstract;
using KluCareer.Entities.Concrate.Models;
using Microsoft.AspNetCore.Mvc;

namespace KluProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private IUserManager _userManager;

        public NewsController()
        {
            _userManager = null;
        }

        [HttpGet]
        [Route("GetList")]
        public ActionResult GetList()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult Add(News news)
        {
          return Ok();
        }

        [HttpPost]
        [Route("RemoveById")]
        public ActionResult RemoveById(Guid id)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("Update")]
        public ActionResult Update(News user)
        {
            return Ok();
        }
    }
}
