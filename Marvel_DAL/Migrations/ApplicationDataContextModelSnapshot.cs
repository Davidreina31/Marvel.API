// <auto-generated />
using System;
using Marvel.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marvel_DAL.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    partial class ApplicationDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Marvel.Entities.Hero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Marvel.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Marvel.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Marvel.Entities.User_Hero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HeroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersHeroes");
                });

            modelBuilder.Entity("Marvel.Entities.Hero", b =>
                {
                    b.HasOne("Marvel.Entities.Team", null)
                        .WithMany("Heroes")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Marvel.Entities.Team", b =>
                {
                    b.HasOne("Marvel.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvel.Entities.User_Hero", b =>
                {
                    b.HasOne("Marvel.Entities.Hero", "Hero")
                        .WithMany("UserHero")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Marvel.Entities.User", "User")
                        .WithMany("UserHero")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hero");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Marvel.Entities.Hero", b =>
                {
                    b.Navigation("UserHero");
                });

            modelBuilder.Entity("Marvel.Entities.Team", b =>
                {
                    b.Navigation("Heroes");
                });

            modelBuilder.Entity("Marvel.Entities.User", b =>
                {
                    b.Navigation("UserHero");
                });
#pragma warning restore 612, 618
        }
    }
}
