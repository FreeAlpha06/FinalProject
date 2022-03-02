using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDdal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDdal.Get(c => c.CategoryId == categoryId); 
        }
    }
}
