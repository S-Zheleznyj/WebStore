using webstore;
using Xunit;

namespace WebStore.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actural = Book.IsIsbn(null);

            Assert.False(actural);
        }

        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actural = Book.IsIsbn("    ");

            Assert.False(actural);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actural = Book.IsIsbn("ISBN 123");

            Assert.False(actural);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actural = Book.IsIsbn("IsBn 123-456-789 0");

            Assert.True(actural);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue()
        {
            bool actural = Book.IsIsbn("IsBn 123-456-789 0123");

            Assert.True(actural);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actural = Book.IsIsbn("xxx IsBn 123-456-789 0 yyy");

            Assert.False(actural);
        }
    }
}