using Core.DataAcces;
using Entities.Concreate;
using System;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User1>
    {
    }
}
