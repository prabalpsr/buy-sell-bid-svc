using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BuySellBid;

namespace buysellbidsvc.Migrations
{
    [DbContext(typeof(BuySellBidsContext))]
    partial class BuySellBidsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("BuySellBid.Buyer", b =>
                {
                    b.Property<long>("BuyerId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("BuyerEntityPersonId");

                    b.Property<bool>("BuyerStatus");

                    b.HasKey("BuyerId");
                });

            modelBuilder.Entity("BuySellBid.Item", b =>
                {
                    b.Property<long>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("DefaultPhotoPhotoId");

                    b.Property<string>("DetailedDesc");

                    b.Property<string>("ItemLocation");

                    b.Property<string>("ItemName");

                    b.Property<double>("ItemPrice");

                    b.Property<int>("ItemType");

                    b.Property<DateTime>("ListingEndDate");

                    b.Property<DateTime>("ListingStartDate");

                    b.Property<int>("ListingStatus");

                    b.Property<string>("SummaryDesc");

                    b.HasKey("ItemId");
                });

            modelBuilder.Entity("BuySellBid.ListItem", b =>
                {
                    b.Property<int>("ListItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountPayable");

                    b.Property<double>("AmountReceivable");

                    b.Property<long?>("BuyerBuyerId");

                    b.Property<int>("ContextStatus");

                    b.Property<double>("CurrentBidAmount");

                    b.Property<bool>("IsBiddable");

                    b.Property<long?>("ItemItemId");

                    b.Property<long?>("SellerSellerId");

                    b.HasKey("ListItemId");
                });

            modelBuilder.Entity("BuySellBid.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChatId");

                    b.Property<string>("EmailId");

                    b.Property<string>("Name");

                    b.Property<bool>("PersonStatus");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("UserId");

                    b.HasKey("PersonId");
                });

            modelBuilder.Entity("BuySellBid.Photo", b =>
                {
                    b.Property<long>("PhotoId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ItemItemId");

                    b.Property<string>("PhotoName");

                    b.Property<bool>("PhotoStatus");

                    b.Property<string>("PhotoURL");

                    b.HasKey("PhotoId");
                });

            modelBuilder.Entity("BuySellBid.Seller", b =>
                {
                    b.Property<long>("SellerId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("SellerEntityPersonId");

                    b.Property<bool>("SellerStatus");

                    b.HasKey("SellerId");
                });

            modelBuilder.Entity("BuySellBid.Buyer", b =>
                {
                    b.HasOne("BuySellBid.Person")
                        .WithMany()
                        .HasForeignKey("BuyerEntityPersonId");
                });

            modelBuilder.Entity("BuySellBid.Item", b =>
                {
                    b.HasOne("BuySellBid.Photo")
                        .WithMany()
                        .HasForeignKey("DefaultPhotoPhotoId");
                });

            modelBuilder.Entity("BuySellBid.ListItem", b =>
                {
                    b.HasOne("BuySellBid.Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerBuyerId");

                    b.HasOne("BuySellBid.Item")
                        .WithMany()
                        .HasForeignKey("ItemItemId");

                    b.HasOne("BuySellBid.Seller")
                        .WithMany()
                        .HasForeignKey("SellerSellerId");
                });

            modelBuilder.Entity("BuySellBid.Photo", b =>
                {
                    b.HasOne("BuySellBid.Item")
                        .WithMany()
                        .HasForeignKey("ItemItemId");
                });

            modelBuilder.Entity("BuySellBid.Seller", b =>
                {
                    b.HasOne("BuySellBid.Person")
                        .WithMany()
                        .HasForeignKey("SellerEntityPersonId");
                });
        }
    }
}
