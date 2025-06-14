﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderFood.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Coupons",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Coupons");
        }
    }
}
