using LibraryAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAsp.Dao
{
    
    public class CategoryDao
    {
        LibraryDbContext myDb = new LibraryDbContext();
        public List<Category> getAll()
        {
            return myDb.categories.OrderByDescending(p => p.id_category).ToList();
        }
        public void add(Category category)
        {
            myDb.categories.Add(category);
            myDb.SaveChanges();
        }
        public void edit(Category category)
        {
            var result = myDb.categories.SingleOrDefault(c => c.id_category == category.id_category);
            result.name = category.name;
            myDb.SaveChanges();
        }
    }
}