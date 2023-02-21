namespace operatorler
{
    class operatorler_basics{
        static void Main(string[] args){
            
            // Atama ve işlemli atama

            int y = 5;
            int x = 3;
            y+=2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            // Mantıksal Operatörler

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted){
                Console.WriteLine("Perfect");
            } if(isSuccess || isCompleted){
                Console.WriteLine("Great");
            } if(isSuccess && !isCompleted){
                Console.WriteLine("Fine");
            }

            // Mantıksal Operatörler
            // <,>,<=,>=,==,!=

            int a = 3;
            int b = 5;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler
            // +,-,*,/,%,+=,-=,/=,*=


        }
    }
}