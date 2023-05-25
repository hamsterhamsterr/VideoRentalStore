namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersandRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'2ca8cff4-3246-424c-845d-b0949606fdeb', N'employee3@vidly.com', 0, N'ACksH0XivVHG1m4EH93rgDbkUJzN86WvcvKz5vEPRGoorSxYZ/qKiUCX1aY4a554uQ==', N'648433ef-f09a-4659-8315-f8edbede0035', N'55-5-555', 0, 0, NULL, 1, 0, N'employee3@vidly.com', N'555555', N'FirstName_E3', N'LastName_E3')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'4516987e-50ab-4a03-8e95-fe23d602fdcf', N'manager1@vidly.com', 0, N'ADSrXA1URjHHJZZ/Px4MgFN0CC3fF4SjbszfnYyYLhJGvzAs6yek5/wGu7ufJNpVyw==', N'848545a8-b2b0-487f-a00d-68b44dbabfee', N'11-1-111', 0, 0, NULL, 1, 0, N'manager1@vidly.com', N'111111', N'FirstName_M1', N'LastName_M1')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'4c66751f-3db1-4fc3-a6af-f7480c74f937', N'employee4@vidly.com', 0, N'ALKmKz3BnFOZWfcsMGqB1KXF3gEMQZh4bWgiZSJI7yrl+k7UKgkzN2q+XfLYmDgabA==', N'37b98ba3-e767-4e84-a7d7-6a4d5acc978c', N'77-7-777', 0, 0, NULL, 1, 0, N'employee4@vidly.com', N'777777', N'FirstName_E4', N'LastName_E4')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'6dada7a7-1068-41db-af07-d2a9c0d35b0a', N'employee5@vidly.com', 0, N'AJ4YMp4rxG0xXAvQBT6lgobGRxOpI1nsiTUYYB98XQpk5D+wRPBeIjmQOwlftB+wJw==', N'b207f1d0-f508-4f21-9a6c-c3c202ac16a0', N'88-8-888', 0, 0, NULL, 1, 0, N'employee5@vidly.com', N'888888', N'FirstName_E5', N'LastName_E5')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'9c431a52-1a86-46e1-a8a4-99b54d3ff2a6', N'employee1@vidly.com', 0, N'AGj5OOeHADmukAQNM3VNQK7HzHs0H72ItfwBNZ3DrOVPFsl8DKPUKoPc8qkJMjMxGg==', N'7fd9a0fd-7aa7-41b1-88ff-a5df3aa9dd74', N'33-3-333', 0, 0, NULL, 1, 0, N'employee1@vidly.com', N'333333', N'FirstName_E1', N'LastName_E1')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'c06cd1e1-8684-4451-bcf9-545093dcac21', N'manager2@vidly.com', 0, N'ACsOx9tQoH5l1kL/5K7olI7hqKrZNRyWID+6FLFRppbO7+Dt+rpT3OO4/11sg/kGEQ==', N'75a512a5-1302-464b-824f-23d9ce821ef6', N'22-2-222', 0, 0, NULL, 1, 0, N'manager2@vidly.com', N'222222', N'FirstName_M2', N'LastName_M2')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'e789219f-d2d2-43b7-a145-b4b2d793cf11', N'admin@vidly.com', 0, N'AHJbyaI3VrKsQV4sVknSR13CdFUiuIXskJ1XxbAxIJ/DkUfrzSRDPsHWO7Mi4IetQA==', N'16ce58e4-d587-4e3e-b8eb-27c85335116f', N'12-3-123', 0, 0, NULL, 1, 0, N'admin@vidly.com', N'123123', N'Admin', N'Admin')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [FirstName], [LastName]) VALUES (N'e9a6e0bf-0adf-4080-a95f-538d454b7bbd', N'employee2@vidly.com', 0, N'AN4VySUrBNPEwwHUHUfhHYL3r8j3c4qh/sPZNze5YeZ3rO7jBJHEmN7ym8g3yTVcYA==', N'270887b8-ce15-4659-8ad3-c931d787259d', N'44-4-444', 0, 0, NULL, 1, 0, N'employee2@vidly.com', N'444444', N'FirstName_E2', N'LastName_E2')
                  
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd530dba6-8b9f-4c62-ba23-f4cd19ca93e5', N'Admin')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6404d30a-7da9-4c3e-a6ea-4fea969afcba', N'Employee')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1602a9e6-5743-4018-a09e-2dab27009646', N'Manager')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4516987e-50ab-4a03-8e95-fe23d602fdcf', N'1602a9e6-5743-4018-a09e-2dab27009646')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c06cd1e1-8684-4451-bcf9-545093dcac21', N'1602a9e6-5743-4018-a09e-2dab27009646')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2ca8cff4-3246-424c-845d-b0949606fdeb', N'6404d30a-7da9-4c3e-a6ea-4fea969afcba')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4c66751f-3db1-4fc3-a6af-f7480c74f937', N'6404d30a-7da9-4c3e-a6ea-4fea969afcba')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6dada7a7-1068-41db-af07-d2a9c0d35b0a', N'6404d30a-7da9-4c3e-a6ea-4fea969afcba')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c431a52-1a86-46e1-a8a4-99b54d3ff2a6', N'6404d30a-7da9-4c3e-a6ea-4fea969afcba')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9a6e0bf-0adf-4080-a95f-538d454b7bbd', N'6404d30a-7da9-4c3e-a6ea-4fea969afcba')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e789219f-d2d2-43b7-a145-b4b2d793cf11', N'd530dba6-8b9f-4c62-ba23-f4cd19ca93e5')
                 ");
        }
        
        public override void Down()
        {
        }
    }
}
