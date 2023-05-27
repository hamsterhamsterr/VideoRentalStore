using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public ApplicationUser Employee { get; set; }
        public IdentityRole Role { get; set; }
    }
}