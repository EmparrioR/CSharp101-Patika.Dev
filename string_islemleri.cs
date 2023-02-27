string degisken = "Dersimiz C# Hoşgeldiniz";
string degisken_2 = "C#";

// Karakter sayısı
Console.WriteLine(degisken.Length);

// ToUpper, ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// Concat (Birleştirme yapar)
Console.WriteLine(String.Concat(degisken," Merhaba"));

// Compare , CompareTo (Karşılaştırmak için kullanılır)

Console.WriteLine(string.Compare(degisken,"Alperen",false));
// true dersek büyük-küçük harf duyarsızdır
// false dersek duyarlıdır

Console.WriteLine(degisken.CompareTo("Alperen"));
// 2 değişken birbirine eş ise = 0
// 2 değişkenden 'degisken' diğerinden karakter sayısı olarak büyük ise = 1
// 'degisken' diğerinden küçük ise = -1 döndürür     


// Contains (İçerir mi)
Console.WriteLine(degisken.Contains(degisken_2));

// Değişken hoşgeldiniz ile bitiyor mu ?
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));

Console.WriteLine(degisken.StartsWith("Dersimiz"));

// IndexOf (Yazıdğımız ilk ifadenin indeksini döner, ifade yoksa -1 döner)
Console.WriteLine(degisken.IndexOf("C#"));
// En sondaki, belirttiğimiz ifadenin indeksini döndürür
Console.WriteLine(degisken.LastIndexOf("i"));

// Insert (Belirttiğimiz indeksten başlayarak ifadeyi ekler)
Console.WriteLine(degisken.Insert(0,"Merhaba"));

// PadLeft, PadRight

// (degisken_2 nin karakter sayısını 30'a tamamlayacak kadar soldan boşluk ekle)
Console.WriteLine(degisken + degisken_2.PadLeft(30));
// (Aynı şekilde degisken'in karakter sayısını 50'ye tamamlayana kadar sağdan * ekle)
Console.WriteLine(degisken.PadRight(50,'*') + degisken_2);

//Remove 
// (Belirttiğimiz indeks ve aralıkta karakter silme yapar)
Console.WriteLine(degisken.Remove(5,4));
// Bu 5. indeksten öncesini yazdır demektir
Console.WriteLine(degisken.Remove(5));

// Replace (Değiştir)
Console.WriteLine(degisken.Replace("C#","CSharp"));
Console.WriteLine(degisken.Replace(" ","*"));

// *** Split *** (Boşluklara göre parçala ve bir diziye ata)

// Ve 1. indeksi getir, neye göre parçalayacağını biz belirleriz
Console.WriteLine(degisken.Split(' ')[1]);

// Substring , (belirlediğimiz indeksten başlayarak cümlenin sonuna kadar götürür)
Console.WriteLine(degisken.Substring(4));
// belirlediğimiz karakter kadar getir
Console.WriteLine(degisken.Substring(4,6));