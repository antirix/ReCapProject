using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUserById(int id);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
