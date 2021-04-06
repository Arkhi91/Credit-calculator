using System.Runtime.Serialization;
using System;

namespace Выпускной_проект1
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        public static User CreateUser(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
                throw new ArgumentException("Логин не может быть пустым");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Пароль не может быть пустым");

            return new User() { Login = login, Password = password };
        }
    }
}
