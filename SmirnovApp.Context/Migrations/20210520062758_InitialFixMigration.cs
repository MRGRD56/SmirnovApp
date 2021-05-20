using Microsoft.EntityFrameworkCore.Migrations;

namespace SmirnovApp.Context.Migrations
{
    public partial class InitialFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Clients_ClientId1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Employees_EmployeeId1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Estates_EstateId1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Services_ServiceId1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId1",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_EstateTypes_TypeId",
                table: "Estates");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Owners_OwnerId1",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Estates_OwnerId1",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ClientId1",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_EmployeeId1",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_EstateId1",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ServiceId1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "PositionId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "EstateId1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ServiceId1",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstateId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Estates_OwnerId",
                table: "Estates",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ClientId",
                table: "Contracts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EstateId",
                table: "Contracts",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ServiceId",
                table: "Contracts",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Clients_ClientId",
                table: "Contracts",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Employees_EmployeeId",
                table: "Contracts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Estates_EstateId",
                table: "Contracts",
                column: "EstateId",
                principalTable: "Estates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Services_ServiceId",
                table: "Contracts",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_EstateTypes_TypeId",
                table: "Estates",
                column: "TypeId",
                principalTable: "EstateTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Owners_OwnerId",
                table: "Estates",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Clients_ClientId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Employees_EmployeeId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Estates_EstateId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Services_ServiceId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Positions_PositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_EstateTypes_TypeId",
                table: "Estates");

            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Owners_OwnerId",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Estates_OwnerId",
                table: "Estates");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ClientId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_EstateId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ServiceId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "EstateId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Contracts");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId1",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstateId1",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId1",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estates_OwnerId1",
                table: "Estates",
                column: "OwnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId1",
                table: "Employees",
                column: "PositionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ClientId1",
                table: "Contracts",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId1",
                table: "Contracts",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EstateId1",
                table: "Contracts",
                column: "EstateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ServiceId1",
                table: "Contracts",
                column: "ServiceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Clients_ClientId1",
                table: "Contracts",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Employees_EmployeeId1",
                table: "Contracts",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Estates_EstateId1",
                table: "Contracts",
                column: "EstateId1",
                principalTable: "Estates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Services_ServiceId1",
                table: "Contracts",
                column: "ServiceId1",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Positions_PositionId1",
                table: "Employees",
                column: "PositionId1",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_EstateTypes_TypeId",
                table: "Estates",
                column: "TypeId",
                principalTable: "EstateTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Owners_OwnerId1",
                table: "Estates",
                column: "OwnerId1",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
