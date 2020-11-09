﻿// <auto-generated />
using System;
using Lab24IdentitySQLMovieDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab24IdentitySQLMovieDatabase.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201030014454_MovieCheckedOutMovie")]
    partial class MovieCheckedOutMovie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab24IdentitySQLMovieDatabase.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<double>("Runtime")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Actors = "Samuel L. Jackson",
                            Directors = "Fuminori Kizaki",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Afro Samurai",
                            Year = 2007
                        },
                        new
                        {
                            ID = 2,
                            Actors = "Beyonce",
                            Directors = "Walt Disney",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Lion King",
                            Year = 1994
                        },
                        new
                        {
                            ID = 3,
                            Actors = "Angela Basset",
                            Directors = "Walt Disney",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "The Princess and the Frog",
                            Year = 2007
                        },
                        new
                        {
                            ID = 4,
                            Actors = "Michael Jordan",
                            Directors = "Warner Brothers",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Space Jam",
                            Year = 2001
                        },
                        new
                        {
                            ID = 5,
                            Actors = "Chris Rock",
                            Directors = "Dreamwork",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Osmosis Jones",
                            Year = 2002
                        },
                        new
                        {
                            ID = 6,
                            Actors = "Will Smith",
                            Directors = "Dreamwork",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Shark Tale",
                            Year = 2003
                        },
                        new
                        {
                            ID = 7,
                            Actors = "John Goodman",
                            Directors = "Paramount",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Madagascar",
                            Year = 2004
                        },
                        new
                        {
                            ID = 8,
                            Actors = "Mike Meyer",
                            Directors = "Dreamwork",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Shrek",
                            Year = 2005
                        },
                        new
                        {
                            ID = 9,
                            Actors = "Samuel L. Jackson",
                            Directors = "Fuminori Kizaki",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Afro Samurai Resurection",
                            Year = 2009
                        },
                        new
                        {
                            ID = 10,
                            Actors = "Lucy Lu",
                            Directors = "Walt Disney",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "Mulan",
                            Year = 2007
                        },
                        new
                        {
                            ID = 11,
                            Actors = "Larry Cucumber",
                            Directors = "Ameake Owens",
                            Genre = 1,
                            Runtime = 0.0,
                            Title = "VeggieTales",
                            Year = 2008
                        },
                        new
                        {
                            ID = 12,
                            Actors = "Denzel Washington",
                            Directors = "Spike Lee",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Malcolm X",
                            Year = 2009
                        },
                        new
                        {
                            ID = 13,
                            Actors = "Janelle Monet",
                            Directors = "Pharrell Williams",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Hidden Figures",
                            Year = 2010
                        },
                        new
                        {
                            ID = 14,
                            Actors = "Martin Luther King",
                            Directors = "Oprah Winfrey",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Selma",
                            Year = 2011
                        },
                        new
                        {
                            ID = 15,
                            Actors = "Tom Hank",
                            Directors = "Wendy Finerman",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Forest Gump",
                            Year = 2012
                        },
                        new
                        {
                            ID = 16,
                            Actors = "Chadwick Boseman",
                            Directors = "Thomas Tull",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "42",
                            Year = 2013
                        },
                        new
                        {
                            ID = 17,
                            Actors = "Morgan Freeman",
                            Directors = "Matthew Broderick",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Glory",
                            Year = 2014
                        },
                        new
                        {
                            ID = 18,
                            Actors = "Idris Alba",
                            Directors = "Why Kids",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Beasts of No Nation",
                            Year = 2015
                        },
                        new
                        {
                            ID = 19,
                            Actors = "Whoppi Goldberg",
                            Directors = "Danny Glover",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "The Color Purple",
                            Year = 2016
                        },
                        new
                        {
                            ID = 20,
                            Actors = "Don Cheadle",
                            Directors = "Needed Change",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Hotel Rwanda",
                            Year = 2017
                        },
                        new
                        {
                            ID = 21,
                            Actors = "Jamie Foxx",
                            Directors = "Musical Genius",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Ray",
                            Year = 2018
                        },
                        new
                        {
                            ID = 22,
                            Actors = "Nicholas Cage",
                            Directors = "Real Life",
                            Genre = 4,
                            Runtime = 0.0,
                            Title = "Lord of War",
                            Year = 2019
                        },
                        new
                        {
                            ID = 23,
                            Actors = "Keegan Michael",
                            Directors = "Too Late",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Get Out",
                            Year = 2020
                        },
                        new
                        {
                            ID = 24,
                            Actors = "Edie Murphy",
                            Directors = "Chocolate Blood",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Blacula",
                            Year = 1990
                        },
                        new
                        {
                            ID = 25,
                            Actors = "Edie Murphy",
                            Directors = "Place Shelter",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Vampire in Brooklyn",
                            Year = 1999
                        },
                        new
                        {
                            ID = 26,
                            Actors = "Lamar Odom",
                            Directors = "Ruined Life",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Candyman",
                            Year = 1991
                        },
                        new
                        {
                            ID = 27,
                            Actors = "Ice Cube",
                            Directors = "Great Memories",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Tales from the Hood",
                            Year = 1992
                        },
                        new
                        {
                            ID = 28,
                            Actors = "Every One",
                            Directors = "Yearround Tan",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Us",
                            Year = 1993
                        },
                        new
                        {
                            ID = 29,
                            Actors = "Citizen Arest",
                            Directors = "Future Problem",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Purge",
                            Year = 1994
                        },
                        new
                        {
                            ID = 30,
                            Actors = "Samuel L. Jackson",
                            Directors = "Satan Child",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Spawn",
                            Year = 1995
                        },
                        new
                        {
                            ID = 31,
                            Actors = "Samuel L. Jackson",
                            Directors = "Hot Property",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "A Haunted House",
                            Year = 1996
                        },
                        new
                        {
                            ID = 32,
                            Actors = "Samuel L. Jackson",
                            Directors = "Waynes Family",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Scary Movie",
                            Year = 1997
                        },
                        new
                        {
                            ID = 33,
                            Actors = "Edie Murphy",
                            Directors = "Edie Murphy",
                            Genre = 2,
                            Runtime = 0.0,
                            Title = "Coming To America",
                            Year = 1998
                        },
                        new
                        {
                            ID = 34,
                            Actors = "National Geographic",
                            Directors = "Beautiful Nature",
                            Genre = 3,
                            Runtime = 0.0,
                            Title = "Planet Earth",
                            Year = 1999
                        },
                        new
                        {
                            ID = 35,
                            Actors = "Fresh Boat",
                            Directors = "Living Big",
                            Genre = 6,
                            Runtime = 0.0,
                            Title = "Crazy Rich Asians",
                            Year = 1980
                        },
                        new
                        {
                            ID = 36,
                            Actors = "Josh Ryan",
                            Directors = "Love Birds",
                            Genre = 6,
                            Runtime = 0.0,
                            Title = "The Notebook",
                            Year = 1981
                        },
                        new
                        {
                            ID = 37,
                            Actors = "Keanau Reeves",
                            Directors = "Coen Brothers",
                            Genre = 7,
                            Runtime = 0.0,
                            Title = "Matrix",
                            Year = 1982
                        },
                        new
                        {
                            ID = 38,
                            Actors = "Sigorni Weaver",
                            Directors = "Michael Bay",
                            Genre = 7,
                            Runtime = 0.0,
                            Title = "Aliens",
                            Year = 1983
                        },
                        new
                        {
                            ID = 39,
                            Actors = "Atticus Latrice",
                            Directors = "Magic Forsome",
                            Genre = 7,
                            Runtime = 0.0,
                            Title = "Lovecraft Country",
                            Year = 1984
                        },
                        new
                        {
                            ID = 40,
                            Actors = "Europeans Descent",
                            Directors = "Stay Alive",
                            Genre = 2,
                            Runtime = 0.0,
                            Title = "Eurotrip",
                            Year = 1985
                        },
                        new
                        {
                            ID = 41,
                            Actors = "Kids Caffein",
                            Directors = "Hungry Tired",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Hellraiser",
                            Year = 1986
                        },
                        new
                        {
                            ID = 42,
                            Actors = "Mike Meyer",
                            Directors = "Octoberfest",
                            Genre = 5,
                            Runtime = 0.0,
                            Title = "Friday The 13th",
                            Year = 1987
                        },
                        new
                        {
                            ID = 43,
                            Actors = "Michael Fox",
                            Directors = "Doctor",
                            Genre = 7,
                            Runtime = 0.0,
                            Title = "Back To The Future",
                            Year = 1988
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
