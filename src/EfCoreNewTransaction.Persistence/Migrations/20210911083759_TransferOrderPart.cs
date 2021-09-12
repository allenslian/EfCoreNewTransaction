using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreNewTransaction.Persistence.Migrations
{
    public partial class TransferOrderPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transfer_order",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order_no = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    step = table.Column<short>(type: "smallint", nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    payer_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    payer_account_no = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    payer_account_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    total_amount = table.Column<decimal>(type: "money", nullable: false),
                    biz_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    web_hook_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    is_online = table.Column<bool>(type: "bit", nullable: false),
                    date_created = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    date_modified = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    modified_by = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_transfer_order_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "transfer_order_detail",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<long>(type: "bigint", nullable: false),
                    operation = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    payee_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    payee_account_no = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    payee_account_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    amount = table.Column<decimal>(type: "money", nullable: false),
                    step = table.Column<short>(type: "smallint", nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: true),
                    status_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    is_agent = table.Column<bool>(type: "bit", nullable: false),
                    biz_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    date_created = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    date_modified = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    modified_by = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_transfer_order_detail_id", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_transfer_order_order_id",
                table: "transfer_order",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "ix_transfer_order_detail_order_id",
                table: "transfer_order_detail",
                column: "order_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transfer_order");

            migrationBuilder.DropTable(
                name: "transfer_order_detail");
        }
    }
}
