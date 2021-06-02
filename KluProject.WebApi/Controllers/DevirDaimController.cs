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
    public class DevirDaimController : ControllerBase
    {
        private IUserManager _userManager;

        public DevirDaimController()
        {
            _userManager = null;
        }

        [HttpGet]
        [Route("GetList")]
        public ActionResult GetList()
        {
            var userList = _userManager.GetListFullInclude();
            return Ok(userList);
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult Add(DevirDaim devirDaim)
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
        public ActionResult Update(DevirDaim devirDaim)
        {
            return Ok();
        }
    }
}
