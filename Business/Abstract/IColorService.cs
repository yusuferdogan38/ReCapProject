﻿using Core.Utilities.Result;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
           IResult ColorAdd(Color color);
           IResult ColorDelete(Color color);
          IResult ColorUpdate(Color color);

        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetByColorId(int colorId);
    }
}
