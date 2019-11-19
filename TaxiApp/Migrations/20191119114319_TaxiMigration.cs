using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxiApp.Migrations
{
    public partial class TaxiMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumberPhone = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumberCar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    PhoneClient = table.Column<string>(nullable: true),
                    NumberCar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Latitude", "Longitude", "NumberPhone" },
                values: new object[,]
                {
                    { new Guid("5728e22d-764f-4c2d-8261-88dd9dea3b19"), 20.5, 70.400000000000006, "+4654651487" },
                    { new Guid("e0834afb-bb26-4351-adcb-22d7bca64fb6"), 74.799999999999997, 73.099999999999994, "+9856489724" },
                    { new Guid("dac33980-9e9f-4b9b-8d06-e7116d454687"), 12.699999999999999, 60.200000000000003, "+4684654878" },
                    { new Guid("892de076-036e-4a90-8c7f-380bade72b07"), 68.120000000000005, 52.409999999999997, "+6874545582" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "NumberCar" },
                values: new object[,]
                {
                    { new Guid("558cdddb-9b5d-4328-89b4-86e0b05763c1"), "875AKW" },
                    { new Guid("e4a30b61-5cd6-4f73-bb18-dd16461c4dd7"), "824ODQ" },
                    { new Guid("0b28c25e-fcfc-40e7-a30d-6c16ffaa131c"), "184UEN" },
                    { new Guid("c4357dc2-1175-4eac-a945-4ce5ad724c3f"), "461LEN" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "NumberCar", "PhoneClient", "State" },
                values: new object[,]
                {
                    { new Guid("72494704-82c3-44bf-bae4-b5e8cf185474"), "824ODQ", "+9856489724", "Waiting" },
                    { new Guid("77226738-eee7-4403-bb25-c9d451348449"), "461LEN", "+4654651487", "InProcess" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
