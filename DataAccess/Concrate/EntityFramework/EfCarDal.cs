using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDateilDto> GetByCarDetail()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var resualt = from ca in context.Cars
                              join co in context.Colors
                              on ca.ColorId equals co.ColorId
                              join b in context.Brands
                              on ca.BrandId equals b.BrandId
                              select new CarDateilDto
                              {
                                  CarId = ca.CarId,
                                  ColorName = co.ColorName,
                                  BrandName = b.BrandName,
                                  DailyPrice = ca.DailyPrice
                              };
                return resualt.ToList();
            }

        }
    }
}
