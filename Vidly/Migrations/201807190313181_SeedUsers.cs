namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd397a766-09a3-4c18-80ab-25962f1ac629', N'guest@vidly.com', 0, N'AGFEHH2D9iS0OBmTvuF6dCYfHvciAKHRuG+vs9S9WNIy40OCf2PnbEf314iuEB5JBA==', N'6111c3fc-b5b4-4a88-846b-0fdfdd073b7d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd6f11248-a6f3-4db7-86af-f4888bbebe6c', N'admin@vidly.com', 0, N'ANcwaXP2JjB9kGquTjzcAG7O0gFtO8yCsJLEY+LoZPh4QE8bQ+DVhkc8eBvcb2xnbw==', N'255e4110-8b07-47ad-9729-7df3994656d5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1d5d34e5-0f12-401e-9dfc-ded96ca96c29', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd6f11248-a6f3-4db7-86af-f4888bbebe6c', N'1d5d34e5-0f12-401e-9dfc-ded96ca96c29')


");
        }
        
        public override void Down()
        {
        }
    }
}
