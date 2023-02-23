// Ekranda yazılan sayıya kadar olan tek sayıları yazdırma


Console.Write("Sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=sayi; i++ ){
    if(i%2==1){
    Console.WriteLine(i);
    }
}


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



// While ve Foreach

// 1'den başlayarak girilen sayıya kadar olan sayıların ortalamasını alma

Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
int k = 1,toplam = 0;
while(k<=number){
    
    toplam += k;
    k++;
    
}
Console.WriteLine(toplam/number); 

char character = 'a';
while(character <= 'z'){
    Console.Write(character);
    character++;
}

// Foreach

string[] arabalar = {"\nBMW","Toyota","Ford"};

foreach (var i in arabalar){
    Console.WriteLine(i);
}

