// Ekranda yazılan sayıya kadar olan tek sayıları yazdırma

/*
Console.Write("Sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=sayi; i++ ){
    if(i%2==1){
    Console.WriteLine(i);
    }
}
*/

// 1 ile 1000 arasındaki çift ve tek sayıların toplamlarını yazdır

int ciftToplam = 0,tekToplam = 0;

for (int i = 0; i <= 1000 ; i++)
{
    if (i%2==0)
    {   
        ciftToplam += i;
    }else if(i%2==1){
        tekToplam += i;
    }
    
}
Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);
Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);

// break ve continue kullanımı

for(int i = 0; i<=10; i++){
    if(i==4){
        break;
    }
    Console.WriteLine(i);
}

for(int i = 0; i<=10; i++){
    if(i==4){
        continue;
    }
    Console.WriteLine(i);
}
