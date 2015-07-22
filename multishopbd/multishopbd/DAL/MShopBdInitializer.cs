using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using multishopbd.Models;

namespace multishopbd.DAL
{
    public class MShopBdInitializer : DropCreateDatabaseIfModelChanges<MShopBdContext>
    {
        protected override void Seed(MShopBdContext context)
        {
            base.Seed(context);

            var Categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Men's Collection", ImageName="men.jgp"},
                new Category{CategoryId=2,CategoryName="Women's Collection", ImageName="women.jpg"},
                new Category{CategoryId=3,CategoryName="Electronics",ImageName="electronics.jpg"},
                new Category{CategoryId=4,CategoryName="Gift Item", ImageName="gift.jpg"},
                new Category{CategoryId=5,CategoryName="Computer Accessories",ImageName="computer.jpg"}
            };

            Categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            var SubCategories = new List<SubCategory>
            {
                new SubCategory{SubCategoryId=1, CategoryId=1, SubCategoryName="Wallets"},
                new SubCategory{SubCategoryId=2, CategoryId=1, SubCategoryName="Mens Watch"},
                new SubCategory{SubCategoryId=3, CategoryId=1, SubCategoryName="Shirts"},
                new SubCategory{SubCategoryId=4, CategoryId=1, SubCategoryName="Mens Sunglasses"}
            };
            SubCategories.ForEach(s => context.SubCategories.Add(s));
            context.SaveChanges();
        }
    }
}