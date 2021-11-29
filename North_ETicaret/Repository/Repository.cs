using Microsoft.EntityFrameworkCore;
using North_ETicaret.Models;

namespace North_ETicaret.Repository
{
    public abstract class Repository<T> where T : class
    {
        protected NorthwindContext Context { get; set; }
        public DbSet<T> Table { get; set; }
        public Repository()
        {
            Context = new NorthwindContext();
            Table = Context.Set<T>();
        }
    }
}
