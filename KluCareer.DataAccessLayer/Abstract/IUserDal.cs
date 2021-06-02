using KluCareer.DataAccessLayer.Abstract.Repository;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.DataAccessLayer.Abstract
{
    public interface IUserDal:IRepository<User>
    {
      public List<User> GetListFullInclude();
        public bool Any(string userName, string password);
        public bool Any(string userName);
    }
}
