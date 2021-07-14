namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'21d32864-ee00-48ea-8bbb-3aa381b75874', N'admin@vidly.com', 0, N'AMxHGQq5EF70LwNQELkX50aIVBc/iv4lqtLrDThpg5A9ADzkL+jIOqkI/XA9OSUyTg==', N'7047fd90-0a2a-4b07-9cee-c9c3fb11999e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7713efc0-572e-402c-8aa5-3adcee37edf1', N'guest@vidly.com', 0, N'AGXr7ACLLhcdgeapndvInL5SwYXv+ILPQwmAhHdmpGWbP2gdvobx7GoUV11xY9PqmA==', N'b18c7bd1-1a33-474c-b8c7-1d3f86cf68c7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cc31c586-fe60-4702-b9b5-fe61096da5f4', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'21d32864-ee00-48ea-8bbb-3aa381b75874', N'cc31c586-fe60-4702-b9b5-fe61096da5f4')
            ");
        }

        public override void Down()
        {
        }
    }
}
