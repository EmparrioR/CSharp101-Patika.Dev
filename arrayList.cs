using System.Collections;

// Array List 

// Her veri tipinden ekleme yapabiliriz
ArrayList list = new ArrayList();
list.Add("Mahmut");
list.Add(22);
list.Add(true);
list.Add('A');

Console.WriteLine(list[3]);


// Toplu bir şekilde eleman ekleme

string[] renkler = {"Kırmızı,Sarı,Mavi"};
List<int> number = new List<int>(){1,2,4,6,3};

// Bu metotta collections tipinden veri ekleriz
list.AddRange(renkler);

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Sort (Sıralama)
// Bu metodu kullanmadan arrayList'in sadece int değerlerinden oluştuğundan emin olmalıyız. Aksi halde hata verir.
list.Sort();

// Binary Search (Elemana göre indeks bulma)
list.BinarySearch("Kırmızı");

// Reverse (Elemanları tersten yazdırma)
list.Reverse(); 

// Clear (Listeyi Temizler)
list.Clear();
