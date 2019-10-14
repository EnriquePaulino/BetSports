using BetSports.Web.Data.Entities;
using BetSports.Web.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BetSports.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByUserNameAsync(string userName);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
