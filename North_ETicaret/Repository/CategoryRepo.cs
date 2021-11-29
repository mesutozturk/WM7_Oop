using Microsoft.EntityFrameworkCore;
using North_ETicaret.Models;
using System.Collections.Generic;
using System.Linq;

namespace North_ETicaret.Repository
{
    public class CategoryRepo : Repository<Category>, ISqlDml<Category>, ISqlQuery<Category, int>
    {
        public Category Get(int id)
        {
            return Table.Find(id);
        }

        public List<Category> GetAll()
        {
            return Table.ToList();
        }
        public void Add(Category entity)
        {
            Table.Add(entity);
        }

        public void Delete(Category entity)
        {
            Table.Remove(entity);
        }

        public void Update(Category entity)
        {
            Table.Update(entity);
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Category> Include(params string[] include)
        {
            foreach (var item in include)
            {
                Table.Include(item);
            }
            return Table;
        }
    }
}