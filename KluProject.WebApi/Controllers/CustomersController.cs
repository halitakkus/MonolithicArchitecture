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
    public class CustomersController : ControllerBase
    {
        private IUserManager _userManager;

        public CustomersController()
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
        public ActionResult Add(Customers customer)
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
        public ActionResult Update(Customers customer)
        {
            return Ok();
        }
    }
}
