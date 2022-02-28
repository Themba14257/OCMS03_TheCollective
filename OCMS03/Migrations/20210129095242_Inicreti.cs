using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OCMS03.Migrations
{
    public partial class Inicreti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AP",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Apr",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "AU",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Aug",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AUGU",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DE",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dec",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DEC",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FE",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Feb",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FR",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JA",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Jan",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JL",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JN",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JR",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JU",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Jul",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "JUL",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Jun",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Mar",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MAR",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "May",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MR",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MY",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "NO",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Nov",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "NOV",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OC",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Oct",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OCT",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SE",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sep",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SEPT",
            //    columns: table => new
            //    {
            //        Total = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            migrationBuilder.CreateTable(
                name: "tblClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMedication",
                columns: table => new
                {
                    MedicationId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    RegistryNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActiveIngredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthOrPacksize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityAndLimitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMedication", x => x.MedicationId);
                });

            migrationBuilder.CreateTable(
                name: "tblProvince",
                columns: table => new
                {
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    ProvinceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProvince", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "tblWalkIn",
                columns: table => new
                {
                    WalkInId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Idnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextOfKinSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NextOfKinNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VistingTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblWalkIn", x => x.WalkInId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDistrict",
                columns: table => new
                {
                    DistrictId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    DistrictName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDistrict", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_tblDistrict_tblProvince",
                        column: x => x.ProvinceId,
                        principalTable: "tblProvince",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    CityId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_tblCity_tblDistrict_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "tblDistrict",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClinic",
                columns: table => new
                {
                    ClinicId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    ClinicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClinic", x => x.ClinicId);
                    table.ForeignKey(
                        name: "FK_tblClinic_tblCity",
                        column: x => x.CityId,
                        principalTable: "tblCity",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblClinic_tblProvince",
                        column: x => x.ProvinceId,
                        principalTable: "tblProvince",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblHospital",
                columns: table => new
                {
                    HospitalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    HospitalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHospital", x => x.HospitalId);
                    table.ForeignKey(
                        name: "FK_tblHospital_tblCity",
                        column: x => x.CityId,
                        principalTable: "tblCity",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblHospital_tblProvince",
                        column: x => x.ProvinceId,
                        principalTable: "tblProvince",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HospitalId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartment", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_tblDepartment_tblHospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospital",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Idnumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HospitalId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClinicId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProvinceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    NextOfName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NextOfKinSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NextOfKinNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    IsResetPasswordRequired = table.Column<bool>(type: "bit", nullable: true),
                    UserStatus = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tblCity_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCity",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tblClinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "tblClinic",
                        principalColumn: "ClinicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tblDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tblHospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospital",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_tblProvince_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "tblProvince",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAllergy",
                columns: table => new
                {
                    AllergyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    AllergyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAllergy", x => x.AllergyId);
                    table.ForeignKey(
                        name: "FK_tblAllergy_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPatient_Medication",
                columns: table => new
                {
                    Patient_MedsId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PharmacistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedsReceived = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatient_Medication", x => x.Patient_MedsId);
                    table.ForeignKey(
                        name: "FK_tblPatient_Medication_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPatient_Medication_AspNetUsers_PharmacistId",
                        column: x => x.PharmacistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPatientVitals",
                columns: table => new
                {
                    VitalsId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pulse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepertoryRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PainScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPO2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatientVitals", x => x.VitalsId);
                    table.ForeignKey(
                        name: "FK_tblPatientVitals_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPatientVitals_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPrescription",
                columns: table => new
                {
                    PrescriptionId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PharmacistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StaffId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrescriptionNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SeenByPharmacist = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPrescription", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_tblPrescription_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPrescription_AspNetUsers_PharmacistId",
                        column: x => x.PharmacistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPrescription_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblReferral",
                columns: table => new
                {
                    ReferralId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferalDescriptin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblReferral", x => x.ReferralId);
                    table.ForeignKey(
                        name: "FK_tblReferral_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblReferral_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblReferral_tblDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblWalkInApp",
                columns: table => new
                {
                    WalkInId_AppointmentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClinicId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    WalkInId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NurseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PatientNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblWalkInApp", x => x.WalkInId_AppointmentId);
                    table.ForeignKey(
                        name: "FK_tblWalkInApp_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblWalkInApp_AspNetUsers_NurseId",
                        column: x => x.NurseId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblWalkInApp_tblClinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "tblClinic",
                        principalColumn: "ClinicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblWalkInApp_tblHospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospital",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPatientAllergyDiagnosis",
                columns: table => new
                {
                    PatientAllergyDiagnosisId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    CheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllergyId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PhysicalExamNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyDiagnoseTestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergySymptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatientAllergyDiagnosis", x => x.PatientAllergyDiagnosisId);
                    table.ForeignKey(
                        name: "FK_tblPatientAllergyDiagnosis_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPatientAllergyDiagnosis_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblPatientAllergyDiagnosis_tblAllergy_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "tblAllergy",
                        principalColumn: "AllergyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCartLine",
                columns: table => new
                {
                    Patient_PrescriptionId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morning = table.Column<bool>(type: "bit", nullable: false),
                    Afternoon = table.Column<bool>(type: "bit", nullable: false),
                    Evening = table.Column<bool>(type: "bit", nullable: false),
                    PrescriptionId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    MedicationId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Patient_MedicationPatient_MedsId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCartLine", x => x.Patient_PrescriptionId);
                    table.ForeignKey(
                        name: "FK_tblCartLine_tblMedication_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "tblMedication",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCartLine_tblPatient_Medication_Patient_MedicationPatient_MedsId",
                        column: x => x.Patient_MedicationPatient_MedsId,
                        principalTable: "tblPatient_Medication",
                        principalColumn: "Patient_MedsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblCartLine_tblPrescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "tblPrescription",
                        principalColumn: "PrescriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblAppointment",
                columns: table => new
                {
                    AppointmentId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AppointmentDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    isConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NurseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HospitalId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ClinicId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    apptStatus = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkIn_AppointmentWalkInId_AppointmentId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAppointment", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_tblAppointment_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAppointment_AspNetUsers_NurseId",
                        column: x => x.NurseId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAppointment_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAppointment_tblClinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "tblClinic",
                        principalColumn: "ClinicId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblAppointment_tblHospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospital",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblAppointment_tblWalkInApp_WalkIn_AppointmentWalkInId_AppointmentId",
                        column: x => x.WalkIn_AppointmentWalkInId_AppointmentId,
                        principalTable: "tblWalkInApp",
                        principalColumn: "WalkInId_AppointmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblDiagnosis",
                columns: table => new
                {
                    DiagnosisCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(newid())"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExaminationNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DepartmentId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDiagnosis", x => x.DiagnosisCode);
                    table.ForeignKey(
                        name: "FK_tblDiagnosis_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblDiagnosis_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblDiagnosis_tblAppointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "tblAppointment",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblDiagnosis_tblDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClinicId",
                table: "AspNetUsers",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HospitalId",
                table: "AspNetUsers",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProvinceId",
                table: "AspNetUsers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblAllergy_ApplicationUserId",
                table: "tblAllergy",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_ClinicId",
                table: "tblAppointment",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_DoctorId",
                table: "tblAppointment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_HospitalId",
                table: "tblAppointment",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_NurseId",
                table: "tblAppointment",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_PatientId",
                table: "tblAppointment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblAppointment_WalkIn_AppointmentWalkInId_AppointmentId",
                table: "tblAppointment",
                column: "WalkIn_AppointmentWalkInId_AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCartLine_MedicationId",
                table: "tblCartLine",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCartLine_Patient_MedicationPatient_MedsId",
                table: "tblCartLine",
                column: "Patient_MedicationPatient_MedsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCartLine_PrescriptionId",
                table: "tblCartLine",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCity_DistrictId",
                table: "tblCity",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_tblClinic_CityId",
                table: "tblClinic",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblClinic_ProvinceId",
                table: "tblClinic",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDepartment_HospitalId",
                table: "tblDepartment",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiagnosis_AppointmentId",
                table: "tblDiagnosis",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiagnosis_DepartmentId",
                table: "tblDiagnosis",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiagnosis_PatientId",
                table: "tblDiagnosis",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiagnosis_StaffId",
                table: "tblDiagnosis",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDistrict_ProvinceId",
                table: "tblDistrict",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospital_CityId",
                table: "tblHospital",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospital_ProvinceId",
                table: "tblHospital",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatient_Medication_PatientId",
                table: "tblPatient_Medication",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatient_Medication_PharmacistId",
                table: "tblPatient_Medication",
                column: "PharmacistId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientAllergyDiagnosis_AllergyId",
                table: "tblPatientAllergyDiagnosis",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientAllergyDiagnosis_PatientId",
                table: "tblPatientAllergyDiagnosis",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientAllergyDiagnosis_StaffId",
                table: "tblPatientAllergyDiagnosis",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientVitals_PatientId",
                table: "tblPatientVitals",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientVitals_StaffId",
                table: "tblPatientVitals",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescription_PatientId",
                table: "tblPrescription",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescription_PharmacistId",
                table: "tblPrescription",
                column: "PharmacistId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescription_StaffId",
                table: "tblPrescription",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tblReferral_DepartmentId",
                table: "tblReferral",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblReferral_PatientId",
                table: "tblReferral",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_tblReferral_StaffId",
                table: "tblReferral",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWalkInApp_ClinicId",
                table: "tblWalkInApp",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWalkInApp_DoctorId",
                table: "tblWalkInApp",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWalkInApp_HospitalId",
                table: "tblWalkInApp",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tblWalkInApp_NurseId",
                table: "tblWalkInApp",
                column: "NurseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AP");

            //migrationBuilder.DropTable(
            //    name: "Apr");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "AU");

            //migrationBuilder.DropTable(
            //    name: "Aug");

            //migrationBuilder.DropTable(
            //    name: "AUGU");

            //migrationBuilder.DropTable(
            //    name: "DE");

            //migrationBuilder.DropTable(
            //    name: "Dec");

            //migrationBuilder.DropTable(
            //    name: "DEC");

            //migrationBuilder.DropTable(
            //    name: "FE");

            //migrationBuilder.DropTable(
            //    name: "Feb");

            //migrationBuilder.DropTable(
            //    name: "FR");

            //migrationBuilder.DropTable(
            //    name: "JA");

            //migrationBuilder.DropTable(
            //    name: "Jan");

            //migrationBuilder.DropTable(
            //    name: "JL");

            //migrationBuilder.DropTable(
            //    name: "JN");

            //migrationBuilder.DropTable(
            //    name: "JR");

            //migrationBuilder.DropTable(
            //    name: "JU");

            //migrationBuilder.DropTable(
            //    name: "Jul");

            //migrationBuilder.DropTable(
            //    name: "JUL");

            //migrationBuilder.DropTable(
            //    name: "Jun");

            //migrationBuilder.DropTable(
            //    name: "Mar");

            //migrationBuilder.DropTable(
            //    name: "MAR");

            //migrationBuilder.DropTable(
            //    name: "May");

            //migrationBuilder.DropTable(
            //    name: "MR");

            //migrationBuilder.DropTable(
            //    name: "MY");

            //migrationBuilder.DropTable(
            //    name: "NO");

            //migrationBuilder.DropTable(
            //    name: "Nov");

            //migrationBuilder.DropTable(
            //    name: "NOV");

            //migrationBuilder.DropTable(
            //    name: "OC");

            //migrationBuilder.DropTable(
            //    name: "Oct");

            //migrationBuilder.DropTable(
            //    name: "OCT");

            //migrationBuilder.DropTable(
            //    name: "SE");

            //migrationBuilder.DropTable(
            //    name: "Sep");

            //migrationBuilder.DropTable(
            //    name: "SEPT");

            migrationBuilder.DropTable(
                name: "tblCartLine");

            migrationBuilder.DropTable(
                name: "tblClaims");

            migrationBuilder.DropTable(
                name: "tblDiagnosis");

            migrationBuilder.DropTable(
                name: "tblPatientAllergyDiagnosis");

            migrationBuilder.DropTable(
                name: "tblPatientVitals");

            migrationBuilder.DropTable(
                name: "tblReferral");

            migrationBuilder.DropTable(
                name: "tblWalkIn");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tblMedication");

            migrationBuilder.DropTable(
                name: "tblPatient_Medication");

            migrationBuilder.DropTable(
                name: "tblPrescription");

            migrationBuilder.DropTable(
                name: "tblAppointment");

            migrationBuilder.DropTable(
                name: "tblAllergy");

            migrationBuilder.DropTable(
                name: "tblWalkInApp");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tblClinic");

            migrationBuilder.DropTable(
                name: "tblDepartment");

            migrationBuilder.DropTable(
                name: "tblHospital");

            migrationBuilder.DropTable(
                name: "tblCity");

            migrationBuilder.DropTable(
                name: "tblDistrict");

            migrationBuilder.DropTable(
                name: "tblProvince");
        }
    }
}
