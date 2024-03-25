using Abstractions.Applications.Repositories;
using Domains.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructures.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Task<User> SignInByEmailAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> SignInByPhoneAsync(string phone, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> SignUpAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}