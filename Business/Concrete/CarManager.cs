using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using Core.Utilities.Results;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
            
        {
            _carDal.Add(car);
            return new SuccessDataResult<Car>(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessDataResult<Car>(Messages.BrandDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<Car> GetByCarId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            
            return new SuccessDataResult<List<CarDetailsDto>>
                (_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessDataResult<Car>();
        }
    }
}
