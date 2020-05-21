﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCare.Persistence.Context;

namespace PetCare.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PetCare.Domain.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PetCare.Domain.Models.MedicalProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Eyes")
                        .HasColumnType("text");

                    b.Property<string>("Height")
                        .HasColumnType("text");

                    b.Property<string>("Lenght")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PetId")
                        .IsUnique();

                    b.ToTable("MedicalProfiles");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CVV_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DateOfExpiry")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServicesProviderForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicesProviderForeignKey")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("SuscriptionPlanId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SuscriptionPlanId");

                    b.ToTable("ServicesProviders");
                });

            modelBuilder.Entity("PetCare.Domain.Models.ProviderJoinService", b =>
                {
                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("ProviderId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ProviderJoinServices");
                });

            modelBuilder.Entity("PetCare.Domain.Models.ProviderRepresentative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Phone1")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Phone2")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProviderRepresentatives");
                });

            modelBuilder.Entity("PetCare.Domain.Models.ServiType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ServiTypes");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ServiTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("PetCare.Domain.Models.SuscriptionPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("SuscriptionPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Plan Basico",
                            Duration = 1,
                            Name = "Basica",
                            Price = 19.899999999999999
                        },
                        new
                        {
                            Id = 2,
                            Description = "Plan Premium",
                            Duration = 1,
                            Name = "Premium",
                            Price = 39.899999999999999
                        });
                });

            modelBuilder.Entity("PetCare.Domain.Models.MedicalProfile", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Pet", "pet")
                        .WithOne("MedicalProfile")
                        .HasForeignKey("PetCare.Domain.Models.MedicalProfile", "PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Payment", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Provider", "ServicesProvider")
                        .WithOne("Payment")
                        .HasForeignKey("PetCare.Domain.Models.Payment", "ServicesProviderForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Pet", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Customer", "Customer")
                        .WithMany("Pets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Provider", b =>
                {
                    b.HasOne("PetCare.Domain.Models.SuscriptionPlan", "SuscriptionPlan")
                        .WithMany("ListServicesProvider")
                        .HasForeignKey("SuscriptionPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.ProviderJoinService", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Provider", "Provider")
                        .WithMany("ProviderServices")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.Service", "Service")
                        .WithMany("ProviderServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.ProviderRepresentative", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Provider", "Provider")
                        .WithMany("ProviderRepresentatives")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Service", b =>
                {
                    b.HasOne("PetCare.Domain.Models.ServiType", "ServiType")
                        .WithMany("ListServices")
                        .HasForeignKey("ServiTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
