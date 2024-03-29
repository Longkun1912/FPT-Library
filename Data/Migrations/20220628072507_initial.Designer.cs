﻿// <auto-generated />
using System;
using FPTLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FPTLibrary.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220628072507_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FPTBook.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            Image = "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png",
                            Mobile = "0321169923",
                            Name = "Admin",
                            Password = "admin@123"
                        });
                });

            modelBuilder.Entity("FPTBook.Models.Store_Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store_Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Hanoi",
                            Email = "storeowner@gmail.com",
                            Image = "https://static2.yan.vn/YanNews/2167221/202102/facebook-cap-nhat-avatar-doi-voi-tai-khoan-khong-su-dung-anh-dai-dien-e4abd14d.jpg",
                            Mobile = "0324664553",
                            Name = "StoreOwner",
                            Password = "storeowner@123"
                        });
                });

            modelBuilder.Entity("FPTLibrary.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("Published_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Makoto Shinkai",
                            CategoryId = 3,
                            Description = "A comet appears and mysteriously affects and connects the lives of two teenagers of the same age, a boy in the big, bustling city of Tokyo and a girl in a country village where life is slow but idyllic. They find for unknown reasons, they wake up in each other's bodies for weeks at a time. At first, they both think these experiences are just vivid dreams, but when the reality of their situations sinks in, they learn to adjust and even enjoy it. Soon they start to communicate and try to leave notes about who they are and what they are doing. But as they discover more about each other and the other's life, they uncover some disturbing hints that their distance is more than just physical and tragedy haunts them.",
                            Image = "https://upload.wikimedia.org/wikipedia/vi/b/b3/Your_Name_novel.jpg",
                            Name = "Your Name",
                            Price = 500.0,
                            Published_Date = new DateTime(2016, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 30
                        },
                        new
                        {
                            Id = 2,
                            Author = "Bram Stoker",
                            CategoryId = 2,
                            Description = "The novel has no single protagonist, but opens with solicitor Jonathan Harker taking a business trip to stay at the castle of a Transylvanian noble, Count Dracula. Harker escapes the castle after discovering that Dracula is a vampire, and the Count moves to England and plagues the seaside town of Whitby. A small group, led by Abraham Van Helsing, hunt Dracula and, in the end, kill him.",
                            Image = "https://thebookmarketng.com/wp-content/uploads/2020/08/dracula.jpg",
                            Name = "Dracula",
                            Price = 700.0,
                            Published_Date = new DateTime(1897, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            Author = "Rosalind S. Helderman",
                            CategoryId = 1,
                            Description = "One of the most urgent and important investigations ever conducted, the Mueller inquiry focuses on Donald Trump, his presidential campaign, and Russian interference in the 2016 election, and draws on the testimony of dozens of witnesses and the work of some of the country’s most seasoned prosecutors.",
                            Image = "https://m.media-amazon.com/images/P/B07PB76691.01._SCLZZZZZZZ_SX500_.jpg",
                            Name = "The Mueller Report",
                            Price = 300.0,
                            Published_Date = new DateTime(2013, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 20
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stephen King",
                            CategoryId = 2,
                            Description = "IT tells the story of seven friends who face an evil shape shifting entity that feeds on the fears of children. One of IT’s favorite disguises is a circus clown called Pennywise, otherwise known as 'Bob Gray'.",
                            Image = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781982127794/it-9781982127794_hr.jpg",
                            Name = "IT",
                            Price = 800.0,
                            Published_Date = new DateTime(1986, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 60
                        },
                        new
                        {
                            Id = 5,
                            Author = "Dan Simmons",
                            CategoryId = 4,
                            Description = "On the world called Hyperion, beyond the reach of galactic law, waits a creature called the Shrike. There are those who worship it. There are those who fear it. And there are those who have vowed to destroy it. In the Valley of the Time Tombs, where huge, brooding structures move backward through time, the Shrike waits for them all. On the eve of Armageddon, with the entire galaxy at war, seven pilgrims set forth on a final voyage to Hyperion seeking the answers to the unsolved riddles of their lives. Each carries a desperate hope—and a terrible secret. And one may hold the fate of humanity in his hands.",
                            Image = "https://m.media-amazon.com/images/P/0399178619.01._SCLZZZZZZZ_SX500_.jpg",
                            Name = "Hyperion",
                            Price = 400.0,
                            Published_Date = new DateTime(1990, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 10
                        },
                        new
                        {
                            Id = 6,
                            Author = "Orson Scott Card",
                            CategoryId = 4,
                            Description = "In order to develop a secure defense against a hostile alien race's next attack, government agencies breed child geniuses and train them as soldiers. A brilliant young boy, Andrew Ender Wiggin lives with his kind but distant parents, his sadistic brother Peter, and the person he loves more than anyone else, his sister Valentine. Peter and Valentine were candidates for the soldier-training program but didn't make the cut--young Ender is the Wiggin drafted to the orbiting Battle School for rigorous military training. Ender's skills make him a leader in school and respected in the Battle Room, where children play at mock battles in zero gravity. Yet growing up in an artificial community of young soldiers, Ender suffers greatly from isolation, rivalry from his peers, pressure from the adult teachers, and an unsettling fear of the alien invaders. His psychological battles include loneliness, fear that he is becoming like the cruel brother he remembers, and fanning the flames of devotion to his beloved sister. Is Ender the general Earth needs? But Ender is not the only result of the genetic experiments. The war with the Buggers has been raging for a hundred years, and the quest for the perfect general has been underway for almost as long. Ender's two older siblings are every bit as unusual as he is, but in very different ways. Between the three of them lie the abilities to remake a world. If the world survives, that is. ",
                            Image = "https://images-na.ssl-images-amazon.com/images/I/81+IUsYtGTL.jpg",
                            Name = "Ender's Game",
                            Price = 350.0,
                            Published_Date = new DateTime(1994, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 30
                        },
                        new
                        {
                            Id = 7,
                            Author = "Jeff Goldberg",
                            CategoryId = 6,
                            Description = "The main subject of the book is the Big East Tournament championship game of 2001, although the book intersperses play by play coverage of the game with background information on the entire season, as well as commentary on the players, coaches and other aspects of the two programs. The game featured in the book was neither the first nor the last meeting of the two teams in the season.[3] In January, UConn played Notre Dame at Notre Dame. The UConn team was undefeated, and ranked number one in the country at the start of the game. Notre Dame won 92–76, remained undefeated, and moved from third to the number one ranking at the next poll.[4] Both teams would also meet in the semifinals of the NCAA Tournament, with Notre Dame prevailing and then going on to win the national championship. All of the meetings between the two teams that year were important games for each team, but the game in March had multiple story lines—a tournament championship at stake, a close game in which neither team led by more than eight points at any time, a devastating injury to one of the game's best players, and finally, a game that was decided by a single basket scored in the final moments, by one of the best players in the sport, Sue Bird.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/a/a3/Bird_at_the_Buzzer_cover.jpg",
                            Name = "Bird at the Buzzer",
                            Price = 200.0,
                            Published_Date = new DateTime(2011, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 15
                        });
                });

            modelBuilder.Entity("FPTLibrary.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://cdn-amz.fadoglobal.io/images/I/81o791tFXeS.jpg",
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://cdn2.f-cdn.com/contestentries/1121968/17989453/59a8471fb17b9_thumb900.jpg",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://www.inquirer.com/resizer/rJ2GQrjd5GR5ruMdmhLbBdJesCY=/filters:format(webp)/cloudfront-us-east-1.images.arcpublishing.com/pmn/SRCJLCGZVBBPTJSRAFMSX34GOM.jpg",
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://cdn0.fahasa.com/media/catalog/product/t/h/the_science_book_big_ideas_simply_explained_1_2021_08_28_12_21_00.jpg",
                            Name = "Science"
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://m.media-amazon.com/images/I/41m0T7VZwAL.jpg",
                            Name = "Science fiction & mystery"
                        },
                        new
                        {
                            Id = 6,
                            Image = "https://www.casino.org/news/wp-content/uploads/2021/06/Screen-Shot-2021-06-24-at-11.57.05-AM.png",
                            Name = "Sport"
                        });
                });

            modelBuilder.Entity("FPTLibrary.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Tay Ho",
                            Email = "phamkhacthanhphong@gmail.com",
                            FirstName = "Phong",
                            Image = "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png",
                            LastName = "Pham",
                            Mobile = "0321169923",
                            Password = "phong"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Nam Dinh",
                            Email = "vubinhchuong@gmail.com",
                            FirstName = "Chuong",
                            Image = "https://static.toiimg.com/thumb/resizemode-4,msid-76729750,imgsize-249247,width-720/76729750.jpg",
                            LastName = "Vu",
                            Mobile = "0324164953",
                            Password = "chuong"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Nam Dinh",
                            Email = "phamhoanglong@gmail.com",
                            FirstName = "Long",
                            Image = "https://guantanamocity.org/wp-content/uploads/2020/12/huong-dan-tao-anh-dai-dien-hoat-hinh-tren-facebook-cach-tao-avatar-facebook-1.png",
                            LastName = "Pham",
                            Mobile = "0324664553",
                            Password = "long"
                        });
                });

            modelBuilder.Entity("FPTLibrary.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CustomerId = 1,
                            Order_Date = new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Payment = 3,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CustomerId = 2,
                            Order_Date = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Payment = 0,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            BookId = 5,
                            CustomerId = 1,
                            Order_Date = new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Payment = 1,
                            Quantity = 30
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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "faaefacd-1dbd-4d7e-8c53-2dda37592b42",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "75551a02-f55c-43a5-a7d4-6070c93831c8",
                            Name = "Store Owner",
                            NormalizedName = "STORE OWNER"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "3c621e23-5159-49aa-9e95-34e329eb32f0",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
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

            modelBuilder.Entity("FPTLibrary.Models.Book", b =>
                {
                    b.HasOne("FPTLibrary.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FPTLibrary.Models.Order", b =>
                {
                    b.HasOne("FPTLibrary.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FPTLibrary.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
