using OOP1;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 200;
        product1.UnitsInStock = 3;

        Product product2 = new Product {Id=2,CategoryId=3,ProductName="koltuk",UnitPrice=500,UnitsInStock=6};

        //ProductManager türündeki productManager yeni bir referans numarası almış ProductManager'dır
        //stack                         //heap 
        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        productManager.Update(product2);

        productManager.Topla2(3, 6);
        int toplamaSonucu = productManager.Topla(8, 6);
        Console.WriteLine("sonuç:"+toplamaSonucu*2);
    }
}