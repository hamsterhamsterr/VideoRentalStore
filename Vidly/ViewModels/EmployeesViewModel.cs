using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class EmployeesViewModel
    {
        public Dictionary<ApplicationUser, string> UserRole;

        public EmployeesViewModel(IEnumerable<ApplicationUser> users,
            IEnumerable<IdentityRole> roles)
        {
            ApplicationUsers = users;
            ApplicationRoles = roles;

            UserRole = new Dictionary<ApplicationUser, string>();

            foreach (var user in ApplicationUsers)
            {
                UserRole.Add(user, ApplicationRoles.Single(ar => ar.Id == user.Roles.First().RoleId).Name);
            }
        }

        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }

        public IEnumerable<IdentityRole> ApplicationRoles { get; set; }
    }
}