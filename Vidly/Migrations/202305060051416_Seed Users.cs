namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3cdecf6d-71d2-45e7-945a-b04e091685de', N'guest@vidly.com', 0, N'AHjgBtzehsLDhBYEznfjYAQ1p+1eAbE00AaYN87u1lAhjg+Afq9hRzU/X7LeagGW8A==', N'472683f7-091b-48f3-a88b-222c943a7e6b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db27f166-ed4e-459e-8a4c-1eff19b42878', N'admin@vidly.com', 0, N'AA+mszCosUeHV1lJMlT6szPhBYrc0iJkubb4cIWhf5FyTm1VDIwwIjGsRKRXByX8MQ==', N'e3dbc0e1-7d9d-43a8-bdcc-e8df101ae049', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'08188a59-6034-4a95-9d94-ac68055d4ba8', N'CanManageMovies') 

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db27f166-ed4e-459e-8a4c-1eff19b42878', N'08188a59-6034-4a95-9d94-ac68055d4ba8')
               ");
        }
        
        public override void Down()
        {
        }
    }
}
