using BlogAppDevelopment.Areas.Admin.Models;
using BlogAppDevelopment.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogAppDevelopment.Infrastructure
{
    public static class DbSetExtensions
    {
        public static AppUser UserExists( this DbSet<AppUser> appUsers, LoginModel loginModel)
        {
            return appUsers.Where(x => x.Email == loginModel.Email && x.Password.Equals(loginModel.Password)).SingleOrDefault();
        }
    }
}