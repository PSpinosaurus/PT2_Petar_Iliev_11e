using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataLayer
{
    public class InterestsContext : IDb<Interest, int>
    {

        private readonly Test2DbContext dbContext;

        public InterestsContext(Test2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Interest item)
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

                Category categryFromDb = dbContext.Categories.Find(item.Category.Id);

                if (categryFromDb != null)
                {
                    item.Category = categryFromDb;
                }

                dbContext.Interests.Add(item);
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
                Interest interest = dbContext.Interests.Find(key);
                if (interest != null)
                {
                    dbContext.Interests.Remove(interest);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No such interest in the database!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Interest Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Interest> query = dbContext.Interests;
                if (useNavigationalProperties)
                {
                    query = query.Include(i => i.Users).Include(i => i.Category);
                }

                return query.FirstOrDefault(i => i.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Interest> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Interest> query = dbContext.Interests;
                if (useNavigationalProperties)
                {
                    query = query.Include(i => i.Users).Include(i => i.Category);
                }

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Interest item, bool useNavigationalProperties = false)
        {
            try
            {

                Interest interestFromDb = dbContext.Interests.Find(item.Id);
                interestFromDb.Name = item.Name;

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

                    interestFromDb.Users = usersFromDb;

                    Category categryFromDb = dbContext.Categories.Find(item.Category.Id);

                    if (categryFromDb != null)
                    {
                        interestFromDb.Category = categryFromDb;
                    }
                }

                dbContext.Interests.Update(item);
                dbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
