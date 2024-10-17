using Core.Utilities.Result;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult BrandAdd(Brand brand);
        IResult BrandDelete(Brand brand);
        IResult BrandUpdate(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetByBrandId(int brandId);

    }
}
