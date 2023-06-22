using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataLayer
{
    public class UsersContext : IDb<User, int>
    {

        private readonly Test2DbContext dbContext;

        public UsersContext(Test2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(User item)
        {
            try
            {
                List<User> friendsFromDb = new List<User>();
                foreach (User friend in item.Friends) 
                { 
                    User friendFromDb = dbContext.Users.Find(friend.Id);
                    if (friendFromDb != null)
                    {
                        friendsFromDb.Add(friendFromDb);
                    }
                    else
                    {
                        friendsFromDb.Add(friend);
                    }
                }

                item.Friends = friendsFromDb;

                List<User> friendOfFromDb = new List<User>();
                foreach (User friend in item.FriendOf)
                {
                    User friendFromDb = dbContext.Users.Find(friend.Id);
                    if (friendFromDb != null)
                    {
                        friendOfFromDb.Add(friendFromDb);
                    }
                    else
                    {
                        friendOfFromDb.Add(friend);
                    }
                }

                item.FriendOf = friendOfFromDb;

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

                dbContext.Users.Add(item);
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
                User user = dbContext.Users.Find(key);
                if (user != null)
                { 
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                }
                else 
                {
                    throw new Exception("No such user in the database!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<User> query = dbContext.Users;
                if (useNavigationalProperties)
                {
                    query = query.Include(u => u.Friends).Include(u => u.Interests);
                }

                return query.FirstOrDefault(u => u.Id == key);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<User> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<User> query = dbContext.Users;
                if (useNavigationalProperties)
                {
                    query = query.Include(u => u.Friends).Include(u => u.Interests);
                }

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(User item, bool useNavigationalProperties = false)
        {
            try
            {
                User userFromDb = dbContext.Users.Find(item.Id);
                userFromDb.FirstName = item.FirstName;
                userFromDb.LastName = item.LastName;
                userFromDb.Age = item.Age;
                userFromDb.UserName = item.UserName;
                userFromDb.Password = item.Password;
                userFromDb.Email = item.Email;

                if (useNavigationalProperties)
                {
                    List<User> friendsFromDb = new List<User>();
                    foreach (User friend in item.Friends)
                    {
                        User friendFromDb = dbContext.Users.Find(friend.Id);
                        if (friendFromDb != null)
                        {
                            friendsFromDb.Add(friendFromDb);
                        }
                        else
                        {
                            friendsFromDb.Add(friend);
                        }
                    }

                    userFromDb.Friends = friendsFromDb;

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

                    userFromDb.Interests = interestsFromDb;

                    List<User> friendOfFromDb = new List<User>();
                    foreach (User friend in item.FriendOf)
                    {
                        User friendFromDb = dbContext.Users.Find(friend.Id);
                        if (friendFromDb != null)
                        {
                            friendOfFromDb.Add(friendFromDb);
                        }
                        else
                        {
                            friendOfFromDb.Add(friend);
                        }
                    }

                    userFromDb.FriendOf = friendOfFromDb;
                }
                
                dbContext.Users.Update(userFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
