using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CustomerCommLib;
using NUnit.Framework;

namespace CustomerCommTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [TestCase("cust123@abc.com", "Some Message",true)]
        public void TestMethod(string address, string msg, bool exp)
        {
            var mailSender = new Mock<IMailSender>();
            mailSender.Setup(x => x.SendMail(address, msg)).Returns(exp);
            var customerComm = new CustomerComm(mailSender.Object);
            Assert.IsTrue(customerComm.SendMailToCustomer());
        }
        
        
    }
}
