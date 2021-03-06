// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskShop.Data.DB;

namespace TaskShop.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskShop.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "my product",
                            Name = "brea1d",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "my product",
                            Name = "bread2",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "my product",
                            Name = "bread3",
                            ShopId = 3
                        });
                });

            modelBuilder.Entity("TaskShop.Data.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingMode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shop");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "heryzo",
                            Name = "MyShop1",
                            OperatingMode = "my shop"
                        },
                        new
                        {
                            Id = 2,
                            Address = "heryzo",
                            Name = "MyShop2",
                            OperatingMode = "my shop"
                        },
                        new
                        {
                            Id = 3,
                            Address = "heryzo",
                            Name = "MyShop3",
                            OperatingMode = "my shop"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
