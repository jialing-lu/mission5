// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DirectorFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            DirectorFirstName = "Richard",
                            DirectorLastName = "Curtis",
                            Edited = true,
                            LentTo = "",
                            Notes = "Merry Christmas!",
                            Rating = "R",
                            Title = "Love Actually",
                            Year = (ushort)2003
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            DirectorFirstName = "Ridley",
                            DirectorLastName = "Scott",
                            Edited = false,
                            LentTo = "",
                            Notes = "MUST: Director's Cut",
                            Rating = "R",
                            Title = "Kingdom of Heaven",
                            Year = (ushort)2005
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            DirectorFirstName = "Hoon-jung",
                            DirectorLastName = "Park",
                            Edited = false,
                            LentTo = "",
                            Notes = "BEST EVER",
                            Rating = "R",
                            Title = "New World",
                            Year = (ushort)2013
                        });
                });

            modelBuilder.Entity("DateMe.Models.category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Category = "Romance"
                        },
                        new
                        {
                            CategoryId = 2,
                            Category = "War"
                        },
                        new
                        {
                            CategoryId = 3,
                            Category = "Crime"
                        });
                });

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.HasOne("DateMe.Models.category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
