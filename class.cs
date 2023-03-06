// Erişim Belirleyicileri

// Public = Her yerden erişilir
// Private = Sadece tanımlandığı sınıf içerisinden
// Internal = Sadece kendi bulunduğu proje içerisinden
// Protected = Sadece tanımlandığı sınıf ve o sınıftan miras alan

namespace classes
{
    class Class_Anlatim
    {
        public static void Main(string [] args){
            Employee employee1 = new Employee();

            employee1.name = "Alperen";
            employee1.surName = "Atar";
            employee1.no = 3432;
            employee1.department = "Software Development";

            employee1.EkranaYazdir();
        }
    }
}

class Employee
{
    public string name;
    public string surName;
    public int no;
    public string department;

    public void EkranaYazdir(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("SurName: " + surName);
        Console.WriteLine("No: " + no);
        Console.WriteLine("Department: " + department);
    }
}