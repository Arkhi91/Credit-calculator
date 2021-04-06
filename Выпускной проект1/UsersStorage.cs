using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Выпускной_проект1
{
    [DataContract]  //атрибут сериализации
    public class UsersStorage
    {
        [DataMember]
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            if (_users is null)
                _users = new List<User>();

            var findUser = FindUserByLogin(user.Login);

            if (findUser != null)
                throw new Exception("Пользователь с таким логином уже существует");

            _users.Add(user);
        }

        public void AddUser(string login, string password)
        {
            var user = User.CreateUser(login, password);
            AddUser(user);
        }

        public void RemoveUser(User user)
        {
            if (_users is null)
                return;

            _users.Remove(user);
        }

        public User FindUserByLogin(string login)
        {
            if(string.IsNullOrEmpty(login))
                throw new ArgumentException("Логин не может быть пустым");

            var user = _users.Where(u => u.Login == login).FirstOrDefault();

            return user;
        }

        public bool CheckPassword(string login, string password)
        {
            var user = FindUserByLogin(login);
            if (user is null)
                throw new ArgumentException("Пользователь с таким логином не найден");

            return user.Password == password;
        }
    }
}
