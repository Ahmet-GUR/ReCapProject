using Core.Utilities.Resualts;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResualt<List<Rental>> GetAll();
        IDataResualt<Rental> GetByRentalId(int rentalId);
        IDataResualt<List<RentalDetailDto>> GetByRentalDetail();
        IResualt Add(Rental rental);
        IResualt Update(Rental rental);
        IResualt Delete(Rental rental);
    }
}
