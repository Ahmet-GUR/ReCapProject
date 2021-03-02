using Business.Abstract;
using Business.Constants;
using Core.Utilities.Resualts;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class BrandManeger : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManeger(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResualt Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResualt(Messages.Add);
        }

        public IDataResualt<List<Brand>> GetAll()
        {
            return new SuccessDataResualt<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResualt<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResualt<Brand>(_brandDal.GetById(b => b.BrandId == brandId));
        }

        public IResualt Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResualt(Messages.Update);
        }
    }
}
