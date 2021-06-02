using KluCareer.BusineesLayer.Abstract;
using KluCareer.BusineesLayer.Result;
using KluCareer.DataAccessLayer.Abstract;
using KluCareer.DataAccessLayer.Concrate.EntityFramework;
using KluCareer.Entities.Concrate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.BusineesLayer.Concrate
{
    public class UserManager : IUserManager
    {
        private IUserDal _userDal = new EfUserDal();
       
        public IResult Add(User user)
        {
            bool any = _userDal.Any(user.UserName);

            if (any)
            {
                var errorResult = new ErrorResult();
                errorResult.AddMessage("ObjectNotAdded", "Böyle bir kullanıcı bulunmaktadır!!");
                return errorResult;
            }

            bool isAdded = _userDal.Add(user);


            if (!isAdded)
            {
                var errorResult = new ErrorResult();
                errorResult.AddMessage("ObjectNotAdded","Veri bir hata sonucu eklenemedi.");
                return errorResult;
            }
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetList()
        {
            var users = _userDal.GetList();
            return new SuccessDataResult<List<User>>(users);
        }

        public IDataResult<List<User>> GetListFullInclude()
        {
            var users = _userDal.GetListFullInclude();
            return new SuccessDataResult<List<User>>(users);
        }

        public IResult Remove(User user)
        {
            var remove = _userDal.Remove(user);
            if (!remove)
            {
                var error = new ErrorResult();

                error.AddMessage("notDeleted", "veri silinemedi");
                return error;
            }
            return new SuccessResult();
        }

        public IResult Any(string  userName, string password)
        {
            var any = _userDal.Any(userName, password);
            if (!any)
            {
                var error = new ErrorResult();

                error.AddMessage("userNotFound", "Böyle bir kullanıcı yok!");
                return error;
            }
            return new SuccessResult();
        }


        public IResult Update(User user)
        {
           
            var error = new ErrorResult();
            var isValid = _userDal.GetById(user.Id);
            if (isValid==null)
            {
                error.AddMessage("objectNotFount", "Veri bulunamadı.");
                return error;
            }

            if (user==null)
            {
                error.AddMessage("objectNotFount","Doğrulama başarısız..");
                return error;
            }
            var isUpdate = _userDal.Update(user);
            if (!isUpdate)
            {
                error.AddMessage("failed", "Veri güncellenemedi.");
                return error;
            }
            return new SuccessResult();
        }
    }
}
