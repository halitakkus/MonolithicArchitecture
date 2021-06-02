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
    public class AdminController : ControllerBase
    {
        private IUserManager _userManager;

        public AdminController()
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
        public ActionResult Add(User user)
        {
          var checkResult =  _userManager.Add(user);

          return Ok(checkResult);
        }

        [HttpPost]
        [Route("RemoveById")]
        public ActionResult RemoveById(Guid id)
        {
            var checkResult = _userManager.Remove(new User { Id = id });

            return Ok(checkResult);
        }

        [HttpPatch]
        [Route("Update")]
        public ActionResult Update(User user)
        {
            var checkResult = _userManager.Update(user);

            return Ok(checkResult);
        }
    }
}
