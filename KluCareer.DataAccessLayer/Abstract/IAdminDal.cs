using KluCareer.DataAccessLayer.Abstract.Repository;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.DataAccessLayer.Abstract
{
    public interface IAdminDal:IRepository<Admin>
    {
      public List<User> GetListFullInclude();
        public bool Any(string userName);
    }
}
