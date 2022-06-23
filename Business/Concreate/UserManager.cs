using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User1 user)
        {
           _userDal.Add(user);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(User1 user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<User1>> GetAll()
        {
           return new SuccessDataResult<List<User1>>(_userDal.GetAll());
        }

        public IDataResult<List<User1>> GetUserById(int id)
        {
            return new SuccessDataResult<List<User1>>(_userDal.GetAll(p => p.Id==id));
        }

        public IResult Update(User1 user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
