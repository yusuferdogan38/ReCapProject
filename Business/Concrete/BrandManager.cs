using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService

    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult BrandAdd(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessDataResult<Brand>(Messages.BrandAdded);
           
        }

        public IResult BrandDelete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessDataResult<Brand>(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == brandId));
        }
    }
}
