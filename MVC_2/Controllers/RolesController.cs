
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.Models;
using MVC_2.ViewModels;


namespace MVC_2.Controllers
{

    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        readonly ApplicationDBContext _dbContext;
        readonly RoleManager<IdentityRole> role_Manager;
        readonly UserManager<ApplicationUser> user_Manager;
        RolesViewModel rolesModel = new RolesViewModel();
        UsersRolesViewModel usersModel = new UsersRolesViewModel();


        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            role_Manager = roleManager;
            user_Manager = userManager;
        }


        // GET: 
        public IActionResult Index()
        {
            rolesModel.Title = "Index";
            rolesModel.Description = "List of Roles";
            rolesModel.IdentityRoles = role_Manager.Roles;

            return View(rolesModel);
        }


        public IActionResult Create()
        {
            //rolesModel.Title = "Create";
           // rolesModel.Description = "Create a new role";
            
            
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(RolesViewModel rvm)
        {
            //model.Title = "Create";
            // model.Description = "Create a new role";
   
            if (rvm.IdentityRole != null)
            {
                /*check if role name exists in the list of roles*/
                if (await role_Manager.RoleExistsAsync(rvm.IdentityRole.Name))
                {
                    return RedirectToAction("Index");
                }

                await role_Manager.CreateAsync(rvm.IdentityRole);
            }

            return RedirectToAction("Index");
        }




        public async Task<IActionResult> Delete(string roleid)
        {

      
            IdentityRole role = await role_Manager.FindByIdAsync(roleid);
            await role_Manager.DeleteAsync(role);
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Edit(string roleid)
        {
            rolesModel.Title = "Edit";
            rolesModel.Description = "Edit role";

            rolesModel.IdentityRole = await role_Manager.FindByIdAsync(roleid);

            return View(rolesModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(RolesViewModel roleToEdit)
        {
            IdentityRole role = await role_Manager.FindByIdAsync(roleToEdit.IdentityRole.Id);
            
            if (role != null)
            {
                /*check if role name exists in the list of roles*/
                if (await role_Manager.RoleExistsAsync(roleToEdit.IdentityRole.Name))
                {
                    return RedirectToAction("Index");
                }
                role.Name = roleToEdit.IdentityRole.Name;
                //role.NormalizedName = roleToEdit.IdentityRole.Name.ToUpper();
                await role_Manager.UpdateAsync(role);
            }

            return RedirectToAction("Index");

        }



        public IActionResult Users()
        {
            usersModel.Title = "Users";
            usersModel.ApplicationUsers = user_Manager.Users;

            return View(usersModel);
        }



        public async Task<IActionResult> UserRoles(string userID)
        {

            ApplicationUser user = await user_Manager.FindByIdAsync(userID);
            usersModel.ApplicationUser = user;
            usersModel.UserRoles = new List<string>(await user_Manager.GetRolesAsync(user));
            usersModel.IdentityRoles = role_Manager.Roles;


            return View(usersModel);
        }


        public async Task<IActionResult> RemoveRole(string rolename, string userid)
        {
            ApplicationUser user = await user_Manager.FindByIdAsync(userid);
            await user_Manager.RemoveFromRoleAsync(user, rolename);

            return RedirectToAction("UserRoles", new { userID = userid });
        }



        public async Task<IActionResult> AddRole(string rolename, string userid)
        {
            ApplicationUser user = await user_Manager.FindByIdAsync(userid);

            if(user != null)
            {
                if (await user_Manager.IsInRoleAsync(user, rolename))
                {
                    return RedirectToAction("UserRoles", new { userID = userid });
                }

                await user_Manager.AddToRoleAsync(user, rolename);
            }
            
       
            return RedirectToAction("UserRoles", new { userID = userid });
        }


        public async Task<IActionResult> DeleteUser(string userid)
        {
            ApplicationUser user = await user_Manager.FindByIdAsync(userid);

            if(user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Users");
        }




    }
}


