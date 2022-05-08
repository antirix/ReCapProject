using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataAccess.Concreate.EntityFramwork
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
    }
}
