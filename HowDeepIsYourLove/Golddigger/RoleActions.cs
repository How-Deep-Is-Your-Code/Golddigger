﻿namespace Golddigger
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Golddigger.Data;
    using Models;
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            // Access the application context and create result variables.
            GolddiggerDbContext context = new GolddiggerDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "admin" role if it doesn't already exist.
            if (!roleMgr.RoleExists("admin"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "admin" });
            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            var userMgr = new UserManager<User>(new UserStore<User>(context));
            var appUser = new User
            {
                UserName = "admin",
                Email = "admin@golddigger.com",
                IsFemale = true,
                ProfilePhoto = new byte[8]
            };
            
            IdUserResult = userMgr.Create(appUser, "Pa$$word1");

            // If the new "admin" user was successfully created, 
            // add the "admin" user to the "admin" role. 
            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@golddigger.com").Id, "admin"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@golddigger.com").Id, "admin");
            }
        }
    }
}