using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
        public List<Heading> GetHeadingsByCategoryName(string name)
        {
            using (Context context = new Context())
            {
                var result = context.Headings
                    .Where(h => h.Category == context.Categories.Where(c => c.Name == name).FirstOrDefault())
                    .ToList();
                return result;
            }
        }
    }
}
