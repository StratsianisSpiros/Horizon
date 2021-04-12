using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CompanyRepository
    {
        private ApplicationDbContext _context;
        private bool _disposedValue;

        public CompanyRepository()
        {
            _context = ApplicationDbContext.Create();
        }

        /// <summary>
        /// Returns a <see cref="Company"/> given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns><see cref="Company"/></returns>
        public Company GetCompany(int companyId) => _context.Companies.FirstOrDefault(c => c.CompanyId == companyId) ?? new Company();

        /// <summary>
        /// Returns <seealso langword="async"/> a <see cref="Company"/> object with the included Posts given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns><see cref="Company"/></returns>
        public async Task<Company> GetCompanyWithPostsAsync(int companyId) =>
                            await _context.Companies.Include(c => c.Posts).FirstOrDefaultAsync(c => c.CompanyId == companyId) ?? new Company();

        /// <summary>
        /// Returns <seealso langword="async"/> a company's <see cref="Post"/> object given the post id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns><see cref="Post"/></returns>
        public async Task<Post> GetCompanyPostAsync(int postId) =>
                            await _context.Posts.FirstOrDefaultAsync(p => p.PostId == postId);

        /// <summary>
        /// Returns <see langword="async"/> a company's List of <see cref="Post"/> objects
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A List&lt;<see cref="Post"/>&gt;</returns>
        public async Task<List<EmployeeEvent>> GetCompanyEventsAsync(int companyId)=>
                            await _context.Events.Where(c => c.CompanyID == companyId).ToListAsync();

        /// <summary>
        /// Creates and returns <see langword="async"/> a <see cref="Company"/> object given the company name
        /// </summary>
        /// <param name="name"></param>
        /// <returns><see cref="Company"/></returns>
        public async Task<Company> CreateCompanyAsync(string name)
        {
            Company company = new Company { CompanyName = name };
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        /// <summary>
        /// Updates <see langword="async"/> a <see cref="Company"/> object given the company
        /// </summary>
        /// <param name="company"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> UpdateCompanyAsync(Company company)
        {
            _context.Companies.AddOrUpdate(company);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Creates <see langword="async"/> a company <see cref="Post"/> given the post and company id
        /// </summary>
        /// <param name="post"></param>
        /// <param name="companyId"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> CreateCompanyPostAsync(Post post, int companyId)
        {
            var company = await GetCompanyWithPostsAsync(companyId);
            company.Posts.Add(post);
            _context.Companies.AddOrUpdate(company);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Updates <see langword="async"/> a company <see cref="Post"/> given the post
        /// </summary>
        /// <param name="post"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> UpdateCompanyPostAsync(Post post)
        {
            //var p = await GetCompanyPostAsync(post.PostId);
            _context.Posts.AddOrUpdate(post);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Deletes <see langword="async"/> a company <see cref="Post"/> given the post id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteCompanyPostAsync(int postId)
        {
            var post = await GetCompanyPostAsync(postId);
            _context.Posts.Remove(post);
            return await _context.SaveChangesAsync() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
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
