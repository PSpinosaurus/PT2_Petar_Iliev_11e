using DataLayer;
using System;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        public static Test2DbContext dbContext;
        public static UsersContext usersContext;
        public static InterestsContext interestsContext;
        public static CategoriesContext categoriesContext;
        public static Test2DbContext GetDbContext()
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            dbContext = new Test2DbContext();
        }

        public static UsersContext GetUsersContext()
        {
            if (usersContext == null)
            {
                SetUsersContext();
            }
            return usersContext;
        }

        public static void SetUsersContext()
        {
            usersContext = new UsersContext(GetDbContext());
        }

        public static InterestsContext GetInterestsContext()
        {
            if (interestsContext == null)
            {
                SetInterestsContext();
            }
            return interestsContext;
        }

        public static void SetInterestsContext()
        {
            interestsContext = new InterestsContext(GetDbContext());
        }

        public static CategoriesContext GetCategoryContext()
        {
            if (categoriesContext == null)
            {
                SetCategoryContext();
            }
            return categoriesContext;
        }

        public static void SetCategoryContext()
        {
            categoriesContext = new CategoriesContext(GetDbContext());
        }
    }
}
