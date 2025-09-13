using FinalProject.Models;
namespace FinalProject.ApplicationContaxt
{
    public class Reposetory
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { UserId= 1, FirstName = "John", LastName = "Doe", Email = "john.doe@email.com", Password = "John@123" },
                new User { UserId= 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@email.com", Password = "Jane@456" },
                new User { UserId= 3, FirstName = "Michael", LastName = "Johnson", Email = "michael.j@email.com", Password = "Mike@789" },
                new User { UserId= 4, FirstName = "Sarah", LastName = "Wilson", Email = "sarah.wilson@email.com", Password = "Sarah#001" },
                new User { UserId= 5, FirstName = "David", LastName = "Brown", Email = "david.brown@email.com", Password = "David#002" },
                new User { UserId= 6, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@email.com", Password = "Emily#003" },
                new User { UserId= 7, FirstName = "Robert", LastName = "Miller", Email = "robert.m@email.com", Password = "Robert#004" },
                new User { UserId= 8, FirstName = "Lisa", LastName = "Taylor", Email = "lisa.taylor@email.com", Password = "Lisa#005" },
                new User { UserId= 9, FirstName = "James", LastName = "Anderson", Email = "james.a@email.com", Password = "James#006" },
                new User { UserId= 10, FirstName = "Maria", LastName = "Garcia", Email = "maria.g@email.com", Password = "Maria#007" }

            };
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
{
                new Product     //1 
                {
                    ProductId= 1,
                    Title = "Wireless Bluetooth Headphones",
                    Price = 79.99m,
                    Description = "High-quality wireless headphones with noise cancellation and 20-hour battery life",
                    Quantity = 25,
                    ImagePath = "",
                    CategoryId = 1
                },
                new Product     //2
                {
                    ProductId= 2,
                    Title = "Stainless Steel Water Bottle",
                    Price = 24.95m,
                    Description = "Double-wall insulated water bottle that keeps drinks cold for 24 hours",
                    Quantity = 50,
                    ImagePath = "",
                    CategoryId = 3
                },
                new Product     //3
                {
                    ProductId= 3,
                    Title = "Mechanical Keyboard",
                    Price = 129.99m,
                    Description = "RGB backlit mechanical keyboard with Cherry MX switches",
                    Quantity = 15,
                    ImagePath = "",
                    CategoryId = 1
                },
                new Product     //4
                {
                    ProductId= 4,
                    Title = "Organic Cotton T-Shirt",
                    Price = 29.99m,
                    Description = "100% organic cotton t-shirt available in multiple colors and sizes",
                    Quantity = 100,
                    ImagePath = "",
                    CategoryId = 5
                },
                new Product     //5
                {
                    ProductId= 5,
                    Title = "Smart Fitness Tracker",
                    Price = 89.99m,
                    Description = "Water-resistant fitness tracker with heart rate monitor and sleep tracking",
                    Quantity = 30,
                    ImagePath = "",
                    CategoryId = 4
                },
                new Product     //6
                {
                    ProductId = 6,
                    Title = "Ceramic Coffee Mug Set",
                    Price = 34.99m,
                    Description = "Set of 4 handcrafted ceramic mugs with elegant design",
                    Quantity = 40,
                    ImagePath = "",
                    CategoryId = 3
                },
                new Product     //7
                {
                    ProductId = 7,
                    Title = "Wireless Phone Charger",
                    Price = 39.99m,
                    Description = "Fast wireless charging pad compatible with Qi-enabled devices",
                    Quantity = 35,
                    ImagePath = "",
                    CategoryId = 2
                },
                new Product     //8
                {
                    ProductId = 8,
                    Title = "Yoga Mat Premium",
                    Price = 54.95m,
                    Description = "Eco-friendly yoga mat with non-slip surface and carrying strap",
                    Quantity = 20,
                    ImagePath = "",
                    CategoryId = 4
                },
                new Product     //9
                {
                    ProductId = 9,
                    Title = "Portable External SSD",
                    Price = 149.99m,
                    Description = "1TB portable SSD with USB-C connectivity and fast transfer speeds",
                    Quantity = 18,
                    ImagePath = "",
                    CategoryId = 1
                },
                new Product     //10
                {
                    ProductId = 10,
                    Title = "Aromatherapy Diffuser",
                    Price = 45.99m,
                    Description = "Ultrasonic essential oil diffuser with color-changing LED lights",
                    Quantity = 28,
                    ImagePath = "",
                    CategoryId = 4
                }
            };
        }

        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category    // 1 
                {
                    CategoryId = 1,
                    CategoryName = "Audio & Computing",
                    Description = "High-quality audio and computing equipment"
                },
                new Category    // 2
                {
                    CategoryId = 2,
                    CategoryName = "Mobile Technology",
                    Description = "Portable tech devices and accessories"
                },
                new Category    // 3
                {
                    CategoryId = 3,
                    CategoryName = "Home Essentials",
                    Description = "Essential products for daily home use"
                },
                new Category    // 4
                {
                    CategoryId = 4,
                    CategoryName = "Wellness Products",
                    Description = "Products for relaxation and personal care"
                },
                new Category    // 5
                {
                    CategoryId = 5,
                    CategoryName = "Clothing",
                    Description = "Comfortable and sustainable clothing"
                }
            };

        }
    }
}
