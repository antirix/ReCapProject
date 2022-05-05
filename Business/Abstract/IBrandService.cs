﻿using Core.Utilities.Result;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetBrandById(int id);

        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IResult Add(Brand brand);
    }
}