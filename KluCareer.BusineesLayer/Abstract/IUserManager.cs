using KluCareer.BusineesLayer.Result;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Abstract
{
    public interface IUserManager
    {
        IResult Add(User user);
        IResult Any(string userName, string password);
        IResult Update(User user);
        IResult Remove(User user);
        IDataResult<List<User>> GetList();
        IDataResult<List<User>> GetListFullInclude();
    }
}
