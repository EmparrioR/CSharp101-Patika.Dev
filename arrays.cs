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

// Array Metodları Örnekleri

int[] sayiDizisi = {23,12,4,86,72,3,11,17};

// Sırasız Dizi
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

// Sıralı Dizi

Array.Sort(sayiDizisi);
foreach (var item in sayiDizisi){
    Console.WriteLine(item);
}

// Array Clear 

// Açıklama: Sayi dizisi elemanlarını kullanarak 2 tane elemanı '0' a çevir
Array.Clear(sayiDizisi,2,3);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

// Reverse

Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

// Indexof = elemanın ismini verip kaçıncı indekste olduğunu sorgulama

Console.WriteLine(Array.IndexOf(sayiDizisi,72));

// Resize = Dizinin boyutunu değiştirebilme

// Boyutu 9'a çıkarır.
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 45;

foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

