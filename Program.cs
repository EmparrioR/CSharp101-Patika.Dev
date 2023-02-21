namespace degiskenler
{
    class Program
    {
        static void Main(string[] args){
            
            Int16 i16 = 2; // 2 byte
            Int32 i32 = 4; // 4 byte
            Int64 i64 = 8; // 8 byte

            // Reel
            float fl = 4;  // 4 byte
            double d = 8;  // 8 byte
            decimal de =  16; // 16 byte

            char a = '2'; // 2 byte
            string b = "Alperen"; // 4 byte

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // Objelerde her türlü değişken türünden değer tutulabilir
            object o1 = "y";
            object o2 = 'x';
            object o3 = 5;
            object o4 = 4.3;

            // String İfadeler
            string str = string.Empty;
            string name = "Alperen";
            string surName = "Atar";
            string fullName = name + " " + surName;

            // Int ifadeler 
            int f = 5;
            int z = 3;
            int multiply = f*z;

            // boolean
            bool bool1 = 10<2;

            // Değişken Dönüşümleri - 3 adet (Convert,to...,Parse)
            string str20 = "20";
            int int20 = 20;
            string yeniDeger =  str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktı 40

            // string->int dönüşümlerinde kullanılır
            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // Çıktı 40

            // dateTime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}