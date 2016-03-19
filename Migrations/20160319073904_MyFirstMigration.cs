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
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChatId = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PersonStatus = table.Column<bool>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });
            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    BuyerId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuyerEntityPersonId = table.Column<long>(nullable: true),
                    BuyerStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.BuyerId);
                    table.ForeignKey(
                        name: "FK_Buyer_Person_BuyerEntityPersonId",
                        column: x => x.BuyerEntityPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    SellerId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SellerEntityPersonId = table.Column<long>(nullable: true),
                    SellerStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.SellerId);
                    table.ForeignKey(
                        name: "FK_Seller_Person_SellerEntityPersonId",
                        column: x => x.SellerEntityPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DefaultPhotoPhotoId = table.Column<long>(nullable: true),
                    DetailedDesc = table.Column<string>(nullable: true),
                    ItemLocation = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<double>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    ListingEndDate = table.Column<DateTime>(nullable: false),
                    ListingStartDate = table.Column<DateTime>(nullable: false),
                    ListingStatus = table.Column<int>(nullable: false),
                    SummaryDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });
            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    ListItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmountPayable = table.Column<double>(nullable: false),
                    AmountReceivable = table.Column<double>(nullable: false),
                    BuyerBuyerId = table.Column<long>(nullable: true),
                    ContextStatus = table.Column<int>(nullable: false),
                    CurrentBidAmount = table.Column<double>(nullable: false),
                    IsBiddable = table.Column<bool>(nullable: false),
                    ItemItemId = table.Column<long>(nullable: true),
                    SellerSellerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItem", x => x.ListItemId);
                    table.ForeignKey(
                        name: "FK_ListItem_Buyer_BuyerBuyerId",
                        column: x => x.BuyerBuyerId,
                        principalTable: "Buyer",
                        principalColumn: "BuyerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListItem_Item_ItemItemId",
                        column: x => x.ItemItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListItem_Seller_SellerSellerId",
                        column: x => x.SellerSellerId,
                        principalTable: "Seller",
                        principalColumn: "SellerId",
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
                    PhotoStatus = table.Column<bool>(nullable: false),
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
                });
            migrationBuilder.AddForeignKey(
                name: "FK_Item_Photo_DefaultPhotoPhotoId",
                table: "Item",
                column: "DefaultPhotoPhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Photo_Item_ItemItemId", table: "Photo");
            migrationBuilder.DropTable("ListItem");
            migrationBuilder.DropTable("Buyer");
            migrationBuilder.DropTable("Seller");
            migrationBuilder.DropTable("Person");
            migrationBuilder.DropTable("Item");
            migrationBuilder.DropTable("Photo");
        }
    }
}
