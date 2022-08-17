// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for(int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}

//array
string[] kurslar = new string[]
{
    "Yazılım Geliştirici Yetiştirme Kampı",
    "Programlamaya başlangıç için temel kurs"
};

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}