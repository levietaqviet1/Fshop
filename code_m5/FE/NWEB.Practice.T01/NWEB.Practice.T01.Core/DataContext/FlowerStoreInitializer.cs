using Microsoft.EntityFrameworkCore;
using NWEB.Practice.T01.Core.Model;

namespace NWEB.Practice.T01.Core.DataContext
{
    public static class FlowerStoreInitializer
    {
        /// <summary>
        /// viet hoa
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string Uppercase(string name) { return name.ToUpper(); }
        /// <summary>
        /// add data for database
        /// </summary>
        /// <param name="builder"></param>
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Rose",
                    Order = 3,
                    Notes = "Genus of some 100 species of perennial shrubs in the rose family (Rosaceae). Roses are native primarily to the temperate regions of the Northern Hemisphere."
                },
                new Category
                {
                    Id = 2,
                    Name = "Chrysanthemum",
                    Order = 3,
                    Notes = "The genus Chrysanthemum are perennial herbaceous flowering plants, sometimes subshrubs. The leaves are alternate, divided into leaflets and may be pinnatisect, lobed, or serrate (toothed) but rarely entire; they are connected to stalks with hairy bases."
                },
                new Category
                {
                    Id = 3,
                    Name = "Tulip",
                    Order = 3,
                    Notes = "are a genus of spring-blooming perennial herbaceous bulbiferous geophytes (having bulbs as storage organs). The flowers are usually large, showy and brightly coloured, generally red, pink, yellow, or white (usually in warm colours)."
                },
                new Category
                {
                    Id = 4,
                    Name = "Lilium",
                    Order = 3,
                    Notes = "Is a genus of herbaceous flowering plants growing from bulbs, all with large prominent flowers. They are the true lilies. Lilies are a group of flowering plants which are important in culture and literature in much of the world. "
                },
                new Category
                {
                    Id = 5,
                    Name = "Jasmine ",
                    Order = 3,
                    Notes = "Is a genus of shrubs and vines in the olive family of Oleaceae.  It contains around 200 species native to tropical and warm temperate regions of Eurasia, Africa, and Oceania."
                }
                );
            builder.Entity<Flower>().HasData(
                new Flower
                {
                    Id = 1,
                    Name = "Red roses",
                    CategoryId = 1,
                    Description = "Red roses are a symbol of romantic love, passion, commitment, faithfulness, and loyalty",
                    Color = "Red",
                    Image = "",
                    Price = 100000,
                    SalePrice = 0,
                    StoreDate = DateTime.Now,
                    StoreInventory = 10000
                },
                new Flower
                {
                    Id = 2,
                    Name = "Chrysanthemum",
                    CategoryId = 2,
                    Description = "Chrysanthemum are a symbol of romantic love, passion, commitment, faithfulness, and loyalty",
                    Color = "Yellow",
                    Image = "",
                    Price = 10000,
                    SalePrice = 10,
                    StoreDate = DateTime.Now,
                    StoreInventory = 100000
                },
                new Flower
                {
                    Id = 3,
                    Name = "Tulip",
                    CategoryId = 3,
                    Description = "Tulipare a symbol of romantic love, passion, commitment, faithfulness, and loyalty",
                    Color = "Lavender",
                    Image = "",
                    Price = 100000,
                    SalePrice = 0,
                    StoreDate = DateTime.Now,
                    StoreInventory = 10000
                },
                new Flower
                {
                    Id = 4,
                    Name = "Lilium",
                    CategoryId = 4,
                    Description = "Lilium are a symbol of romantic love, passion, commitment, faithfulness, and loyalty",
                    Color = "Blue",
                    Image = "",
                    Price = 20000,
                    SalePrice = 5,
                    StoreDate = DateTime.Now,
                    StoreInventory = 1000
                },
                new Flower
                {
                    Id = 5,
                    Name = "Jasmine",
                    CategoryId = 1,
                    Description = "Jasmine are a symbol of romantic love, passion, commitment, faithfulness, and loyalty",
                    Color = "Pink",
                    Image = "",
                    Price = 10000,
                    SalePrice = 13,
                    StoreDate = DateTime.Now,
                    StoreInventory = 10000
                }
                );
        }
    }
}
