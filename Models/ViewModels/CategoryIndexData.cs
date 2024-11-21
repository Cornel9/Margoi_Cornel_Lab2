using Margoi_Cornel_Lab2.Models;

namespace Margoi_Cornel_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
