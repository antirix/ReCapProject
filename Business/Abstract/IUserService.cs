using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User1>> GetAll();
        IDataResult<List<User1>> GetUserById(int id);
        IResult Add(User1 user);
        IResult Update(User1 user);
        IResult Delete(User1 user);
    }
}
