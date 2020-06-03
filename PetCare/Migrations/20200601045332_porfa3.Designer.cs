﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCare.Persistence.Context;

namespace PetCare.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200601045332_porfa3")]
    partial class porfa3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PetCare.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionPlanId")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("SubscriptionPlanId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateAvailability")
                        .HasColumnType("text");

                    b.Property<string>("EndTime")
                        .HasColumnType("text");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("ServiceId")
                        .IsUnique();

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("PetCare.Domain.Models.BusinessProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Owner")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("ProviderId");

                    b.ToTable("BusinessProfiles");
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

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

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

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PetId")
                        .IsUnique();

                    b.HasIndex("ProviderId");

                    b.ToTable("MedicalProfiles");
                });

            modelBuilder.Entity("PetCare.Domain.Models.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Action")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("MedicalProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("MedicalProfileId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CVV")
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

            modelBuilder.Entity("PetCare.Domain.Models.PersonProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Document")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("PersonProfiles");
                });

            modelBuilder.Entity("PetCare.Domain.Models.PersonRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime");

                    b.Property<string>("EndTime")
                        .HasColumnType("text");

                    b.Property<int>("PersonProfileId")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PersonProfileId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Requests");
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PersonProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("PersonProfileId");

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

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

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

            modelBuilder.Entity("PetCare.Domain.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Publish")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Busca veterinarias",
                            Name = "Usuario",
                            Publish = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ofrece Servicios",
                            Name = "ServicesProvider",
                            Publish = true
                        });
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

            modelBuilder.Entity("PetCare.Domain.Models.SubscriptionPlan", b =>
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
                            Description = "Plan Free",
                            Duration = 1,
                            Name = "Free",
                            Price = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Plan Basico",
                            Duration = 1,
                            Name = "Basica",
                            Price = 19.899999999999999
                        },
                        new
                        {
                            Id = 3,
                            Description = "Plan Premium",
                            Duration = 1,
                            Name = "Premium",
                            Price = 39.899999999999999
                        });
                });

            modelBuilder.Entity("PetCare.Domain.Models.VaccinationRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("VaccinationRecords");
                });

            modelBuilder.Entity("PetCare.Domain.Models.Account", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Rol", "Rol")
                        .WithMany("Accounts")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.SubscriptionPlan", "SubscriptionPlan")
                        .WithMany("Accounts")
                        .HasForeignKey("SubscriptionPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Availability", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.Service", "Service")
                        .WithOne("Availability")
                        .HasForeignKey("PetCare.Domain.Models.Availability", "ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.BusinessProfile", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Account", "Account")
                        .WithOne("BusinessProfile")
                        .HasForeignKey("PetCare.Domain.Models.BusinessProfile", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.Provider", "Provider")
                        .WithMany("BusinessProfiles")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.MedicalProfile", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Pet", "pet")
                        .WithOne("MedicalProfile")
                        .HasForeignKey("PetCare.Domain.Models.MedicalProfile", "PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.Provider", "Provider")
                        .WithMany("MedicalProfiles")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.MedicalRecord", b =>
                {
                    b.HasOne("PetCare.Domain.Models.MedicalProfile", "MedicalProfile")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("MedicalProfileId")
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

            modelBuilder.Entity("PetCare.Domain.Models.PersonProfile", b =>
                {
                    b.HasOne("PetCare.Domain.Models.Account", "Account")
                        .WithOne("PersonProfile")
                        .HasForeignKey("PetCare.Domain.Models.PersonProfile", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.PersonRequest", b =>
                {
                    b.HasOne("PetCare.Domain.Models.PersonProfile", "PersonProfile")
                        .WithMany("Requests")
                        .HasForeignKey("PersonProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Domain.Models.Service", "Service")
                        .WithMany("Requests")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.Pet", b =>
                {
                    b.HasOne("PetCare.Domain.Models.PersonProfile", "PersonProfile")
                        .WithMany("Pets")
                        .HasForeignKey("PersonProfileId")
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

            modelBuilder.Entity("PetCare.Domain.Models.Service", b =>
                {
                    b.HasOne("PetCare.Domain.Models.ServiType", "ServiType")
                        .WithMany("ListServices")
                        .HasForeignKey("ServiTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetCare.Domain.Models.VaccinationRecord", b =>
                {
                    b.HasOne("PetCare.Domain.Models.MedicalProfile", "Profile")
                        .WithMany("VaccinationRecords")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
