﻿using Core.Utilities.Result;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IDataResult<Rental> GetRentalByCarId(int carId);
        IDataResult<Rental> GetRentalByUserId(int userId);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();

    }
}
