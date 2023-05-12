using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

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

        }
    }
}
