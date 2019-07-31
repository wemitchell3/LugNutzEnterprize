﻿// <auto-generated />
using System;
using LugNutzEnterprize.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LugNutzEnterprize.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190731231924_UserIdUpdate")]
    partial class UserIdUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LugNutzEnterprize.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsMasterMechanic");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LugNutzEnterprize.Models.MaintenanceTask", b =>
                {
                    b.Property<int>("MaintenanceTaskId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("IsComplete");

                    b.Property<string>("MaintenanceTaskDescription")
                        .IsRequired();

                    b.Property<string>("MaintenanceTaskTitle")
                        .IsRequired();

                    b.Property<DateTime>("TargetCompleteDate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TaskDueAtMileage");

                    b.Property<int>("VehicleId");

                    b.HasKey("MaintenanceTaskId");

                    b.ToTable("MaintenanceTask");
                });

            modelBuilder.Entity("LugNutzEnterprize.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("MessageContent")
                        .IsRequired();

                    b.Property<string>("Topic")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("MessageId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("LugNutzEnterprize.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABS");

                    b.Property<string>("ActiveSafetySysNote");

                    b.Property<string>("AdaptiveCruiseControl");

                    b.Property<string>("AdaptiveDrivingBeam");

                    b.Property<string>("AdaptiveHeadlights");

                    b.Property<string>("AdditionalErrorText");

                    b.Property<string>("AirBagLocCurtain");

                    b.Property<string>("AirBagLocFront");

                    b.Property<string>("AirBagLocKnee");

                    b.Property<string>("AirBagLocSeatCushion");

                    b.Property<string>("AirBagLocSide");

                    b.Property<string>("AutoReverseSystem");

                    b.Property<string>("AutomaticPedestrianAlertingSound");

                    b.Property<string>("AxleConfiguration");

                    b.Property<string>("Axles");

                    b.Property<string>("BasePrice");

                    b.Property<string>("BatteryA");

                    b.Property<string>("BatteryA_to");

                    b.Property<string>("BatteryCells");

                    b.Property<string>("BatteryInfo");

                    b.Property<string>("BatteryKWh");

                    b.Property<string>("BatteryKWh_to");

                    b.Property<string>("BatteryModules");

                    b.Property<string>("BatteryPacks");

                    b.Property<string>("BatteryType");

                    b.Property<string>("BatteryV");

                    b.Property<string>("BatteryV_to");

                    b.Property<string>("BedLengthIN");

                    b.Property<string>("BedType");

                    b.Property<string>("BlindSpotMon");

                    b.Property<string>("BodyCabType");

                    b.Property<string>("BodyClass");

                    b.Property<string>("BrakeSystemDesc");

                    b.Property<string>("BrakeSystemType");

                    b.Property<string>("BusFloorConfigType");

                    b.Property<string>("BusLength");

                    b.Property<string>("BusType");

                    b.Property<string>("CAN_AACN");

                    b.Property<string>("CIB");

                    b.Property<string>("CashForClunkers");

                    b.Property<string>("ChargerLevel");

                    b.Property<string>("ChargerPowerKW");

                    b.Property<string>("CoolingType");

                    b.Property<string>("CurbWeightLB");

                    b.Property<string>("CustomMotorcycleType");

                    b.Property<string>("DaytimeRunningLight");

                    b.Property<string>("DestinationMarket");

                    b.Property<string>("DisplacementCC");

                    b.Property<string>("DisplacementCI");

                    b.Property<string>("DisplacementL");

                    b.Property<string>("Doors");

                    b.Property<string>("DriveType");

                    b.Property<string>("DriverAssist");

                    b.Property<string>("DynamicBrakeSupport");

                    b.Property<string>("EDR");

                    b.Property<string>("ESC");

                    b.Property<string>("EVDriveUnit");

                    b.Property<string>("ElectrificationLevel");

                    b.Property<string>("EngineConfiguration");

                    b.Property<string>("EngineCycles");

                    b.Property<string>("EngineCylinders");

                    b.Property<string>("EngineHP");

                    b.Property<string>("EngineHP_to");

                    b.Property<string>("EngineKW");

                    b.Property<string>("EngineManufacturer");

                    b.Property<string>("EngineModel");

                    b.Property<string>("EntertainmentSystem");

                    b.Property<string>("ErrorCode");

                    b.Property<string>("ErrorText");

                    b.Property<string>("ForwardCollisionWarning");

                    b.Property<string>("FuelInjectionType");

                    b.Property<string>("FuelTypePrimary");

                    b.Property<string>("FuelTypeSecondary");

                    b.Property<string>("GCWR");

                    b.Property<string>("GCWR_to");

                    b.Property<string>("GVWR");

                    b.Property<string>("GVWR_to");

                    b.Property<string>("KeylessIgnition");

                    b.Property<string>("LaneDepartureWarning");

                    b.Property<string>("LaneKeepSystem");

                    b.Property<string>("LowerBeamHeadlampLightSource");

                    b.Property<string>("Make")
                        .IsRequired();

                    b.Property<string>("Manufacturer");

                    b.Property<string>("ManufacturerId");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<string>("ModelYear")
                        .IsRequired();

                    b.Property<string>("MotorcycleChassisType");

                    b.Property<string>("MotorcycleSuspensionType");

                    b.Property<string>("NCSABodyType");

                    b.Property<string>("NCSAMake");

                    b.Property<string>("NCSAMapExcApprovedBy");

                    b.Property<string>("NCSAMapExcApprovedOn");

                    b.Property<string>("NCSAMappingException");

                    b.Property<string>("NCSAModel");

                    b.Property<string>("NCSANote");

                    b.Property<string>("Note");

                    b.Property<string>("OtherBusInfo");

                    b.Property<string>("OtherEngineInfo");

                    b.Property<string>("OtherMotorcycleInfo");

                    b.Property<string>("OtherRestraintSystemInfo");

                    b.Property<string>("OtherTrailerInfo");

                    b.Property<string>("ParkAssist");

                    b.Property<string>("PedestrianAutomaticEmergencyBraking");

                    b.Property<string>("PlantCity");

                    b.Property<string>("PlantCompanyName");

                    b.Property<string>("PlantCountry");

                    b.Property<string>("PlantState");

                    b.Property<string>("PossibleValues");

                    b.Property<string>("Pretensioner");

                    b.Property<string>("RearCrossTrafficAlert");

                    b.Property<string>("RearVisibilitySystem");

                    b.Property<string>("SAEAutomationLevel");

                    b.Property<string>("SAEAutomationLevel_to");

                    b.Property<string>("SeatBeltsAll");

                    b.Property<string>("SeatRows");

                    b.Property<string>("Seats");

                    b.Property<string>("SemiautomaticHeadlampBeamSwitching");

                    b.Property<string>("Series");

                    b.Property<string>("Series2");

                    b.Property<string>("SteeringLocation");

                    b.Property<string>("SuggestedVIN");

                    b.Property<string>("TPMS");

                    b.Property<string>("TopSpeedMPH");

                    b.Property<string>("TrackWidth");

                    b.Property<string>("TractionControl");

                    b.Property<string>("TrailerBodyType");

                    b.Property<string>("TrailerLength");

                    b.Property<string>("TrailerType");

                    b.Property<string>("TransmissionSpeeds");

                    b.Property<string>("TransmissionStyle");

                    b.Property<string>("Trim");

                    b.Property<string>("Trim2");

                    b.Property<string>("Turbo");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("VIN");

                    b.Property<string>("ValveTrainDesign");

                    b.Property<int>("VehicleMileage");

                    b.Property<string>("VehicleType");

                    b.Property<string>("WheelBaseLong");

                    b.Property<string>("WheelBaseShort");

                    b.Property<string>("WheelBaseType");

                    b.Property<string>("WheelSizeFront");

                    b.Property<string>("WheelSizeRear");

                    b.Property<string>("Wheels");

                    b.Property<string>("Windows");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("LugNutzEnterprize.Models.WishList", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("IsComplete");

                    b.Property<int>("VehicleId");

                    b.Property<string>("WishListDescription")
                        .IsRequired();

                    b.Property<string>("WishListTitle")
                        .IsRequired();

                    b.HasKey("WishListId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
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
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LugNutzEnterprize.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LugNutzEnterprize.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LugNutzEnterprize.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LugNutzEnterprize.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}