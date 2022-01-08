using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

         

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public int DifferenceBetweenCategoryStatus()
        {
            return Math.Abs( _categoryDal.List(c => c.Status == true).Count - _categoryDal.List(c => c.Status == false).Count);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c=>c.Id==id);
        }

        public Category GetCategoryHasMostHeadings()
        {
            return _categoryDal.GetCategoryHasMostHeading();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}

        //public void Add(Category category)
        //{
        //    repo.Add(category);
        //    //if (category.Name == "" || category.Name.Length <= 3 ||
        //    //    category.Description == "" || category.Description.Length <= 51)
        //    //{
        //    //    // Hata mesaji
        //    //}
        //    //else
        //    //{
        //    //    repo.Add(category);
        //    //}
        //}
    }
}
