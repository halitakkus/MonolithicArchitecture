using KluCareer.DataAccessLayer.Abstract;
using KluCareer.DataAccessLayer.Concrate.Contexts;
using KluCareer.DataAccessLayer.Concrate.EntityFramework.Repository;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace KluCareer.DataAccessLayer.Concrate.EntityFramework
{
    public class EfAdminDal : EfRepository<Admin, KluCareerContext>, IAdminDal
    {
        //diğer operasyonlar buradan yönetilir...

        public List<User> GetListFullInclude()
        {
            using (var context = new KluCareerContext())
            {
                return context.User
                    .Select(i => new User { CreatedDate = i.CreatedDate, ModifiedDate = i.ModifiedDate, UserName = i.UserName})
                    .ToList();
            }
        }

        public bool Any(string userName)
        {
            using (var context = new KluCareerContext())
            {
                return context.User
                   .Any(i => i.UserName == userName);
            }
        }
    }
}
