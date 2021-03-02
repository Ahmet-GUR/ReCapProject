using Core.Utilities.Resualts;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResualt<List<Car>> GetAll();
        IDataResualt<List<Car>> GetByBrandId(int brandId);
        IDataResualt<List<Car>> GetByColorId(int colorId);
        IDataResualt<List<CarDateilDto>> GetByCarDetail();
        IDataResualt<Car> GetByCarId(int carId);
        IResualt Add(Car car);
        IResualt Update(Car car);
        IResualt Delete(Car car);
    }
}
