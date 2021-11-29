using Microsoft.EntityFrameworkCore;
using North_ETicaret.Models;
using System.Collections.Generic;
using System.Linq;

namespace North_ETicaret.Repository
{
    public class CustomerRepo : Repository<Customer>, ISqlDml<Customer>, ISqlQuery<Customer, string>
    {
        public void Add(Customer entity)
        {
            Table.Add(entity);
        }

        public void Delete(Customer entity)
        {
            Table.Remove(entity);
        }

        public Customer Get(string id)
        {
            return Table.Find(id);
        }

        public List<Customer> GetAll()
        {
            return Table.ToList();
        }

        public IQueryable<Customer> Include(params string[] include)
        {
            foreach (var item in include)
            {
                Table.Include(item);
            }
            return Table;
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            Table.Update(entity);
        }
    }
}
