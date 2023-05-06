using System;

class Program
{
    /* Kullanıcının girdiği sayı tek ise 2 katını çift ise yarısını hesaplayan, 
    bu işlemi yeni bir sayı için kullanıcının onayına bağlı olarak tekrarlayan ve yine kullanıcı istediğinde işlemi bitiren C# dilinde program*/
    static void Main(string[] args)
    {
        string seçim;
        
        do
        {
            Console.WriteLine("Sayı giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            
            if (sayı % 2 == 1)
            {
                sayı = sayı * 2;
                Console.WriteLine("Bu sayı tek sayıdır, işlem sonucu:\n" + sayı);
            }
            else
            {
                sayı = sayı / 2;
                Console.WriteLine("Bu sayı çift sayıdır, işlem sonucu:\n" + sayı);
            }
            
            Console.WriteLine("Devam etmek için A tuşuna, çıkmak için A dışında herhangi bir tuşa basın");

            // Kullanıcının seçimini okuyun
            seçim = Console.ReadLine();
            
        } while (seçim.ToUpper() == "A");  // Kullanıcı "A" tuşuna basarsa döngüyü tekrarlayın
    }
}