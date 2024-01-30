using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Seguridad.Identity.Models;
using System.Security.Claims;

namespace Seguridad.Identity.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {

        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public AuthController(SignInManager<Usuario> signInManager, UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;


        }


       private  async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] roleNames = { "Administrator", "Manager", "User" };
            foreach (var roleName in roleNames)
            {
                bool roleExists = await roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = roleName;
                    await roleManager.CreateAsync(role);
                }
            }
        }


        public async    Task<IActionResult> Index()
        {
          //  await  CreateRoles(this._roleManager);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Desloguear = "desloguearse";
            }
            return View();
        }


        [AllowAnonymous]
        public IActionResult Registro()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public  async Task<IActionResult> Registro(RegisterViewModel registerViewModel)
        {

            if(ModelState.IsValid)
            {
                 var user = new Usuario();
                user.UserName = registerViewModel.Username;
                user.LastName = registerViewModel.UserHandle;

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                var addedUser = await _userManager.FindByNameAsync(registerViewModel.Username);
                await _userManager.AddToRoleAsync(addedUser, "Administrator");
                await _userManager.AddToRoleAsync(addedUser, "User");

                var resultlogin = await _signInManager.PasswordSignInAsync(registerViewModel.Username, registerViewModel.Password, true, false);
                if (resultlogin.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }
                    else
                    {
                        return RedirectToAction("Index","Admin");
                    }
                }



                if (result.Succeeded)
                { 
                    return RedirectToAction("Index");
                }

            }



            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult desloguearse()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username,model.Password, true, false);


                if (result.Succeeded)
                {

                    Claim claim = new Claim(ClaimTypes.Email, model.Username);

                    var addedUser = await _userManager.FindByNameAsync(model.Username);
                    /*await _userManager.AddClaimAsync(addedUser, claim);      */

                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    } else
                    {
                        return RedirectToAction("Index");
                    }
                }
            }




            return View();
        }
    }
}
