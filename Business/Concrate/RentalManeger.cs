using Business.Abstract;
using Business.Constants;
using Core.Utilities.Resualts;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrate
{
    public class RentalManeger : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManeger(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResualt Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResualt(Messages.Delete);
        }

        public IDataResualt<List<Rental>> GetAll()
        {
            return new SuccessDataResualt<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResualt<List<RentalDetailDto>> GetByRentalDetail()
        {
            return new SuccessDataResualt<List<RentalDetailDto>>(_rentalDal.GetByRentalDetail());
        }

        public IDataResualt<Rental> GetByRentalId(int rentalId)
        {
            return new SuccessDataResualt<Rental>(_rentalDal.GetById(r => r.RentalId == rentalId));
        }

        public IResualt Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResualt(Messages.Update);
        }
    }
}
