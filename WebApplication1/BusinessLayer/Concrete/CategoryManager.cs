﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAddBL(Category category)
        {
            _categorydal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        void ICategoryService.CategoryAdd(Category Category)
        {
            throw new NotImplementedException();
        }

        List<Category> ICategoryService.GetList()
        {
            throw new NotImplementedException();
        }
    }



}

