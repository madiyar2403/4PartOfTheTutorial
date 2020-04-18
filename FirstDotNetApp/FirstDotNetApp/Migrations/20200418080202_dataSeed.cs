using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondDotNetApp.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -1, "Todd Phillips", new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime , Drama , Thriller", "Joker", "https://www.kinopoisk.ru/images/film_big/1048334.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -2, "David Leitch", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action , Adventure", "Fast & Furious Presents: Hobbs & Shaw", "https://www.eventsonglobe.com/wp-content/uploads/2019/11/Fast-Furious-Presents-Hobbs-and-Shaw-HD-1080p-Download.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -3, "Jon Favreau", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Animation , Drama , Family , Musical", "The Lion King", "https://i0.wp.com/itc.ua/wp-content/uploads/2019/07/oblozhka-4.jpg?fit=1280%2C800&quality=100&strip=all&ssl=1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -4, "Joachim Rønning", new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Family , Fantasy", "Maleficent: Mistress of Evil", "https://is1-ssl.mzstatic.com/image/thumb/Video123/v4/bb/82/fd/bb82fd41-0c5b-2380-7757-7246c9e48600/DIS_MAL2UAE_CENS_WW_WW_ARTWORK_EN_0x0_1YRWNX000000GS.lsr/268x0w.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
