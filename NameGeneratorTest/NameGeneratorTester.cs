using NameGenMvcApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameGeneratorTest
{
    [TestFixture]
   public class NameGeneratorTester
    {
        [Test]
        public void WritesGenericNameProducesName()
        {
            var nameGenerator = new NameGenerator();
            var test1 = nameGenerator.getGenericName(10);
            Assert.IsTrue(test1 != null);
        }
        //[Test]
        //public void WritesGeneric
    }  
}
