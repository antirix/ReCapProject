using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramwork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapProjectContext>, IColorDal
    {
    }
}
