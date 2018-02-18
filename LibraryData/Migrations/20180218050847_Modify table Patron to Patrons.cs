using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class ModifytablePatrontoPatrons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryBranches_HomeLibraryBranchId",
                table: "Patron");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryCards_LibraryCardId",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patron",
                table: "Patron");

            migrationBuilder.RenameTable(
                name: "Patron",
                newName: "Patrons");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_LibraryCardId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patron");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patron",
                newName: "IX_Patron_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patron",
                newName: "IX_Patron_HomeLibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patron",
                table: "Patron",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryBranches_HomeLibraryBranchId",
                table: "Patron",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryCards_LibraryCardId",
                table: "Patron",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
