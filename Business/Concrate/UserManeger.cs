using Business.Abstract;
using Business.Constants;
using Core.Utilities.Resualts;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserManeger : IUserService
    {
        IUserDal _userDal;

        public UserManeger(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResualt Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResualt(Messages.Delete);
        }

        public IDataResualt<List<User>> GetAll()
        {
            return new SuccessDataResualt<List<User>>(_userDal.GetAll());
        }

        public IDataResualt<User> GetByUserId(int userId)
        {
            return new SuccessDataResualt<User>(_userDal.GetById(u => u.UserId == userId));
        }

        public IResualt Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResualt(Messages.Update);
        }
    }
}
