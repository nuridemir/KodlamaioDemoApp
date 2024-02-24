using KodlamaioApp.Buisness.Abstracts;
using KodlamaioApp.DataAccess.Abstracts;
using KodlamaioApp.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioApp.Buisness.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            _categoryDal.Add(t);
        }

        public void Delete(int Id)
        {
            _categoryDal.Delete(Id);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
