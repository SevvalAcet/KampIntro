
string adi = "Engin";
int yas = 36;

Kurs kurs1 =new Kurs();
kurs1.Eğitmeni = "Engin Demiroğ";
kurs1.izlenmeOranı = 68;
kurs1.KursAdi = "C#";

Kurs kurs2 = new Kurs();
kurs2.Eğitmeni = "Engin Demiroğ";
kurs2.izlenmeOranı = 32;
kurs2.KursAdi = "Java";

 Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " " + kurs.Eğitmeni + " " +kurs.izlenmeOranı);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmeni { get; set; }
    public int izlenmeOranı { get; set; }

}
