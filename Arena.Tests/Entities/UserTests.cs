using Arena.Domain.Commands;
using Arena.Domain.Entities;
using Arena.Domain.Repositories;
using Arena.Domain.Services;
using Arena.Infra.Repositories;
using Arena.Infra.Services;
using Arena.Shared.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arena.Tests.Entities
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldCreateANewUser()
        {
            User user = new User("Name", DateTime.Now.AddYears(-20), "test@test.com", "pass", "999999999");

            Assert.AreNotEqual(null, user);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldSaveAnUser()
        {
            IUserRepository repository = new UserRepository();
            IEmailService emailService = new EmailService();
            User user = new User("Name", DateTime.Now.AddYears(-20), "test@test.com", "pass", "999999999");

            ICommand<User> command = new CreateUserCommand(repository, emailService);

            Assert.AreEqual(true, command.Execute(user));
        }
    }
}
