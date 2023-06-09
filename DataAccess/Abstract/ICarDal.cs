﻿using Core.DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        CarDetailDto GetCarDetail(int carId);
        List<CarDetailDto> GetCarsDetails();
        List<CarDetailDto> GetCarsDtoByBrandId(int id);
        List<CarDetailDto> GetCarsDtoByColorId(int id);
    }
}
