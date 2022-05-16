using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webstore;

namespace WebStore.Tests
{
    class StubBookRepository : IBookRepository
    {
        public Book[] ResultOfGetAllByIsbn { get; set; }
        public Book[] ResultOfGetAllByTitleOrAuthor { get; set; }

        public StubBookRepository()
        {
            ResultOfGetAllByIsbn = new[]
            {
                new Book(1, "", "", "", "", 0m)
            };

            ResultOfGetAllByTitleOrAuthor = new[]
            {
                new Book(2, "", "", "", "", 0m)
            };
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return ResultOfGetAllByIsbn;
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return ResultOfGetAllByTitleOrAuthor;
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
