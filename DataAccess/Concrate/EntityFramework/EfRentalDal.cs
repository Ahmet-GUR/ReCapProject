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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetByRentalDetail()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var resualt = from ren in context.Rentals
                              join ca in context.Cars
                              on ren.CarId equals ca.CarId
                              join b in context.Brands
                              on ren.BrandId equals b.BrandId
                              join cu in context.Customers
                              on ren.CustomerId equals cu.CustomerId
                              select new RentalDetailDto
                              {
                                  RentalId = ren.RentalId,
                                  CarId = ca.CarId,
                                  BrandName = b.BrandName,
                                  CompanyName = cu.CompanyName,
                                  RentDeta = ren.RentDeta,
                                  ReturnDeta = ren.ReturnDate
                              };
                return resualt.ToList();
            }
        }
    }
}
