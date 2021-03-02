using Core.Utilities.Resualts;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResualt<List<User>> GetAll();
        IDataResualt<User> GetByUserId(int userId);
        IResualt Add(User user);
        IResualt Update(User user);
        IResualt Delete(User user);
    }
}
