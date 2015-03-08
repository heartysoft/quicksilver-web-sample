using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using MyWebsite.Controllers;
using NUnit.Framework;

namespace MyWebsiteTests
{
    [TestFixture]
    public class ValueControllerTests
    {
        [Test]
        public void get_should_fetch_values()
        {
            var storage = A.Fake<ValueStorage>();
            A.CallTo(() => storage.GetValues()).Returns(new[] {"lala"});

            var controller = new ValuesController(storage);

            var result = controller.Get();

            Assert.AreEqual("lala", result.ToArray()[0]);
        }
    }
}
