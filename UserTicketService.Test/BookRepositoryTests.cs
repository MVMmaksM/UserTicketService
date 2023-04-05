using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Test
{
    [TestFixture]
    internal class BookRepositoryTests
    {
        [Test]
        public void FindAllMustReturnCorrectValue() 
        {
            var list = new List<Book>()
            {
                new Book() {Title = "Война и мир"},
                new Book() {Title = "Человек-невидимка"},
                new Book() {Title = "Анна Каренина"}
            };

            Mock<IBookRepository> mock = new Mock<IBookRepository> ();
            mock.Setup(x => x.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(b => b.Title == "Война и мир"));
        }
    }
}
