using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autfac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Resualts;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManeger : ICarService
    {
        ICarDal _carDal;

        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResualt Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResualt(Messages.Delete);
        }

        public IDataResualt<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResualt<List<Car>>(Messages.MaintenanceHour);
            }
            return new SuccessDataResualt<List<Car>>(_carDal.GetAll());
        }

        public IDataResualt<List<Car>> GetByBrandId(int brandId)
        {
            return new SuccessDataResualt<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResualt<List<CarDateilDto>> GetByCarDetail()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResualt<List<CarDateilDto>>(Messages.MaintenanceHour);
            }
            return new SuccessDataResualt<List<CarDateilDto>>(_carDal.GetByCarDetail());
        }

        public IDataResualt<Car> GetByCarId(int carId)
        {
            return new SuccessDataResualt<Car>(_carDal.GetById(c => c.CarId == carId));
        }

        public IDataResualt<List<Car>> GetByColorId(int colorId)
        {
            return new SuccessDataResualt<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResualt Update(Car car)
        {
            if (car.DailyPrice <= 0 || car.Description.Length < 2)
            {
                return new ErrorResualt(Messages.InvaledData);
            }
            _carDal.Update(car);
            return new SuccessResualt(Messages.Update);
        }
    }
}
