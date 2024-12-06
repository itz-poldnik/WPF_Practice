using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Product = new Product
            {
                IdProduct = 1,
                Name = "Колбаса вареная",
                Description = "Докторская колбаса, высший сорт",
                Unit = "килограмм",
                IdSupplier = 4
            };
            Console.WriteLine($"Product '{Product.IdProduct}', '{Product.Name}', '{Product.Description}', '{Product.Unit}', '{Product.IdSupplier}'");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var Product = new Product
            {
                IdProduct = 1,
                Name = "DKLLKF mfghjk",
                Description = "Ggfnk,fgkfgjn ",
                Unit = "kfkdjghb",
                IdSupplier = 8
            };
            Console.WriteLine($"Product '{Product.IdProduct}', '{Product.Name}', '{Product.Description}', '{Product.Unit}', '{Product.IdSupplier}'");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var Product = new Product
            {
                IdProduct = 1,
                Name = "46343 556543",
                Description = "46457 5656776",
                Unit = "576565",
                IdSupplier = 2
            };
            Console.WriteLine($"Product '{Product.IdProduct}', '{Product.Name}', '{Product.Description}', '{Product.Unit}', '{Product.IdSupplier}'");
        }
    }
}