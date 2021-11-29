using System.Collections.Generic;

namespace North_ETicaret.Repository
{
    public interface ISqlQuery<T,Tid> where T : class
    {
        T Get(Tid id);
        List<T> GetAll();
    }
}
