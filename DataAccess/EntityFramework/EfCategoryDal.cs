using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public Category GetCategoryHasMostHeading()
        {
            using (var context = new Context())
            {
                //var result = context.Categories
                //    .Include(c => c.Headings)
                //    .GroupBy(c => c.Id)
                //    .Where(grp => grp.Count() > 1)
                //    .OrderByDescending(c => c.Count())
                //    .;

                var result = (from c in context.Categories
                             join h in context.Headings
                             on c.Id equals h.CategoryId
                             group c by c.Id into grp
                             where grp.Count() > 1
                             orderby grp.Count() descending
                             select new
                             {
                                 Key = grp.Key,
                                 Category = grp
                             }).FirstOrDefault();


                return result.Category.FirstOrDefault();
            }
            
        }
    }
    //select top 1 c.Name as name,Count(*) as  count from Categories c
    //left join Headings h
    //on c.Id = h.CategoryId
    //group by c.Name
    //having Count(*)>1
    //order by count desc





}
