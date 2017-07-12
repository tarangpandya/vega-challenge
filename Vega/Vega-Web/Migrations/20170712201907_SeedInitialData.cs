using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VegaWeb.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Audi')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Tesla')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Mercedez')");

            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('Q5', (Select ID from Makes where Name = 'Audi'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('Q7',(Select ID from Makes where Name = 'Audi'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('R8',(Select ID from Makes where Name = 'Audi'))");

            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('Model X',(Select ID from Makes where Name = 'Tesla'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('Model 3',(Select ID from Makes where Name = 'Tesla'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('Model Y',(Select ID from Makes where Name = 'Tesla'))");

            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('GLE 350',(Select ID from Makes where Name = 'Mercedez'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('GLS 550',(Select ID from Makes where Name = 'Mercedez'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeID) Values ('GLS 450',(Select ID from Makes where Name = 'Mercedez'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.Sql("Delete from Makes");
        }
    }
}
