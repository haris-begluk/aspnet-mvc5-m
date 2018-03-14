namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31939f55-9234-4ee3-9a8f-abfd0eca7d89', N'admin@webapp.com', 0, N'AAiWc6KCyVKDY6L+ZfoV/cm1jtOCie5Qwqn3x+UKCddIhaddvlVffhIt/2pHmTiGxw==', N'8f183f4b-46cc-435c-b95a-6866d73821aa', NULL, 0, 0, NULL, 1, 0, N'admin@webapp.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6382ad8a-7704-4806-bca9-ac0310371170', N'neko.nesto.cryptocoin@outlook.com', 0, N'ALALu5na+gbJCaoa07yL469pUzHc8bjU23Q1xNt8e+2lZMqpqpYWyBAYfs9x5qdF+g==', N'c8011a97-9ad1-4dbf-98eb-ffa7423367af', NULL, 0, 0, NULL, 1, 0, N'neko.nesto.cryptocoin@outlook.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'00eda042-7f3b-4647-abd3-bb147052058c', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31939f55-9234-4ee3-9a8f-abfd0eca7d89', N'00eda042-7f3b-4647-abd3-bb147052058c')
                   ");


        }

        public override void Down()
        {
        }
    }
}
