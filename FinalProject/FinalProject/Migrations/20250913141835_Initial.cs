using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Audio & Computing", "High-quality audio and computing equipment" },
                    { 2, "Mobile Technology", "Portable tech devices and accessories" },
                    { 3, "Home Essentials", "Essential products for daily home use" },
                    { 4, "Wellness Products", "Products for relaxation and personal care" },
                    { 5, "Clothing", "Comfortable and sustainable clothing" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "john.doe@email.com", "John", "Doe", "John@123" },
                    { 2, "jane.smith@email.com", "Jane", "Smith", "Jane@456" },
                    { 3, "michael.j@email.com", "Michael", "Johnson", "Mike@789" },
                    { 4, "sarah.wilson@email.com", "Sarah", "Wilson", "Sarah#001" },
                    { 5, "david.brown@email.com", "David", "Brown", "David#002" },
                    { 6, "emily.davis@email.com", "Emily", "Davis", "Emily#003" },
                    { 7, "robert.m@email.com", "Robert", "Miller", "Robert#004" },
                    { 8, "lisa.taylor@email.com", "Lisa", "Taylor", "Lisa#005" },
                    { 9, "james.a@email.com", "James", "Anderson", "James#006" },
                    { 10, "maria.g@email.com", "Maria", "Garcia", "Maria#007" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "High-quality wireless headphones with noise cancellation and 20-hour battery life", "", 79.99m, 25, "Wireless Bluetooth Headphones" },
                    { 2, 3, "Double-wall insulated water bottle that keeps drinks cold for 24 hours", "", 24.95m, 50, "Stainless Steel Water Bottle" },
                    { 3, 1, "RGB backlit mechanical keyboard with Cherry MX switches", "", 129.99m, 15, "Mechanical Keyboard" },
                    { 4, 5, "100% organic cotton t-shirt available in multiple colors and sizes", "", 29.99m, 100, "Organic Cotton T-Shirt" },
                    { 5, 4, "Water-resistant fitness tracker with heart rate monitor and sleep tracking", "", 89.99m, 30, "Smart Fitness Tracker" },
                    { 6, 3, "Set of 4 handcrafted ceramic mugs with elegant design", "", 34.99m, 40, "Ceramic Coffee Mug Set" },
                    { 7, 2, "Fast wireless charging pad compatible with Qi-enabled devices", "", 39.99m, 35, "Wireless Phone Charger" },
                    { 8, 4, "Eco-friendly yoga mat with non-slip surface and carrying strap", "", 54.95m, 20, "Yoga Mat Premium" },
                    { 9, 1, "1TB portable SSD with USB-C connectivity and fast transfer speeds", "", 149.99m, 18, "Portable External SSD" },
                    { 10, 4, "Ultrasonic essential oil diffuser with color-changing LED lights", "", 45.99m, 28, "Aromatherapy Diffuser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categorys");
        }
    }
}
