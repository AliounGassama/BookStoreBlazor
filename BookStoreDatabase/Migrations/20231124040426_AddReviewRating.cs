﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewRating",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewRating",
                table: "Reviews");
        }
    }
}
