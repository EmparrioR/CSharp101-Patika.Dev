// Rekürsif - Özyinelemeli Metot



namespace METOTLAR      
{
    class methods_continue
    {
        public static void Main(string [] args){

            // Üs almanın for ile yazılması
            // 3^4 alma

            Console.Write("Sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs giriniz: ");
            int us = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for(int i = 1; i<=us; i++){
                result = result * number;
            }
            Console.WriteLine("Sonuç: " + result);

        // Rekürsif Metod ile üst alma

            Islemler ust = new();
            ust.UstAl(3,4);


        // Extension Kullanımı    
            
            string ifade = "Alperen Atar";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(sonuc);

            // Boşluk var ise bu boşluğu silen if koşulu ifadesi yazdırma

            // sonuc == 1 ise demektir
            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            // static class'larda obje oluşturmamız gerekmez

            int [] dizi = {1,2,5,3,6,4,2};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int number2 = 5;
            Console.WriteLine(number2.IsEven());

            Console.WriteLine(ifade.GetFirstCharacter());
            
        }
    }

    public class Islemler{
        public int UstAl(int number,int us){
            if(us<2){
                return number;
            }else {
                return UstAl(number,us-1)*number;
            }
        }
        
        // İşlem Basamakları
        /* UstAl(3,4)
           UstAl(3,3)*3 
           UstAl(3,2)*3*3
           UstAl(3,1)*3*3*3
           3*3*3*3
        */   
    } 

    public static class Extension{

        public static bool CheckSpaces(this string param) {
            // " " içeriyor mu demektir
            return param.Contains(" ");
        } 

        public static string RemoveWhiteSpaces(this string param){
           
            // paramı boşluklarından ayır ve diziye al demektir
            string [] dizi = param.Split(" ");
           
            // join ifadesi ile bu diziyi boşlukarı  "" ile birleştir demektir
            return string.Join("",dizi);

        }

        // Vermiş olduğumuz string ifadeyi büyük harflere çeviren extension örneği

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int [] param){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }


        // verilen sayının 2'ye bölünüp bölünmeyeceğini ve sonucu boolean olarak veren fonksiyon
        public static bool IsEven(this int param){
            
            return param%2 == 0;

        }

        public static string GetFirstCharacter(this string param){
           
            // Substring metodu index ve uzunluk(kaç karakter) arasındaki char'ları verir
            return param.Substring(0,1);
        }

    }     
}
