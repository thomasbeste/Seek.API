using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Seek.DAL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new SeekContext("Seek.Database"))
            {
                var users = context.Organizations.ToList();


            }
        }
    }
}
