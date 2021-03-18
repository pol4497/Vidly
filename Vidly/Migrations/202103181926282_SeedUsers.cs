namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'185cc574-503e-46e2-bb50-2880eb8c73e9', N'admin@vidly.com', 0, N'ACcCeShqZUGYhlk9xkQsra6wl38s2DKSSgyYQ0kS+zepWoLyYNscbAElSxgHGxNtuw==', N'38666813-32ab-48e5-889b-0c99ab2a60b7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c62b7034-88da-4b69-86f7-43c2058917d7', N'guest@vidly.com', 0, N'ANDvTZA6fXgIDGUK3VlJ+Fq98fIZ+2/LE3nPtULOkXXXNdcf0R/EgltFiP5lt67/VQ==', N'136f3e0b-b7ff-4c98-a96f-b15e25a2494c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'1389765c-96a6-4c72-b3c1-050a0c2dfcce', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'185cc574-503e-46e2-bb50-2880eb8c73e9', N'1389765c-96a6-4c72-b3c1-050a0c2dfcce')
");
        }
        
        public override void Down()
        {
        }
    }
}
