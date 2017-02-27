namespace app.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}