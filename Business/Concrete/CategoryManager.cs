using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDdal;

        public CategoryManager(ICategoryDal categoryDdal)
        {
            _categoryDdal = categoryDdal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Category>>(_categoryDdal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDdal.Get(c => c.CategoryId == categoryId));
        }


    }
}
