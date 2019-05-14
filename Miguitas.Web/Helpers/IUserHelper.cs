namespace Miguitas.Web.Helpers
{
    using System.Threading.Tasks;
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using Models;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByPhoneAsync(string phone);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);

        Task LogoutAsync();
    }
}
