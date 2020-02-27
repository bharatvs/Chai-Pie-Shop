using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaisPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pie",Description="All-fruit"},
                new Category{CategoryId=2,CategoryName="chees cakes",Description="Cheesy all the way"},
                new Category{CategoryId=3,CategoryName="Seasonal Pies",Description="Get mood for seasonal pies"}

            };
    }
}
