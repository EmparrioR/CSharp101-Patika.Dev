namespace hataYonetimi
{
    class try_catch{
        static void Main(string [] args){

            
            try
            {   
                // Kontrol etmek istedimğimiz kod bloğunu yazarız
                Console.WriteLine("Bir sayı giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + a);
 
            }
            catch (Exception ex)
            {   
                // ex.Message hata mesajını yazdırır
                Console.WriteLine("Hata: " + ex.Message.ToString());
                
            }
            finally
            {
                // Hata alsın veya almasın final bloğu çalışır
                Console.WriteLine("İşlem Tamamlandı !");
            }

            // Hata çıktısı olarak istediğimiz şeyi yazdırabilme
            try{    

               // int a = int.Parse(null);
               // int a = int.Parse("test");
               int a = int.Parse("-2000000000000000000");

            }
            catch(ArgumentException e){
                
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(e);

            }catch(FormatException e){
                
                Console.WriteLine("Veri tipi hatası");
                Console.WriteLine(e);

            }catch(OverflowException e){

                Console.WriteLine("Çok küçük veya büyük bir değer girdiniz !");
                Console.WriteLine(e);

            }finally{
                Console.WriteLine("İşlem tamamlandı !");
            }

        }
    }
}