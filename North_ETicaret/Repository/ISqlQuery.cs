using System.Collections.Generic;
using System.Linq;

namespace North_ETicaret.Repository
{
    public interface ISqlQuery<T,Tid> where T : class
    {
        T Get(Tid id);
        List<T> GetAll();
        IQueryable<T> Include(params string[] include);
    }
}
