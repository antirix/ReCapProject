using Core.DataAcces;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserDal2 : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
