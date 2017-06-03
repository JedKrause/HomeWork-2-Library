using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork_1_Library.Models
{
    public static class Repository
    {
        private static List<BooksModel> booksRepo = new List<BooksModel>();
        public static IEnumerable<BooksModel> BooksRepo
        {
            get
            {
                return booksRepo;
            }
        }
        public static void AddBooks(BooksModel book)
        {
            booksRepo.Add(book);
        }
    }
}
