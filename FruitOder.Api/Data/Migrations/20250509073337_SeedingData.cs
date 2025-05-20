using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FruitOder.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Credit",
                table: "Category",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Credit", "Image", "Name", "ParentId" },
                values: new object[,]
                {
                    { (short)1, "Photo by <a href=\"https://unsplash.com/@juliazolotova?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Julia Zolotova</a> on <a href=\"https://unsplash.com/photos/M_xIaxQE3Ms?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "fruits.png", "Fruits", (short)0 },
                    { (short)2, "Photo by <a href=\"https://unsplash.com/@rejaul_creativedesign?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rejaul Karim</a> on <a href=\"https://unsplash.com/photos/uI3SmaQeu6o?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "seasonal_fruits.png", "Seasonal Fruits", (short)1 },
                    { (short)3, "Photo by <a href=\"https://unsplash.com/@alschim?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Alexander Schimmeck</a> on <a href=\"https://unsplash.com/photos/9YVh9yQvvvk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "exotic_fruits.png", "Exotic Fruits", (short)1 },
                    { (short)4, "Photo by <a href=\"https://unsplash.com/@marisolbenitez?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Marisol Benitez</a> on <a href=\"https://unsplash.com/photos/QvkAQTNj4zk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "vegetables.png", "Vegetables", (short)0 },
                    { (short)5, "Photo by Viktoria  Slowikowska: https://www.pexels.com/photo/sweet-corn-and-green-vegetables-on-blue-surface-5678106/", "green_vegetables.png", "Green Vegetables", (short)4 },
                    { (short)6, "Photo by <a href=\"https://unsplash.com/@woonsa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Soo Ann Woon</a> on <a href=\"https://unsplash.com/photos/0l_NXp3StHE?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "leafy_vegetables.png", "Leafy Vegetables", (short)4 },
                    { (short)7, "Photo by <a href=\"https://unsplash.com/@nadineprimeau?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Nadine Primeau</a> on <a href=\"https://unsplash.com/photos/-ftWfohtjNw?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "salads.png", "Salads", (short)4 },
                    { (short)8, "Photo by <a href=\"https://unsplash.com/@picoftasty?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mae Mu</a> on <a href=\"https://unsplash.com/photos/ru4jyDiLHsI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "dairy.png", "Dairy", (short)0 },
                    { (short)9, "Photo by <a href=\"https://unsplash.com/@mehrshadr?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mehrshad Rajabi</a> on <a href=\"https://unsplash.com/photos/P7MkoYvSnLI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "milk_curd_yogurt.png", "Milk, Curd & Yogurts", (short)8 },
                    { (short)10, "Photo by Elle Hughes: https://www.pexels.com/photo/three-assorted-varieties-of-cheese-near-tableknife-1963288/", "butter_cheese.png", "Butter & Cheese", (short)8 },
                    { (short)11, "Photo by <a href=\"https://unsplash.com/@rudy_issa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rudy Issa</a> on <a href=\"https://unsplash.com/photos/KVacTm0QeEA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "eggs_meat.png", "Eggs & Meat", (short)0 },
                    { (short)12, "Photo by <a href=\"https://unsplash.com/@erol?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Erol Ahmed</a> on <a href=\"https://unsplash.com/photos/leOh1CzRZVQ?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "eggs.png", "Eggs", (short)11 },
                    { (short)13, "Photo by <a href=\"https://unsplash.com/@shootdelicious?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Eiliv Aceron</a> on <a href=\"https://unsplash.com/photos/AQ_BdsvLgqA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "meat.png", "Meat", (short)11 },
                    { (short)14, "Photo by <a href=\"https://unsplash.com/pt-br/@maxmota?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Max Mota</a> on <a href=\"https://unsplash.com/photos/N6BTNbaKZMo?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText", "seafood.png", "Seafood", (short)11 }
                });

            migrationBuilder.InsertData(
                table: "Offer",
                columns: new[] { "Id", "BgColor", "Code", "Description", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1L, "#FF8282", "FRT30", "Enjoy upto 30% off on all fruits", false, "Upto 30% OFF" },
                    { 2L, "#DBFFCB", "50OFF", "Enjoy our big offer 50% off", false, "Green Veg Big sale 50% OFF" },
                    { 3L, "#BEE4D0", "EXT100", "Flat 100 off all exotic fruits", false, "Flat 100 OFF" },
                    { 4L, "#E195AB", "FRT25", "Enjoy 25% off on seasonal fruits", false, "25% OFF on Seasonal Fruits" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)14);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.AlterColumn<string>(
                name: "Credit",
                table: "Category",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);
        }
    }
}
