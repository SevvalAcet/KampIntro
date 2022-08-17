
using Metotlar;
class Program
{
    static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyatı = 15;
        string aciklama = "Amasya ellması";

        string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Aciklama = "amasya elması";
        urun1.Fiyati = 15;

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Id);
            Console.WriteLine("------------");

            Console.WriteLine("------METOTLAR--------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut",4,5);
            sepetManager.Ekle2("Elma","kırmızı elma" ,5,6);
        }
    }
}
