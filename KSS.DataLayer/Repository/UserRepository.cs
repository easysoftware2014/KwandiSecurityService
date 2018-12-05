using System.Collections.Generic;
using System.Linq;
using KSS.DataLayer.Entities;

namespace KSS.DataLayer.Repository
{
    public class UserRepository
    {
        private readonly KSSDBContext _kssdbContext;

        public UserRepository()
        {
            _kssdbContext = new KSSDBContext(); 
        }

        public List<User> GetAllUsers()
        {
            return _kssdbContext.Users.ToList();
        }
        public int AddUser(User user)
        {
            _kssdbContext.Users.Add(user);

            return _kssdbContext.SaveChanges();
        }
    }
}