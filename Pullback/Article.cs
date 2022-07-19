using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pullback
{
    class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Article(int ArticleId, string Name, string Description, decimal Price, string Category)
        {
            this.ArticleId = ArticleId;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Category = Category;
        }
    }
}
