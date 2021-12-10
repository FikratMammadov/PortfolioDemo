using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>(); 

        public List<Category> GetAll()
        {
            return repo.List();
        } 

        public void Add(Category category)
        {
            if (category.Name=="" || category.Name.Length<=3 ||
                category.Description=="" || category.Description.Length<=51)
            {
                // Hata mesaji
            }
            else
            {
                repo.Add(category);
            }
        }
    }
}
