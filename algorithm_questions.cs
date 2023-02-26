namespace algoritma_sorulari
{
    class algorithm_questions
    {
        public static void Main(string [] args){
            
            Odevler calistir = new();
            // calistir.FirstTask();
            // calistir.SecondTask();
            // calistir.ThirdTask();
            calistir.FourthTask();
        }
    }
}

class Odevler{
    public void FirstTask(){
        int n = 0;
        int [] dizi;

        Console.Write("Kaç Sayı Gireceksiniz: ");
        n = Convert.ToInt32(Console.ReadLine());

        dizi = new int[n];

        for(int i = 0; i<n; i++){
            
            Console.Write(i+1 + ". sayıyı giriniz: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
            
        }

        foreach(var items in dizi){
            if (items %2 == 0){
                Console.Write(items + " ");
            }
        }
    }

    public void SecondTask(){
        int m = 0,n = 0;
        int [] dizi;

        Console.WriteLine("Pozitif 2 sayı giriniz");
        Console.Write("1. sayı: ");
        n = Convert.ToInt32(Console.ReadLine());

        dizi = new int[n];

        Console.Write("2. sayı: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Sayının değeri kadar pozitif sayı giriniz");
        for(int i = 0; i<n; i++){
            Console.Write(i+1 + ". sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        foreach (var item in dizi)
        {
            
            if(item == m || item % m == 0){  
                Console.Write(item + " ");
            }
        }

    }

    public void ThirdTask(){

        int n = 0;
        string [] dizi; 

        Console.Write("Kaç kelime gireceksiniz: ");
        n = int.Parse(Console.ReadLine());

        dizi = new string[n];

        for(int i = 0; i<n; i++){
            Console.Write((i+1) + ". kelimeyi giriniz: ");
            
            dizi[i] = Console.ReadLine();
        }
        
        Array.Reverse(dizi);

        Console.WriteLine("*** Sonuç ***");

        foreach (var item in dizi)
        {
            Console.Write(item + " ");
        }

    }

    public void FourthTask(){
       
       string cumle;
       string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                        +"abcçdefgğhiıjklmnoöprsştuüvyz"
                        + "0123456789";
       int say = 0;


       Console.Write("Bir cümle yazınız: ");
       cumle = Console.ReadLine();

       foreach (var item in cumle)
       {
        if(liste.Contains(item)){
           say++; 
        }
       }

       Console.WriteLine("Toplam kelime ve rakam sayısı: " + say);

    }
}

