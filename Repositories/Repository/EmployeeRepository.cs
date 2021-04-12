using Entities.Models;
using Entities.UtilityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class EmployeeRepository : IDisposable
    {
        private ApplicationDbContext _context;
        private UserManager<EmployeeUser, string> _userManager;
        private UserStore<EmployeeUser> _userStore;
        private bool _disposedValue;

        public EmployeeRepository()
        {
            _context = ApplicationDbContext.Create();
            _userStore = new UserStore<EmployeeUser>(_context);
            _userManager = new UserManager<EmployeeUser, string>(_userStore);
        }

        /// <summary>
        /// Returns the <see cref="Company"/> name of an employee user given the <seealso cref="IdentityUser"/> id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><see cref="string"/> CompanyName</returns>
        public string GetCompany(string userId) => _userManager.Users.FirstOrDefault(u => u.Id == userId).CompanyName;

        /// <summary>
        /// Returns the <see cref="Company"/> ID of an administrator user given the <seealso cref="IdentityUser"/> id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns><see cref="int"/> CompanyId</returns>
        public int GetCompanyId(string userId) => _userManager.Users.FirstOrDefault(u => u.Id == userId).CompanyId;

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user given the <seealso cref="IdentityUser"/> username 
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetEmployeeAsync(string username) => 
                                await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == username) ?? new EmployeeUser();

        /// <summary>
        /// Returns <see langword="async"/> a List of <see cref="EmployeeUser"/> objects given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A List&lt;<see cref="EmployeeUser"/>&gt;</returns>
        public async Task<ICollection<EmployeeUser>> GetEmployeesAsync(int companyId) =>
                                await _userManager.Users.Where(u => u.CompanyId == companyId).ToListAsync() ?? new List<EmployeeUser>();

        /// <summary>
        /// Returns <see langword="async"/> a List of <see cref="EmployeeUser"/> including <see cref="EmployeeEvent"/> objects given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A List&lt;<see cref="EmployeeUser"/>&gt;</returns>
        public async Task<ICollection<EmployeeUser>> GetEmployeesWithEventsAsync(int companyId) => 
                                await _userManager.Users.Where(u => u.CompanyId == companyId).Include(u => u.EmployeeEvent).ToListAsync();

        /// <summary>
        /// Returns <see langword="async"/> a List of <see cref="EmployeeUser"/> including <see cref="Payment"/> objects given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A List&lt;<see cref="EmployeeUser"/>&gt;</returns>
        public async Task<ICollection<EmployeeUser>> GetEmployeesWithPaymentsAsync(int companyId) =>
                                await _userManager.Users.Where(u => u.CompanyId == companyId).Include(u => u.Payments).ToListAsync();

        /// <summary>
        /// Returns <see langword="async"/> a List of <see cref="EmployeeUser"/> including <see cref="Request"/> objects given the company id
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns>A List&lt;<see cref="EmployeeUser"/>&gt;</returns>
        public async Task<ICollection<EmployeeUser>> GetEmployeesWithRequestsAsync(int companyId) =>
                                await _userManager.Users.Where(u => u.CompanyId == companyId).Include(u => u.Requests).ToListAsync();

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user including <see cref="EmployeeEvent"/> objects given the company id 
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetEmployeeWithEventsAsync(string username) => 
                                await _userManager.Users.Include(e => e.EmployeeEvent).FirstOrDefaultAsync(u => u.UserName == username);

        /// <summary>
        /// Returns <seealso langword="async"/> an employee <see cref="EmployeeEvent"/> from database given the event id 
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns><see cref="EmployeeEvent"/></returns>
        public async Task<EmployeeEvent> GetEmployeeEventAsync(int eventId) =>
                                await _context.Events.FirstOrDefaultAsync(e => e.EventID == eventId);

        /// <summary>
        /// Returns <seealso langword="async"/> employee <see cref="EmployeeEvent"/> from database given employee username and desired month and day
        /// </summary>
        /// <param name="username"></param>
        /// <param name="month"></param>
        /// <returns><see cref="EmployeeEvent"/></returns>
        public async Task<EmployeeEvent> GetEmployeeEventByDayAsync(string username, int day, int month) =>
                                await _context.Events.Where(e => e.Start.Value.Day == day && e.Start.Value.Month == month && e.Username == username).FirstOrDefaultAsync() ?? new EmployeeEvent() { Status = WorkStatus.Other};

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user including <see cref="Payment"/> objects given the employee username
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetEmployeeWithPaymentsAsync(string username) =>
                                await _userManager.Users.Include(p => p.Payments).FirstOrDefaultAsync(u => u.UserName == username);

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user from database including <see cref="Payment"/> and its <see cref="EmployeeEvent"/> objects given employee username
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetEmployeePaymentEventsAsync(string username) =>
                                await _userManager.Users.Include(p => p.Payments).Include(e => e.EmployeeEvent).FirstOrDefaultAsync(u => u.UserName == username);

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user from database including <see cref="Payment"/>, <see cref="Request"/> and its <see cref="EmployeeEvent"/> objects given employee username
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetFullEmployeeAsync(string username) =>
                               await _userManager.Users.Include(p => p.Payments).Include(e => e.EmployeeEvent).Include(r => r.Requests).FirstOrDefaultAsync(u => u.UserName == username);

        /// <summary>
        /// Returns <seealso langword="async"/> an employee user including <see cref="Request"/> objects given the employee username
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="EmployeeUser"/></returns>
        public async Task<EmployeeUser> GetEmployeeWithRequestsAsync(string username) =>
           await _userManager.Users.Include(r => r.Requests).FirstOrDefaultAsync(u => u.UserName == username);

        /// <summary>
        /// Creates <see langword="async"/> a <see cref="Request"/> given the event and returns a result
        /// </summary>
        /// <param name="request"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> CreateEmployeeRequestAsync(Request request)
        {
            var user = await GetEmployeeWithRequestsAsync(request.Username);
            user.Requests.Add(request);
            _context.Users.AddOrUpdate(user);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Create <see langword="async"/> a <see cref="Request"/> response given the event and returns a result
        /// </summary>
        /// <param name="request"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> CreateEmployeeResponseRequestAsync(Request request)
        {
            var user = await GetEmployeeWithRequestsAsync(request.Username);
            var req = user.Requests.FirstOrDefault(a => a.RequestId == request.RequestId);
            req.Response = request.Response;
            req.AskRequest = request.AskRequest;
            _context.Users.AddOrUpdate(user);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Updates <seealso langword="async"/> an <see cref="EmployeeUser"/> given the user and returns a result
        /// </summary>
        /// <param name="user"></param>
        /// <returns><see cref="IdentityResult"/></returns>
        public async Task<IdentityResult> UpdateEmployeeAsync(EmployeeUser user) => await _userManager.UpdateAsync(user);

        /// <summary>
        /// Updates <see langword="async"/> the company name of an <see cref="EmployeeUser"/> given the <see cref="Company"/> and employee username
        /// </summary>
        /// <param name="company"></param>
        /// <param name="username"></param>
        /// <returns><see cref="IdentityResult"/></returns>
        public async Task<IdentityResult> UpdateEmployeeCompanyAsync(Company company, string username)
        {
            var user = await GetEmployeeAsync(username);
            user.CompanyId = company.CompanyId;
            user.CompanyName = company.CompanyName;
            return await _userManager.UpdateAsync(user);
        }

        /// <summary>
        /// Creates or updates <see langword="async"/> an <see cref="EmployeeEvent"/> given the event and returns a result
        /// </summary>
        /// <param name="employeeEvent"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> CreateEmployeeEventAsync(EmployeeEvent employeeEvent)
        {
            var user = await GetEmployeeWithEventsAsync(employeeEvent.Username);
            var eve = user.EmployeeEvent.FirstOrDefault(e => e.EventID == employeeEvent.EventID);
       
            if (eve == null)
            {
                eve = new EmployeeEvent();
                eve = employeeEvent;
                user.EmployeeEvent.Add(eve);
                _context.Events.AddOrUpdate(eve);
                return await _context.SaveChangesAsync() > 0;
            }
            else
            {
                eve = employeeEvent;
                _context.Events.AddOrUpdate(eve);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Deletes <see langword="async"/> an <see cref="EmployeeEvent"/> given the event id
        /// and returns a result
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> DeleteEmployeeEventAsync(int eventId)
        {
            var eve = await GetEmployeeEventAsync(eventId);
            _context.Events.Remove(eve);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Creates or Updates <see langword="async"/> an employee <see cref="Payment"/> given the employee username and payment object
        /// and returns a result
        /// </summary>
        /// <param name="username"></param>
        /// <param name="payment"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> CreateUpdateEmployeePaymentAsyc(string username, Payment payment)
        {
            var user = await GetEmployeeWithPaymentsAsync(username);
            var pay = user.Payments.FirstOrDefault(p => p.PaymentId == payment.PaymentId);
             
            if (pay == null)
            {
                pay = new Payment() { PayDate = DateTime.Now, Username = username };
                pay = payment;
                user.Payments.Add(pay);
                _context.Payments.AddOrUpdate(pay);
                return await _context.SaveChangesAsync() > 0;
            }
            else
            {
                pay = payment;
                _context.Payments.AddOrUpdate(pay);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Deletes <see langword="async"/> an <see cref="EmployeeUser"/> given the username and returns a result
        /// </summary>
        /// <param name="username"></param>
        /// <returns><see cref="bool"/> succeeded</returns>
        public async Task<bool> DeleteEmployeeAsync(string username)
        {
            var user = await GetFullEmployeeAsync(username);
            var payments = user.Payments.ToList();
            var events = user.EmployeeEvent.ToList();
            var requests = user.Requests.ToList();

            _context.Users.Remove(user);

            foreach (var payment in payments)
            {
                _context.Payments.Remove(payment);
            }

            foreach (var eve in events)
            {
                _context.Events.Remove(eve);
            }

            foreach (var request in requests)
            {
                _context.Requests.Remove(request);
            }

            return await _context.SaveChangesAsync() > 0;
        }
        
        /// <summary>
        /// Updates <see langword="async"/> the <see cref="Company"/> model for all <see cref="EmployeeUser"/> users given the company and company id and returns an Identity result
        /// </summary>
        /// <param name="company"></param>
        /// <param name="companyId"></param>
        /// <returns><see cref="IdentityResult"/></returns>
        public async Task<IdentityResult> UpdateAllEmployeesCompanyAsync(Company company, int companyId)
        {
            IdentityResult result = new IdentityResult();
            var employees = await GetEmployeesAsync(companyId);
            
            foreach (var employee in employees)
            {
                result = await UpdateEmployeeCompanyAsync(company, employee.UserName);
            }

            return result;
        }

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
