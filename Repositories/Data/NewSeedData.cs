using Entities.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Strategy.PaymentStrategy;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;

namespace Repositories.Data
{
    public static class NewSeedData
    {
        /// <summary>
        /// Method to call on configuration.cs to seed data
        /// </summary>
        /// <param name="context"></param>
        public static void SeedContext(this ApplicationDbContext context)
        {
            var adminStore = new UserStore<AdminUser>(context);
            var adminManager = new UserManager<AdminUser>(adminStore);
            var employeeStore = new UserStore<EmployeeUser>(context);
            var employeeManager = new UserManager<EmployeeUser>(employeeStore);

            List<IdentityRole> roles = IdentityRoleData.GetData();
            Dictionary<AdminUser, string> adminUsers = AdminUserData.GetData();
            List<EmployeeUser> employeeUsers = EmployeeUserData.GetData();
            List<Company> companies = CompanyData.GetData();

            List<EmployeeEvent> employeeEvents = new List<EmployeeEvent>();
            employeeEvents.AddRange(Employee1EventData.GetData());
            employeeEvents.AddRange(Employee2EventData.GetData());
            employeeEvents.AddRange(Employee3EventData.GetData());
            employeeEvents.AddRange(Employee4EventData.GetData());
            employeeEvents.AddRange(Employee5EventData.GetData());

            List<Post> posts = PostData.GetData();
            List<Request> employeeRequests = RequestData.GetData();

            context.Roles.AddOrUpdate(roles.ToArray());

            foreach (var user in adminUsers)
            {
                adminManager.Create(user.Key, user.Value);
                user.Key.Roles.Add(new IdentityUserRole { RoleId = "1", UserId = user.Key.Id });
            }

            foreach (EmployeeUser user in employeeUsers)
            {
                employeeManager.Create(user, user.UserName);
                user.Roles.Add(new IdentityUserRole { RoleId = "2", UserId = user.Id });
            }

            foreach (Company company in companies)
            {
                company.Events = employeeEvents.Where(e => e.CompanyID == company.CompanyId).ToList();
                company.Posts = posts.Where(c => c.CompanyId == company.CompanyId).ToList();
            }

            foreach (EmployeeUser user in employeeUsers)
            {
                var events = employeeEvents.Where(e => e.Username == user.UserName).ToList();
                var requests = employeeRequests.Where(r => r.Username == user.UserName).ToList();
                user.EmployeeEvent = events;
                user.Requests = requests;
                user.Payments = new List<Payment>();
                var months2020 = events.Where(e => e.Start.Value.Year == 2020).Select(e => e.Start.Value.Month).Distinct();
                var months2021 = events.Where(e => e.Start.Value.Year == 2021).Select(e => e.Start.Value.Month).Distinct();
                PaymentStrategy strategy = new PaymentStrategy();
                strategy.SetPaymentStrategy(user.PayMethod);

                foreach (var month in months2020)
                {
                    Payment payment = new Payment();
                    payment = strategy.MakePayment(user, month, 2020);
                    user.Payments.Add(payment);
                    context.Payments.AddOrUpdate(payment);
                }

                foreach (var month in months2021)
                {
                    Payment payment = new Payment();
                    payment = strategy.MakePayment(user, month, 2021);
                    user.Payments.Add(payment);
                    context.Payments.AddOrUpdate(payment);
                }
            }

            context.Posts.AddOrUpdate(posts.ToArray());
            context.Events.AddOrUpdate(employeeEvents.ToArray());
            context.Requests.AddOrUpdate(employeeRequests.ToArray());
            context.Companies.AddOrUpdate(companies.ToArray());

            try
            {
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

    }
}
