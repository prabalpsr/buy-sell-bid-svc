using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BuySellBid;

namespace buysellbidsvc.Migrations
{
    [DbContext(typeof(BuySellBidsContext))]
    [Migration("20160319124749_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("BuySellBid.Item", b =>
                {
                    b.Property<long>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CurrentBidAmount");

                    b.Property<string>("DetailedDesc");

                    b.Property<bool>("IsBiddable");

                    b.Property<string>("ItemLocation");

                    b.Property<string>("ItemName");

                    b.Property<double>("ItemPrice");

                    b.Property<int?>("ItemTypeItemTypeId");

                    b.Property<DateTime>("ListingEndDate");

                    b.Property<DateTime>("ListingStartDate");

                    b.Property<int?>("ListingStatusStatusId");

                    b.Property<long>("PhotoId");

                    b.Property<string>("SummaryDesc");

                    b.HasKey("ItemId");
                });

            modelBuilder.Entity("BuySellBid.ItemType", b =>
                {
                    b.Property<int>("ItemTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemTypeDescription");

                    b.HasKey("ItemTypeId");
                });

            modelBuilder.Entity("BuySellBid.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChatId");

                    b.Property<string>("EmailId");

                    b.Property<string>("Name");

                    b.Property<int?>("PersonStatusStatusId");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("UserId");

                    b.HasKey("PersonId");
                });

            modelBuilder.Entity("BuySellBid.PersonItem", b =>
                {
                    b.Property<long>("PersonItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountRecievablePayable");

                    b.Property<double>("BidAmount");

                    b.Property<DateTime>("ItemBuySellBidDateTime");

                    b.Property<long>("ItemId");

                    b.Property<long>("PersonId");

                    b.Property<int?>("PersonItemStatusStatusId");

                    b.Property<int?>("RoleTypeRoleTypeId");

                    b.HasKey("PersonItemId");
                });

            modelBuilder.Entity("BuySellBid.Photo", b =>
                {
                    b.Property<long>("PhotoId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ItemItemId");

                    b.Property<string>("PhotoName");

                    b.Property<int?>("PhotoStatusStatusId");

                    b.Property<string>("PhotoURL");

                    b.HasKey("PhotoId");
                });

            modelBuilder.Entity("BuySellBid.RoleType", b =>
                {
                    b.Property<int>("RoleTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleDescription");

                    b.HasKey("RoleTypeId");
                });

            modelBuilder.Entity("BuySellBid.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusDescription");

                    b.HasKey("StatusId");
                });

            modelBuilder.Entity("BuySellBid.Item", b =>
                {
                    b.HasOne("BuySellBid.ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeItemTypeId");

                    b.HasOne("BuySellBid.Status")
                        .WithMany()
                        .HasForeignKey("ListingStatusStatusId");
                });

            modelBuilder.Entity("BuySellBid.Person", b =>
                {
                    b.HasOne("BuySellBid.Status")
                        .WithMany()
                        .HasForeignKey("PersonStatusStatusId");
                });

            modelBuilder.Entity("BuySellBid.PersonItem", b =>
                {
                    b.HasOne("BuySellBid.Status")
                        .WithMany()
                        .HasForeignKey("PersonItemStatusStatusId");

                    b.HasOne("BuySellBid.RoleType")
                        .WithMany()
                        .HasForeignKey("RoleTypeRoleTypeId");
                });

            modelBuilder.Entity("BuySellBid.Photo", b =>
                {
                    b.HasOne("BuySellBid.Item")
                        .WithMany()
                        .HasForeignKey("ItemItemId");

                    b.HasOne("BuySellBid.Status")
                        .WithMany()
                        .HasForeignKey("PhotoStatusStatusId");
                });
        }
    }
}
