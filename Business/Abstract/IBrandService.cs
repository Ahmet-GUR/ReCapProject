using Core.Utilities.Resualts;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResualt<List<Brand>> GetAll();
        IDataResualt<Brand> GetByBrandId(int brandId);
        IResualt Add(Brand brand);
        IResualt Update(Brand brand);
        IResualt Delete(Brand brand);
    }
}
