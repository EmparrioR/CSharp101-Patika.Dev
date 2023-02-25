// methods'lar bir class içinde yazılması gerekir

// Sırasıyla bileşenleri

// erisim_belirteci geri_donus tipi metot_adi (parametre_Listesi/argüman){

// } 

// şeklinde oluşturulur.

int a = 2,b = 3;



int Topla(int d1,int d2){
    return d1+d2;
}

// a ve b'nin kopyaları ile çalışır
int sonuc = Topla(a,b);
// Console.WriteLine(sonuc);

Metotlar methods = new Metotlar();
// methods.EkranaYazdir(sonuc.ToString()); 



// Bu işlem a ve b'nin kopyalarını değil bellekteki adresteki asıl hallerini etkiler
int sonuc_2 = methods.ArttirVeTopla(ref a, ref b);

methods.EkranaYazdir(Convert.ToString(sonuc_2));
methods.EkranaYazdir((a+b).ToString());




// class içindeki değişken,fonk. vs. erişim belirteci vermezsek, default olarak "private" belirler
class Metotlar{
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int d1, ref int d2){
        d1++; d2++;
        return d1+d2;
    }
}