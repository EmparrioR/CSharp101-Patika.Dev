// Dizi oluşturma yöntemleri

string [] renkler = new string[5];

string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

int [] sayilar;
sayilar = new int[5];

// Dizilere eleman atama

renkler[0] = "Mavi";

sayilar[3] = 10;

Console.WriteLine(renkler[0]);
Console.WriteLine(sayilar[3]);
Console.WriteLine(hayvanlar[2]);

// Döngüler ile Dizi Kullanımı ***

// kullanıcıdan alınan sayıları diziye aktar ve bu sayıların ortalamasını al

int toplam = 0;

Console.Write("Kaç sayı gireceksiniz: ");
int diziUzunlugu = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[diziUzunlugu]; 

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen " + i + ".nci elemanı giriniz: ", i+1);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

foreach ( var item in numbers){
    toplam += item;
}

Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);