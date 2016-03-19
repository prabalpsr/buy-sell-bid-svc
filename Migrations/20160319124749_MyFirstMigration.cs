using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace buysellbidsvc.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeId);
                });
            migrationBuilder.CreateTable(
                name: "RoleType",
                columns: table => new
                {
                    RoleTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleType", x => x.RoleTypeId);
                });
            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentBidAmount = table.Column<double>(nullable: false),
                    DetailedDesc = table.Column<string>(nullable: true),
                    IsBiddable = table.Column<bool>(nullable: false),
                    ItemLocation = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<double>(nullable: false),
                    ItemTypeItemTypeId = table.Column<int>(nullable: true),
                    ListingEndDate = table.Column<DateTime>(nullable: false),
                    ListingStartDate = table.Column<DateTime>(nullable: false),
                    ListingStatusStatusId = table.Column<int>(nullable: true),
                    PhotoId = table.Column<long>(nullable: false),
                    SummaryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_ItemType_ItemTypeItemTypeId",
                        column: x => x.ItemTypeItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Status_ListingStatusStatusId",
                        column: x => x.ListingStatusStatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChatId = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonStatusStatusId = table.Column<int>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Status_PersonStatusStatusId",
                        column: x => x.PersonStatusStatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "PersonItem",
                columns: table => new
                {
                    PersonItemId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmountRecievablePayable = table.Column<double>(nullable: false),
                    BidAmount = table.Column<double>(nullable: false),
                    ItemBuySellBidDateTime = table.Column<DateTime>(nullable: false),
                    ItemId = table.Column<long>(nullable: false),
                    PersonId = table.Column<long>(nullable: false),
                    PersonItemStatusStatusId = table.Column<int>(nullable: true),
                    RoleTypeRoleTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonItem", x => x.PersonItemId);
                    table.ForeignKey(
                        name: "FK_PersonItem_Status_PersonItemStatusStatusId",
                        column: x => x.PersonItemStatusStatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonItem_RoleType_RoleTypeRoleTypeId",
                        column: x => x.RoleTypeRoleTypeId,
                        principalTable: "RoleType",
                        principalColumn: "RoleTypeId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemItemId = table.Column<long>(nullable: true),
                    PhotoName = table.Column<string>(nullable: true),
                    PhotoStatusStatusId = table.Column<int>(nullable: true),
                    PhotoURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photo_Item_ItemItemId",
                        column: x => x.ItemItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photo_Status_PhotoStatusStatusId",
                        column: x => x.PhotoStatusStatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Person");
            migrationBuilder.DropTable("PersonItem");
            migrationBuilder.DropTable("Photo");
            migrationBuilder.DropTable("RoleType");
            migrationBuilder.DropTable("Item");
            migrationBuilder.DropTable("ItemType");
            migrationBuilder.DropTable("Status");
        }
    }
}
