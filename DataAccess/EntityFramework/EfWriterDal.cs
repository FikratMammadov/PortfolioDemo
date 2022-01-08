using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public List<Writer> GetAllWritersContain(string chr)
        {
            using (Context context = new Context())
            {
                var result = context.Writers.Where(w => w.Name.Contains(chr)).ToList();
                return result;
            }
        }
    }
}
