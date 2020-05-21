using System;

namespace Arena.Domain.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public bool Status { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }

        public User(string name, DateTime birthDate, string email, string password, string phone)
        {
            Name = name;
            Status = true;
            BirthDate = birthDate;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }
}
