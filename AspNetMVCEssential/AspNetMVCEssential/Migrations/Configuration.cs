using AspNetMVCEssential.Models;
using AspNetMVCEssential.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetMVCEssential.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMVCEssential.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AspNetMVCEssential.Models.ApplicationDbContext context)
        {
            //UserStoreһ��Ҫʹ��context��Ϊ����
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "liulixiang1988"))
            {
                //1�������û�
                var user = new ApplicationUser { UserName = "liulixiang1988", Email = "liulixiang1988@gmail.com" };
                //�������ᴴ��һ���û����һ�����ִ�У��������SaveChanges
                userManager.Create(user, "passW0rd");

                //2�������û���ص��˻�
                var service = new CheckingAccountService(context);
                service.CreateCheckingAccount("liulixiang1988", "����Ա", user.Id, 1000);

                //3����ӽ�ɫ������
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                context.SaveChanges();

                //4�����û���ӽ�ɫ
                userManager.AddToRole(user.Id, "Admin");

            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
