using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Komentaro_busenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentaro_busenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mokejimo_busenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mokejimo_busenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prekes_busenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekes_busenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prekes_tipai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekes_tipai", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Statymo_busenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statymo_busenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uzsakymo_busenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzsakymo_busenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vartotojo_tipai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vartotojo_tipai", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    adresas = table.Column<string>(type: "text", nullable: true),
                    ar_aktyvus = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    el_pastas = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pavarde = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slaptazodis = table.Column<string>(type: "text", nullable: false),
                    sukurimo_data = table.Column<DateTime>(type: "datetime", nullable: false),
                    telefonas = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tipas = table.Column<int>(type: "int", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    vardas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK__Vartotoja__tipas__44FF419A",
                        column: x => x.tipas,
                        principalTable: "Vartotojo_tipai",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ivertinimai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    aprasymas = table.Column<string>(type: "text", nullable: false),
                    balas = table.Column<double>(type: "float", nullable: false),
                    fk_pirkejas = table.Column<int>(type: "int", nullable: false),
                    fk_tiekejas = table.Column<int>(type: "int", nullable: false),
                    pavadinimas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ivertinimai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Ivertinim__fk_pi__47DBAE45",
                        column: x => x.fk_pirkejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ivertinim__fk_ti__48CFD27E",
                        column: x => x.fk_tiekejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Preke",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    busena = table.Column<int>(type: "int", nullable: false),
                    fk_tiekejas = table.Column<int>(type: "int", nullable: false),
                    ikelimo_data = table.Column<DateTime>(type: "date", nullable: false),
                    kaina = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    nuolaida = table.Column<double>(type: "float", nullable: false),
                    nuotrauka = table.Column<string>(type: "text", nullable: false),
                    pavadinimas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    tipas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preke", x => x.id);
                    table.ForeignKey(
                        name: "FK__Preke__busena__4CA06362",
                        column: x => x.busena,
                        principalTable: "Prekes_busenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Preke__fk_tiekej__4D94879B",
                        column: x => x.fk_tiekejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Preke__tipas__4BAC3F29",
                        column: x => x.tipas,
                        principalTable: "Prekes_tipai",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uzsakymai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    busena = table.Column<int>(type: "int", nullable: false),
                    fk_pirkejas = table.Column<int>(type: "int", nullable: false),
                    kaina = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    pateikimo_data = table.Column<DateTime>(type: "datetime", nullable: false),
                    uzdarymo_data = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzsakymai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Uzsakymai__busen__5070F446",
                        column: x => x.busena,
                        principalTable: "Uzsakymo_busenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Uzsakymai__fk_pi__5165187F",
                        column: x => x.fk_pirkejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentarai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    busena = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime", nullable: false),
                    fk_preke = table.Column<int>(type: "int", nullable: false),
                    fk_vartotojas = table.Column<int>(type: "int", nullable: false),
                    pavadinimas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    tekstas = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentarai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Komentara__busen__5441852A",
                        column: x => x.busena,
                        principalTable: "Komentaro_busenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Komentara__fk_pr__5629CD9C",
                        column: x => x.fk_preke,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Komentara__fk_va__5535A963",
                        column: x => x.fk_vartotojas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Krepselio_prekes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fk_pirkejas = table.Column<int>(type: "int", nullable: false),
                    fk_preke = table.Column<int>(type: "int", nullable: false),
                    ikelimo_data = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Krepselio_prekes", x => x.id);
                    table.ForeignKey(
                        name: "FK__Krepselio__fk_pi__656C112C",
                        column: x => x.fk_pirkejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Krepselio__fk_pr__66603565",
                        column: x => x.fk_preke,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prekes_aprasymo_laukai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    aprasymas = table.Column<string>(type: "text", nullable: false),
                    fk_preke = table.Column<int>(type: "int", nullable: false),
                    laukas = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekes_aprasymo_laukai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Prekes_ap__fk_pr__6E01572D",
                        column: x => x.fk_preke,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statymai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    busena = table.Column<int>(type: "int", nullable: false),
                    fk_Pirkejasid = table.Column<int>(type: "int", nullable: false),
                    fk_Prekeid = table.Column<int>(type: "int", nullable: false),
                    statymo_data = table.Column<DateTime>(type: "datetime", nullable: false),
                    suma = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    uzdarymo_data = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statymai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Statymai__busena__59063A47",
                        column: x => x.busena,
                        principalTable: "Statymo_busenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Statymai__fk_Pir__59FA5E80",
                        column: x => x.fk_Pirkejasid,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Statymai__fk_Pre__5AEE82B9",
                        column: x => x.fk_Prekeid,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stebimos_prekes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fk_preke = table.Column<int>(type: "int", nullable: false),
                    fk_prikejas = table.Column<int>(type: "int", nullable: false),
                    ikelimo_data = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stebimos_prekes", x => x.id);
                    table.ForeignKey(
                        name: "FK__Stebimos___fk_pr__5EBF139D",
                        column: x => x.fk_preke,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Stebimos___fk_pr__5DCAEF64",
                        column: x => x.fk_prikejas,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mokejimai",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    busena = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime", nullable: false),
                    fk_uzsakymas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mokejimai", x => x.id);
                    table.ForeignKey(
                        name: "FK__Mokejimai__busen__6A30C649",
                        column: x => x.busena,
                        principalTable: "Mokejimo_busenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Mokejimai__fk_uz__6B24EA82",
                        column: x => x.fk_uzsakymas,
                        principalTable: "Uzsakymai",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uzsakymo_prekes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fk_preke = table.Column<int>(type: "int", nullable: false),
                    fk_uzsakymas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzsakymo_prekes", x => x.id);
                    table.ForeignKey(
                        name: "FK__Uzsakymo___fk_pr__619B8048",
                        column: x => x.fk_preke,
                        principalTable: "Preke",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Uzsakymo___fk_uz__628FA481",
                        column: x => x.fk_uzsakymas,
                        principalTable: "Uzsakymai",
                        principalColumn: "id",
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_tipas",
                table: "AspNetUsers",
                column: "tipas");

            migrationBuilder.CreateIndex(
                name: "IX_Ivertinimai_fk_pirkejas",
                table: "Ivertinimai",
                column: "fk_pirkejas");

            migrationBuilder.CreateIndex(
                name: "IX_Ivertinimai_fk_tiekejas",
                table: "Ivertinimai",
                column: "fk_tiekejas");

            migrationBuilder.CreateIndex(
                name: "IX_Komentarai_busena",
                table: "Komentarai",
                column: "busena");

            migrationBuilder.CreateIndex(
                name: "IX_Komentarai_fk_preke",
                table: "Komentarai",
                column: "fk_preke");

            migrationBuilder.CreateIndex(
                name: "IX_Komentarai_fk_vartotojas",
                table: "Komentarai",
                column: "fk_vartotojas");

            migrationBuilder.CreateIndex(
                name: "IX_Krepselio_prekes_fk_pirkejas",
                table: "Krepselio_prekes",
                column: "fk_pirkejas");

            migrationBuilder.CreateIndex(
                name: "IX_Krepselio_prekes_fk_preke",
                table: "Krepselio_prekes",
                column: "fk_preke");

            migrationBuilder.CreateIndex(
                name: "IX_Mokejimai_busena",
                table: "Mokejimai",
                column: "busena");

            migrationBuilder.CreateIndex(
                name: "UQ__Mokejima__A4D84B9F0267F94B",
                table: "Mokejimai",
                column: "fk_uzsakymas",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preke_busena",
                table: "Preke",
                column: "busena");

            migrationBuilder.CreateIndex(
                name: "IX_Preke_fk_tiekejas",
                table: "Preke",
                column: "fk_tiekejas");

            migrationBuilder.CreateIndex(
                name: "IX_Preke_tipas",
                table: "Preke",
                column: "tipas");

            migrationBuilder.CreateIndex(
                name: "IX_Prekes_aprasymo_laukai_fk_preke",
                table: "Prekes_aprasymo_laukai",
                column: "fk_preke");

            migrationBuilder.CreateIndex(
                name: "IX_Statymai_busena",
                table: "Statymai",
                column: "busena");

            migrationBuilder.CreateIndex(
                name: "IX_Statymai_fk_Pirkejasid",
                table: "Statymai",
                column: "fk_Pirkejasid");

            migrationBuilder.CreateIndex(
                name: "IX_Statymai_fk_Prekeid",
                table: "Statymai",
                column: "fk_Prekeid");

            migrationBuilder.CreateIndex(
                name: "IX_Stebimos_prekes_fk_preke",
                table: "Stebimos_prekes",
                column: "fk_preke");

            migrationBuilder.CreateIndex(
                name: "IX_Stebimos_prekes_fk_prikejas",
                table: "Stebimos_prekes",
                column: "fk_prikejas");

            migrationBuilder.CreateIndex(
                name: "IX_Uzsakymai_busena",
                table: "Uzsakymai",
                column: "busena");

            migrationBuilder.CreateIndex(
                name: "IX_Uzsakymai_fk_pirkejas",
                table: "Uzsakymai",
                column: "fk_pirkejas");

            migrationBuilder.CreateIndex(
                name: "IX_Uzsakymo_prekes_fk_preke",
                table: "Uzsakymo_prekes",
                column: "fk_preke");

            migrationBuilder.CreateIndex(
                name: "IX_Uzsakymo_prekes_fk_uzsakymas",
                table: "Uzsakymo_prekes",
                column: "fk_uzsakymas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "Ivertinimai");

            migrationBuilder.DropTable(
                name: "Komentarai");

            migrationBuilder.DropTable(
                name: "Krepselio_prekes");

            migrationBuilder.DropTable(
                name: "Mokejimai");

            migrationBuilder.DropTable(
                name: "Prekes_aprasymo_laukai");

            migrationBuilder.DropTable(
                name: "Statymai");

            migrationBuilder.DropTable(
                name: "Stebimos_prekes");

            migrationBuilder.DropTable(
                name: "Uzsakymo_prekes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Komentaro_busenos");

            migrationBuilder.DropTable(
                name: "Mokejimo_busenos");

            migrationBuilder.DropTable(
                name: "Statymo_busenos");

            migrationBuilder.DropTable(
                name: "Preke");

            migrationBuilder.DropTable(
                name: "Uzsakymai");

            migrationBuilder.DropTable(
                name: "Prekes_busenos");

            migrationBuilder.DropTable(
                name: "Prekes_tipai");

            migrationBuilder.DropTable(
                name: "Uzsakymo_busenos");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Vartotojo_tipai");
        }
    }
}
