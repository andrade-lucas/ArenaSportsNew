using Arena.Domain.Entities;
using Arena.Domain.Repositories;
using Arena.Domain.Services;
using Arena.Shared.Commands;

namespace Arena.Domain.Commands
{
    public class CreateUserCommand : ICommand<User>
    {
        private readonly IUserRepository _repository;
        private readonly IEmailService _emailService;

        public CreateUserCommand(IUserRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public bool Execute(User user)
        {
            bool result = _repository.Save(user);
            if (result)
                _emailService.Send(user.Email, "Seja bem-vindo", "Seja bem vindo ao nosso sistema, aproveite o nosso tour!");
            return result;
        }
    }
}
