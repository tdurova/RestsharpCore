using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RestsharpCore.tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Test
    {
        [TestFixture]
        public class ContactCreationTests : TestBase
        {
            [Test]
            public void ContactCreationTest()
            {
                Console.WriteLine("My first test");
                //Создаем объект класса ContactData и задаем значения переменных
            }
        }
    }
}
