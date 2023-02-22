namespace tip_donusumleri
{
    class tipDonusumleri{
        static void Main(string [] args){

            // Implicit Conversion

            // Küçük yer kaplayan veri tipinden büyük veri tipine dönüşüm yapılması
            // Veri kaybı olmaz

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float f = h;
            Console.WriteLine("f:" + f);

            string s = "Alperen";
            char g = 'k';
            object l = s+g+d; 

            //Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);

            float v = 10.3f;
            byte w = (byte)v;
            Console.WriteLine(v);


            // ToString metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            // Convert

            string s1 = "10",s2 = "20";
            int sayi1,sayi2;
            

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            int Toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + Toplam);

            // Parse 
            // Sadece stringi dönüştürmede kullanılır

            ParseMethod();

            
            


        }

        public static void ParseMethod(){
            string metin1 = "10",metin2 = "20";
            int rakam;
            double double1;

            rakam = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine(rakam);
            Console.WriteLine(double1);

        }

    }
}