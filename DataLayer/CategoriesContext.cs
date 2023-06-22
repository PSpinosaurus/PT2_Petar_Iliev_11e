using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoriesContext : IDb<Category, int>
    {
        private readonly Test2DbContext dbContext;

        public CategoriesContext(Test2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Category item)
        {
            try
            {
                List<User> usersFromDb = new List<User>();
                foreach (User user in item.Users) 
                {
                    User userFromDb = dbContext.Users.Find(user.Id);
                    if (userFromDb != null)
                    {
                        usersFromDb.Add(userFromDb);
                    }
                    else
                    {
                        usersFromDb.Add(user);
                    }
                }
                item.Users = usersFromDb;

                List<Interest> interestsFromDb = new List<Interest>();
                foreach (Interest interest in item.Interests)
                {
                    Interest interestFromDb = dbContext.Interests.Find(interest.Id);
                    if (interestFromDb != null)
                    {
                        interestsFromDb.Add(interestFromDb);
                    }
                    else
                    {
                        interestsFromDb.Add(interest);
                    }
                }
                item.Interests = interestsFromDb;

                dbContext.Categories.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Category category = dbContext.Categories.Find(key);
                if (category != null)
                {
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No such category in the database!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Category> query = dbContext.Categories;

                if (useNavigationalProperties)
                {
                    query.Include(c => c.Interests).Include(c => c.Users);
                }

                return query.FirstOrDefault(c => c.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Category> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Category> query = dbContext.Categories;

                if (useNavigationalProperties)
                {
                    query.Include(c => c.Interests).Include(c => c.Users);
                }

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Category item, bool useNavigationalProperties = false)
        {
            try
            {
                Category categoryFromDb = dbContext.Categories.Find(item.Id);
                categoryFromDb.Name = item.Name;

                if (useNavigationalProperties)
                {
                    List<User> usersFromDb = new List<User>();
                    foreach (User user in item.Users)
                    {
                        User userFromDb = dbContext.Users.Find(user.Id);
                        if (userFromDb != null)
                        {
                            usersFromDb.Add(userFromDb);
                        }
                        else
                        {
                            usersFromDb.Add(user);
                        }
                    }
                    categoryFromDb.Users = usersFromDb;

                    List<Interest> interestsFromDb = new List<Interest>();
                    foreach (Interest interest in item.Interests)
                    {
                        Interest interestFromDb = dbContext.Interests.Find(interest.Id);
                        if (interestFromDb != null)
                        {
                            interestsFromDb.Add(interestFromDb);
                        }
                        else
                        {
                            interestsFromDb.Add(interest);
                        }
                    }
                    categoryFromDb.Interests = interestsFromDb;
                }    
                
                dbContext.Categories.Update(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
