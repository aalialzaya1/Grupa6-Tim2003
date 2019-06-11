using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LetUsBringYourHomeStyle.Migrations
{
    public partial class Migracije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Dimenzija",
                columns: table => new
                {
                    DimenzijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Visina = table.Column<double>(nullable: false),
                    Duzina = table.Column<double>(nullable: false),
                    Sirina = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimenzija", x => x.DimenzijaID);
                });

            migrationBuilder.CreateTable(
                name: "homeStyle",
                columns: table => new
                {
                    homeStyleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjektStanje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homeStyle", x => x.homeStyleID);
                });

            migrationBuilder.CreateTable(
                name: "Popust",
                columns: table => new
                {
                    PopustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistrovaniKorisnikID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Postotak = table.Column<double>(nullable: false),
                    Pocetak = table.Column<DateTime>(nullable: false),
                    Kraj = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popust", x => x.PopustID);
                });

            migrationBuilder.CreateTable(
                name: "Savjet",
                columns: table => new
                {
                    SavjetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    //kategorija = table.Column<int>(nullable: false),
                    KategorijaID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Kategorija = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Savjet", x => x.SavjetID);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    FirmaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    homeStyleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.FirmaID);
                    table.ForeignKey(
                        name: "FK_Firma_homeStyle_homeStyleID",
                        column: x => x.homeStyleID,
                        principalTable: "homeStyle",
                        principalColumn: "homeStyleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrovaniKorisnik",
                columns: table => new
                {
                    RegistrovaniKorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PopustID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    homeStyleID = table.Column<int>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrovaniKorisnik", x => x.RegistrovaniKorisnikID);
                    table.ForeignKey(
                        name: "FK_RegistrovaniKorisnik_homeStyle_homeStyleID",
                        column: x => x.homeStyleID,
                        principalTable: "homeStyle",
                        principalColumn: "homeStyleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Namjestaj",
                columns: table => new
                {
                    NamjestajID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PopustID1 = table.Column<int>(nullable: true),
                    Kategorija = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    Stil = table.Column<string>(nullable: true),
                    Materijal = table.Column<string>(nullable: true),
                    Dezen = table.Column<string>(nullable: true),
                    DimenzijaID1 = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Namjestaj", x => x.NamjestajID);
                    table.ForeignKey(
                        name: "FK_Namjestaj_Dimenzija_DimenzijaID1",
                        column: x => x.DimenzijaID1,
                        principalTable: "Dimenzija",
                        principalColumn: "DimenzijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Namjestaj_Popust_PopustID1",
                        column: x => x.PopustID1,
                        principalTable: "Popust",
                        principalColumn: "PopustID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    RecenzijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikRegistrovaniKorisnikID = table.Column<int>(nullable: true),
                    Komentar = table.Column<string>(nullable: true),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.RecenzijaID);
                    table.ForeignKey(
                        name: "FK_Recenzija_RegistrovaniKorisnik_KorisnikRegistrovaniKorisnikID",
                        column: x => x.KorisnikRegistrovaniKorisnikID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "RegistrovaniKorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Firma_homeStyleID",
                table: "Firma",
                column: "homeStyleID");

            migrationBuilder.CreateIndex(
                name: "IX_Namjestaj_DimenzijaID1",
                table: "Namjestaj",
                column: "DimenzijaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Namjestaj_PopustID1",
                table: "Namjestaj",
                column: "PopustID1");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KorisnikRegistrovaniKorisnikID",
                table: "Recenzija",
                column: "KorisnikRegistrovaniKorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrovaniKorisnik_homeStyleID",
                table: "RegistrovaniKorisnik",
                column: "homeStyleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Namjestaj");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Savjet");

            migrationBuilder.DropTable(
                name: "Dimenzija");

            migrationBuilder.DropTable(
                name: "Popust");

            migrationBuilder.DropTable(
                name: "RegistrovaniKorisnik");

            migrationBuilder.DropTable(
                name: "homeStyle");
        }
    }
}
