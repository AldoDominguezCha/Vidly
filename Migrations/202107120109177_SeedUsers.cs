namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b6f8be93-e365-441d-9a6a-4881e67513de', N'guest@vidly.com', 0, N'AP20fVjjjfbdPBdOc0tVwrx5u3k2KbjUM1MgSFfGziQFw5h82YZErPZnHgWM5V1oMA==', N'23e06e75-ec54-4177-8257-28d26dad93b4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bbca53f4-27dd-4011-9cb1-cfeba4a9e628', N'admin@vidly.com', 0, N'AFqcMwy6hlonky/gq5q/a9NGF1YmkV0sbiHC3FJytiSov19+m9amNdFWs3ENT8OTzg==', N'bff6a0c3-dd76-453a-b907-761bef05bd03', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd85e90e5-34c1-4f8a-ac7f-c603dc098e2b', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bbca53f4-27dd-4011-9cb1-cfeba4a9e628', N'd85e90e5-34c1-4f8a-ac7f-c603dc098e2b')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
