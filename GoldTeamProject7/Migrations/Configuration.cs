namespace GoldTeamProject7.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoldTeamProject7.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GoldTeamProject7.Models.ApplicationDbContext context)
        {
            {
                //context.Messages.AddorUpdate(x => x.Id,
                //   new messages() { ID = 5, Message = "It's a Metaphor Fool", DateSent = DateTime.Now, ProductID = "100", ApplicationUserID = "1" },
                //   new messages() { ID = 6, Message = "HTML RULEZ DOOD", DateSent = DateTime.Now, ProductID = "101", ApplicationUserID = "2" },
                //   new messages() { ID = 7, Message = "Wrecked'em, Damn Near Killed'em!", DateSent = DateTime.Now, ProductID = "102", ApplicationUserID = "3" },
                //   new messages() { ID = 8, Message = "Have Faith in Me", DateSent = DateTime.Now, ProductID = "103", ApplicationUserID = "4" },
                //   new messages() { ID = 9, Message = "Reinventing Your Exit", DateSent = DateTime.Now, ProductID = "104", ApplicationUserID = "5" },
                //   new messages() { ID = 10, Message = "Southern Weather", DateSent = DateTime.Now, ProductID = "105", ApplicationUserID = "6" }
                //    );

            }
        }
    }
}
