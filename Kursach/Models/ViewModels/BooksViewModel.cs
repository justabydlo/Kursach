using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models.ViewModels
{
    public class BooksViewModel
    {
        public IList<BookCatalogModel> Books { get; set; }
        public string Query { get; set; }
        public int PageNumber { get; set; }
        public int PageElements { get; set; }
        public int ElementsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages
        {
            get
            {
                return TotalItems / ElementsPerPage + TotalItems % ElementsPerPage;
            }
        }
        public int TotalPageItems
        {
            get
            {
                return Books.Count();
            }
        }
    }
}
