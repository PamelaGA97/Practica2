using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager
    {
        public List<User> Users { get; set; }
        public UserManager()
        {
            Users = new List<User>()
            {
                new User() { Id = 1, Name = "Pablo"},
                new User() { Id = 2,Name = "Laura"},
            };
        }
        public List<User> GetUsers()
        {
            return Users;

        }

        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }

        public User DeleteUser(User user)
        {
            return null;
        }

        public User PutUser(User user)
        {
            return null;
        }
    }
}