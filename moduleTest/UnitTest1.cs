using System;
using FirstLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModuleTest
{
    [TestClass]
    public class firstTest
    {
        [TestMethod]
        public void volumeSphere()
        {
            Assert.AreEqual(33.51, new FirstClass().volumeSphere(2));
            Assert.AreEqual(4.189, new FirstClass().volumeSphere(1));
            Assert.AreEqual(11249494.896, new FirstClass().volumeSphere(139));
            Assert.AreEqual(0.268, new FirstClass().volumeSphere(0.4f));
        }
        [TestMethod]
        public void AreaTriangle()
        {
            Assert.AreEqual(0.25, new FirstClass().areaTriangle(1, 1, 30));
            Assert.AreEqual(1, new FirstClass().areaTriangle(2, 2, 30));
            Assert.AreEqual(13.962, new FirstClass().areaTriangle(40, 40, 1));
            Assert.AreEqual(38.302, new FirstClass().areaTriangle(10, 10, 50));
        }
        [TestMethod]
        public void cashConverter()
        {
            Assert.AreEqual(31.5, new FirstClass().cashConverter(30, 1.05));
            Assert.AreEqual(4, new FirstClass().cashConverter(2, 2));
            Assert.AreEqual(1.1, new FirstClass().cashConverter(55, 0.02));
            Assert.AreEqual(0, new FirstClass().cashConverter(0, 123123)); 
            Assert.AreEqual(0.001, new FirstClass().cashConverter(2, 0.0003));
        }
        [TestMethod]
        public void StoneScissorsPaper()
        {
            Assert.AreEqual("Draw", new FirstClass().StoneScissorsPaper("бУмАгА", "бумага"));
            Assert.AreEqual("Human victory", new FirstClass().StoneScissorsPaper("КАМЕНЬ", "НожницЫ"));
            Assert.AreEqual("Human victory", new FirstClass().StoneScissorsPaper("Бумага", "Камень"));
            Assert.AreEqual("Computer victory", new FirstClass().StoneScissorsPaper("Ножницы", "Камень"));
        }
        [TestMethod]
        public void fixStringCase()
        {
            Assert.AreEqual("SOMETHING STRING", new FirstClass().fixStringCase("SomeTHING STRing"));
            Assert.AreEqual("dreamteam", new FirstClass().fixStringCase("DreamTeam"));
            Assert.AreEqual("somesome", new FirstClass().fixStringCase("SOMEsome"));
            Assert.AreEqual("FIXFIXFIXTHIS", new FirstClass().fixStringCase("FixFixFixTHIS"));
        }
        [TestMethod]
        public void removeDuplicates()
        {
            Assert.AreEqual(new int[] { 1, 2 }, new FirstClass().removeDuplicates(new int[] { 1, 1, 2, 2}));
            Assert.AreEqual(new int[] { 23, 32, 174 }, new FirstClass().removeDuplicates(new int[] { 23, 32, 174, 23 }));
            Assert.AreEqual(new int[] { 4, 3, 2, 1 }, new FirstClass().removeDuplicates(new int[] { 4, 3, 2, 1 }));
            Assert.AreEqual(new int[] { 1 }, new FirstClass().removeDuplicates(new int[] { 1, 1, 1, 1 }));
        }
    }
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        public void BadAreaTriangle()
        {
            Assert.ThrowsException<Exception>(() => new FirstClass().areaTriangle(1, 1, 180));
            Assert.ThrowsException<Exception>(() => new FirstClass().areaTriangle(1, -2, 40));
            Assert.ThrowsException<Exception>(() => new FirstClass().areaTriangle(-123, -2, 999));
            Assert.ThrowsException<Exception>(() => new FirstClass().areaTriangle(-123, 2, 40));
        }

        [TestMethod]
        public void BadSSP()
        {
            Assert.ThrowsException<Exception>(() => new FirstClass().StoneScissorsPaper(null, null));
            Assert.ThrowsException<Exception>(() => new FirstClass().StoneScissorsPaper("smth", "камень"));
            Assert.ThrowsException<Exception>(() => new FirstClass().StoneScissorsPaper("камень", "бумаг"));
        }
        [TestMethod]
        public void BadVolume()
        {
            Assert.ThrowsException<Exception>(() => new FirstClass().volumeSphere(-123));
            Assert.ThrowsException<Exception>(() => new FirstClass().volumeSphere(-1));
        }
        [TestMethod]
        public void BadCash()
        {
            Assert.ThrowsException<Exception>(() => new FirstClass().cashConverter(-1, 0));
            Assert.ThrowsException<Exception>(() => new FirstClass().cashConverter(123, -2));
        }
    }
}
