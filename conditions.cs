int time = DateTime.Now.Hour;

if(time <= 11 && time >= 6){
    Console.WriteLine("Günaydın");
}else if(time <= 18 && time > 11){
    Console.WriteLine("İyi Günler");
}else if (time > 18 && time <= 22){
    Console.WriteLine("İyi Akşamlar");
}else if (time > 22 && time < 6) {
    Console.WriteLine("İyi Geceler");
}

// Ternary (İç içe if-else)

// string sonuc = time<=18 ? "İyi Günler" : "İyi Akşamlar";

// Yukarıdaki if else bloklarının hepsini tek satırda yazmak için

string sonuc = time>=6 && time<=11 ? "Günaydın" : time<=18 && time>11? "İyi günler" : time>18 && time <=22 ? "İyi Akşamlar" : "İyi Geceler";

Console.WriteLine(sonuc);



// ***** Switch-case kullanımı *****

int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("Ocak Ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat Ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart Ayındasınız");  
        break;
    case 4:
        Console.WriteLine("Nisan Ayındasınız");
        break;      

    default:
        Console.WriteLine("Geçersiz ifade");
        break;
}

// Mevsim bulma (çoklu case kullanımı)

switch (month)
{
    case 12:
    case 1:
    case 2: 
        Console.WriteLine("Kış Mevsimindesiniz");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar mevsimindesiniz");   
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Mevsimindesiniz");   
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar Mevsimindesiniz");   
        break;      

    default:
        Console.WriteLine("Geçersiz ifade");
    break;
}