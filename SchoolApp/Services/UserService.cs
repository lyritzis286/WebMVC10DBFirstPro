using SchoolApp.Core;
using SchoolApp.Core.Filters;
using SchoolApp.DTO;
using SchoolApp.Models;

namespace SchoolApp.Services
{
    public class UserService : IUserService
    {
        public Task<PaginatedResult<UserReadOnlyDTO>> GetPaginatedUsersFilteredAsync(int pageNumber, int pageSize, UserFiltersDTO userFiltersDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserReadOnlyDTO?> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<User?> VerifyAndGetUserAsync(UserLoginDTO credentials)
        {
            throw new NotImplementedException();
        }
    }
}
