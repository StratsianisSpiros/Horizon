namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(maxLength: 20),
                        CompanyAddress = c.String(maxLength: 50),
                        CompanyPhone = c.String(),
                        LogoUrl = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.EmployeeEvents",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        Username = c.String(),
                        Description = c.String(),
                        Overtime = c.Double(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(),
                        Color = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        IsFullDay = c.Boolean(nullable: false),
                        EmployeeUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Companies", t => t.CompanyID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.EmployeeUser_Id)
                .Index(t => t.CompanyID)
                .Index(t => t.EmployeeUser_Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        PostDate = c.DateTime(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Username = c.String(),
                        DaysWorked = c.Int(nullable: false),
                        DaysAbsent = c.Int(nullable: false),
                        DaysHolidays = c.Int(nullable: false),
                        TotalPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NormalPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OverTimePay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HolidayPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OverTimeHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HolidayHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PayDate = c.DateTime(),
                        EmployeeUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.AspNetUsers", t => t.EmployeeUser_Id)
                .Index(t => t.EmployeeUser_Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Response = c.String(),
                        RequestDate = c.DateTime(),
                        Username = c.String(),
                        AskRequest = c.Boolean(nullable: false),
                        EmployeeUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.AspNetUsers", t => t.EmployeeUser_Id)
                .Index(t => t.EmployeeUser_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 20),
                        CompanyId = c.Int(nullable: false),
                        CompanyName = c.String(maxLength: 20),
                        IsAdmin = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        SubscriptionId = c.String(),
                        SubsciptionStatus = c.String(),
                        Address = c.String(maxLength: 50),
                        PayRate = c.Decimal(precision: 18, scale: 2),
                        OverTimeRate = c.Decimal(precision: 18, scale: 2),
                        PayMethod = c.Int(),
                        HireDate = c.DateTime(),
                        TaxRate = c.Int(),
                        AvatarUrl = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Payments", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.EmployeeEvents", "EmployeeUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Posts", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.EmployeeEvents", "CompanyID", "dbo.Companies");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Requests", new[] { "EmployeeUser_Id" });
            DropIndex("dbo.Payments", new[] { "EmployeeUser_Id" });
            DropIndex("dbo.Posts", new[] { "CompanyId" });
            DropIndex("dbo.EmployeeEvents", new[] { "EmployeeUser_Id" });
            DropIndex("dbo.EmployeeEvents", new[] { "CompanyID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Requests");
            DropTable("dbo.Payments");
            DropTable("dbo.Posts");
            DropTable("dbo.EmployeeEvents");
            DropTable("dbo.Companies");
        }
    }
}
