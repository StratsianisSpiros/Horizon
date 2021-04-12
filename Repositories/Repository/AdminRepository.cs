using Entities.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class AdminRepository : IDisposable
    {
        private ApplicationDbContext _context;
        private UserManager<AdminUser, string> _userManager;
        private UserStore<AdminUser> _userStore;
        private bool _disposedValue;

        public AdminRepository()
        {
            _context = ApplicationDbContext.Create();
            _userStore = new UserStore<AdminUser>(_context);
            _userManager = new UserManager<AdminUser, string>(_userStore);
        }

        /// <summary>
        /// Returns the <see cref="Company"/> name of an administrator user given the <seealso cref="IdentityUser"/> id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><see cref="string"/> CompanyName</returns>
        public string GetCompanyName(string userId) => _userManager.Users.FirstOrDefault(u => u.Id == userId).CompanyName;

        /// <summary>
        /// Returns the <see cref="Company"/> ID of an administrator user given the <seealso cref="IdentityUser"/> id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><see cref="int"/> CompanyId</returns>
        public int GetCompanyId(string userId) => _userManager.Users.FirstOrDefault(u => u.Id == userId).CompanyId;

        /// <summary>
        /// Returns <seealso langword="async"/> subscription status for an administrator user given the <seealso cref="IdentityUser"/> username
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="string"/> subscriptionStatus</returns>
        public async Task<string> GetUserStatusAsync(string username) => await _userManager.Users.Where(u => u.UserName == username).Select(u => u.SubsciptionStatus).FirstOrDefaultAsync();

        /// <summary>
        /// Returns <seealso langword="async"/> an administrator user given the <seealso cref="IdentityUser"/> username 
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="AdminUser"/></returns>
        public async Task<AdminUser> GetUserAsync(string username) => 
                                await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == username) ?? new AdminUser();

        /// <summary>
        /// Updates <seealso langword="async"/> an administration user given the <seealso cref="AdminUser"/>
        /// </summary>
        /// <param name="user"></param>
        /// <returns><see cref="IdentityResult"/></returns>
        public async Task<IdentityResult> UpdateUserAsync(AdminUser user) => await _userManager.UpdateAsync(user);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                    _userManager.Dispose();
                    _userStore.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
