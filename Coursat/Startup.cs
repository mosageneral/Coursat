using System;
using Coursat.Models;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(Coursat.Startup))]
namespace Coursat
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
            CreateRole();
            CreateUsers();
            CreateUsers1();
            CreateUsers2();
            CreateUsers3();
        }

        public  void CreateUsers()
        {
            var usermanger = new UserManager<ApplicationUser >(new UserStore<ApplicationUser >(db));
            var user = new ApplicationUser();
            user.Email = "admin@courseaty.com";
            user.UserName = "admin@courseaty.com";
            user.UserType = "Admins";
            var check = usermanger.Create(user, "123456789Admin@");
            if (check.Succeeded )
            {
                usermanger.AddToRole(user.Id, "Admins");
            }
        }
        public void CreateUsers1()
        {
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "Mangers1@courseaty.com";
            user.UserName = "Mangers1@courseaty.com";
            user.UserType = "Mangers";
            var check = usermanger.Create(user, "123456789Mangers@");
            if (check.Succeeded)
            {
                usermanger.AddToRole(user.Id, "Mangers");
            }
        }
        public void CreateUsers2()
        {
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "Mangers2@courseaty.com";
            user.UserName = "Mangers2@courseaty.com";
            user.UserType = "Mangers";
            var check = usermanger.Create(user, "123456789Mangers@");
            if (check.Succeeded)
            {
                usermanger.AddToRole(user.Id, "Mangers");
            }
        }
        public void CreateUsers3()
        {
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "Mangers3@courseaty.com";
            user.UserName = "Mangers3@courseaty.com";
            user.UserType = "Mangers";
            var check = usermanger.Create(user, "123456789Mangers@");
            if (check.Succeeded)
            {
                usermanger.AddToRole(user.Id, "Mangers");
            }
        }

        public  void CreateRole()
        {
            var rolemanger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role;
            if (!rolemanger.RoleExists("Admins"))
            {
                role = new IdentityRole();
                role.Name = "Admins";
                rolemanger.Create(role);

            }
            if (!rolemanger.RoleExists("Mangers"))
            {
                role = new IdentityRole();
                role.Name = "Mangers";
                rolemanger.Create(role);

            }
            if (!rolemanger.RoleExists("assholes"))
            {
                role = new IdentityRole();
                role.Name = "assholes";
                rolemanger.Create(role);

            }
        }
    }
}
