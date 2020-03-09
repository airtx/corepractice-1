using corepractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corepractice.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly Context context;

        public SQLUserRepository(Context context)
        {
            this.context = context;
        }

        public User Add(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int Id)
        {
            User user = context.User.Find(Id);
            if (user != null)
            {
                context.User.Remove(user);
                context.SaveChanges();
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.User;
        }
        
        public User GetUser(int Id)
        {
            return context.User.Find(Id);
        }

        public User Update(User userChanges)
        {
            var user = context.User.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
    }
}
