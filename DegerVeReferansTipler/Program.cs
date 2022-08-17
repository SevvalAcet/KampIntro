// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sayş1 = 10;
int sayi2 = 30;
int sayi1 = sayi2;
sayi2 = 65;

int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 70, 80, 90 };
sayilar1 = sayilar2;
sayilar2[0] = 800;
Console.WriteLine(sayilar1[0]);