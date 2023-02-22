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