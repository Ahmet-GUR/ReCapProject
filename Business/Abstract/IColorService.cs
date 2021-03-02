using Core.Utilities.Resualts;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResualt<List<Color>> GetAll();
        IDataResualt<Color> GetByColorId(int colorId);
        IResualt Add(Color color);
        IResualt Update(Color color);
        IResualt Delete(Color color);
    }
}
