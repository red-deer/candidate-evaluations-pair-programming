using CodeTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void CanReadSales()
        {
            var fileLoader = new FileLoader();

            var content = fileLoader.GetAssetContent("Sales.csv");

            Assert.That(content, Has.Length.EqualTo(936));
        }
    }
}