using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace TestingLayer
{
    [TestFixture]
    internal class UserContextTest
    {
        private UsersContext context = new UsersContext(SetupFixure.dbContext);
        private User user;
        private User friend1, friend2;
        private Interest interest1, interest2;

        [SetUp]
        public void CreateUser()
        {
            user = new User("Kaloqn", "Zlatarev", 18, "Koki", "123456789", "kiko123@gmail.com");

            friend1 = new User("Daninko", "Name", 20, "Hmm", "1234", "123@gmail.com");
            friend2 = new User("Proton", "Protonov", 20, "Hmm", "1234", "123@gmail.com");

            interest1 = new Interest("Reading");
            interest2 = new Interest("Gaming");

            user.Friends.Add(friend1);
            user.Friends.Add(friend2);

            user.Interests.Add(interest1);
            user.Interests.Add(interest2);

            context.Create(user);
        }

        [TearDown]
        public void DropUsers()
        {
            foreach (User item in SetupFixure.dbContext.Users)
            {
                SetupFixure.dbContext.Users.Remove(item);
            }
            SetupFixure.dbContext.SaveChanges();
        }

        [Test]
        public void CreateTest()
        {
            int previousCount = SetupFixure.dbContext.Users.Count();

            User newUser = new User("New", "Who", 24, "Mhm", "123456789", "user@gmail.com");

            context.Create(newUser);

            int after = SetupFixure.dbContext.Users.Count();

            Assert.IsTrue(previousCount + 1 == after, "Create doesn't work!");
        }


        [Test]
        public void Delete()
        {
            int previousCount = SetupFixure.dbContext.Users.Count();

            context.Delete(user.Id);

            int after = SetupFixure.dbContext.Users.Count();

            Assert.IsTrue(previousCount - 1 == after, "Delete doesn't work!");
        }

        [Test]
        public void Read()
        {
            User read = context.Read(user.Id);

            Assert.AreEqual(user, read, "Read doesnt work.");
        }

        [Test]
        public void ReadNavigational()
        {
            User read = context.Read(user.Id, true);

            Assert.That(read.Friends.Contains(friend1) && read.Interests.Contains(interest1) , "Navigational properties dont work.");
        }

        [Test]
        public void ReadAll()
        {
            List<User> readUsers = (List<User>)context.ReadAll();

            Assert.That(readUsers.Count != 0, "ReadAll doesnt work.");
        }

        [Test]
        public void Update()
        {
            User readUser = context.Read(user.Id);
            readUser.UserName = "New username";
            context.Update(readUser);

            Assert.AreEqual(readUser, context.Read(user.Id), "Update doenst work!");
        }
    }
}
