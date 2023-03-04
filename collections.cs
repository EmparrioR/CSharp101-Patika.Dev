// Koleksiyonlar

// Farklı veri tiplerinden oluşabilirler (array'lerin aksine)

// Koleksiyonlar verileri object(obje) olarak tutarlar

// Değer Tipleri: int,long,float,double,decimal,char,bool,byte,short,struct, enum
// Referans Tipleri: string,object,class,interface,array,delegate,pointer

// Koleksiyona değer atama = Değer tipini referans tipine dönüştürmektir. (boxing)
// Koleksiyondan değer çekme = Referansı değer tipine dönüştürmektir. (unboxing)

// Liste oluşturma
List <int> sayiListesi = new List<int>();

sayiListesi.Add(32);
sayiListesi.Add(45);
sayiListesi.Add(56);

List <string> renkListesi = new List<string>();

renkListesi.Add("Mavi");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

// Count
Console.WriteLine(sayiListesi.Count());
Console.WriteLine(renkListesi.Count());

// for-each (2 metod var )

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

//Metod ile yazdırma 
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

renkListesi.ForEach(renk => Console.WriteLine(renk));

// Remove
renkListesi.Remove("Mavi");
sayiListesi.Remove(32);

// Eleman arama 
if(renkListesi.Contains("Yeşil"))
    Console.WriteLine("Listede Sarı renk var");
else 
    Console.WriteLine("Listede sarı yok");

//  Eleman ile indexe erişme
Console.WriteLine(sayiListesi.BinarySearch(45));       
Console.WriteLine(renkListesi.BinarySearch("Yeşil"));

// Diziyi Liste çevirme
string [] hayvanlar = {"Kedi","Köpek","Kuş"};
List<string> hayvanlarListesi = new List<string>(hayvanlar);

// Listeyi Temizleme
hayvanlarListesi.Clear();

// Liste içerisinde nesne tutmak (class ile)
// Öncelikle "Kullanıcılar" classı tipinde bir liste oluşturuyoruz
List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı_1 = new Kullanıcılar();
kullanıcı_1.Ad = "Alperen";
kullanıcı_1.Soyad = "Atar";
kullanıcı_1.Yas = 22;

Kullanıcılar kullanıcı_2 = new Kullanıcılar();
kullanıcı_2.Ad = "Mahmut";
kullanıcı_2.Soyad = "Alperen";
kullanıcı_2.Yas = 22;

kullanıcıListesi.Add(kullanıcı_1);
kullanıcıListesi.Add(kullanıcı_2);

// Obje atarken belirleme

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
yeniListe.Add(new Kullanıcılar(){
    Ad = "Alp",
    Soyad = "Atar",
    Yas = 22
});

// Şeklinde yazdırılabilir
yeniListe.ForEach(yeni => Console.WriteLine(yeni.Ad));


foreach (var item in kullanıcıListesi)
{
    Console.WriteLine(item.Ad);
    Console.WriteLine(item.Soyad);
    Console.WriteLine(item.Yas);
}

yeniListe.Clear();


public class Kullanıcılar{
    private string ad,soyad;
    private int yas;

    // Getter ve Setter oluşturma
    public string Ad {get => ad; set => ad = value;}
    public string Soyad {get => soyad; set => soyad = value;}
    public int Yas {get => yas; set => yas = value;}


}






