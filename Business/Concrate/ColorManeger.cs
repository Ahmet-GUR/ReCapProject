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
    public class ColorManeger : IColorService
    {
        IColorDal _colorDal;

        public ColorManeger(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResualt Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResualt(Messages.Add);
        }

        public IResualt Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResualt(Messages.Delete);
        }

        public IDataResualt<List<Color>> GetAll()
        {
            return new SuccessDataResualt<List<Color>>(_colorDal.GetAll());
        }

        public IDataResualt<Color> GetByColorId(int colorId)
        {
            return new SuccessDataResualt<Color>(_colorDal.GetById(co => co.ColorId == colorId));
        }

        public IResualt Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResualt(Messages.Update);
        }
    }
}
