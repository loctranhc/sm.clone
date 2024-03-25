using Domains.Entities;

namespace Abstractions.Applications.Repositories
{
    public interface IAccountRepository
    {
        Task<User> SignInByEmailAsync(string email, string password);
        Task<User> SignInByPhoneAsync(string phone, string password);
        Task<User> SignUpAsync(User user);
    }
}