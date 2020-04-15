using System;

namespace DocumentStorage.Model.Classes
{
    public class User : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Конструктор по-умолчанию.
        /// </summary>
        public User() {}

        /// <summary>
        /// Конструктор ддя регистрации нового пользователя.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="registrationDate"></param>
        public User(string userName, string password, DateTime registrationDate)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            RegistrationDate = registrationDate;
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
