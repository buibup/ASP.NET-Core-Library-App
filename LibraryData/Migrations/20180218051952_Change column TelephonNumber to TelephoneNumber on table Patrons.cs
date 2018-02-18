using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class ChangecolumnTelephonNumbertoTelephoneNumberontablePatrons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelephonNumber",
                table: "Patrons",
                newName: "TelephoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelephoneNumber",
                table: "Patrons",
                newName: "TelephonNumber");
        }
    }
}
