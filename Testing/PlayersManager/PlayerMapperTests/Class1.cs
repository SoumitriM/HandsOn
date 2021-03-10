using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace PlayerMapperTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [TestCase("Soumitri")]
        //[ExpectedException(typeof(ArgumentException))]
        public void TestMethod(string name)
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(false);
            mock.Setup(x => x.AddNewPlayerIntoDb(name));
            var result = Player.RegisterNewPlayer(name, mock.Object);
            Assert.That(result, Is.TypeOf<Player>());
            Assert.That(result.Country, Is.EqualTo("India").IgnoreCase);
        }
        [Test]
        [TestCase(null)]
        public void TestNull(string name)
        {
            var mock = new Mock<IPlayerMapper>();
            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(name, mock.Object));
           
        }
    }
}
