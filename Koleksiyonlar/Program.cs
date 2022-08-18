using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //string[] isimler = new string[] { "engin", "murat", "kerem" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);

        //isimler = new string[5];
        //isimler[4] = "İlker";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);//burada çalıştırdığımızda engin gelmiyor çünkü newlediğimizde yeni referans veriyoruz değer vermiyoruz

        List<string> isimler2 = new List<string>();
        isimler2.Add("Engin");

        List<string> isimler3 = new List<string> {"Engin","Murat","Kerem","Halil"};
        Console.WriteLine(isimler3[0]);
        isimler3.Add("kerim");
        Console.WriteLine(isimler3[4]);
        Console.WriteLine(isimler3[0]);
    }
}

