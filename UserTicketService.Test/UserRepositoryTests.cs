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
    public class UserRepositoryTests
    {
        [Test]  
        public void FindAllMustReturnCorrectcValue() 
        {
            var list = new List<User>()
            {
                new User(){Name = "Антон" },
                new User(){Name = "Иван" },
                new User(){Name ="Алексей"}
            };

            Mock<IUserRepository> mock = new Mock<IUserRepository>();
            mock.Setup(x => x.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
        }
    }
}
