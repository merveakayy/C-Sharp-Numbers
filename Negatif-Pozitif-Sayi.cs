using System;

class Program
{
    /*Kullanıcının girdiği sayı negatif ise sayının karesini(s* s), pozitif ise küpünü(s* s*s) hesaplayan, 
    bu işlemi yeni bir sayı için kullanıcının onayına bağlı olarak tekrarlayan ve yine kullanıcı istediğinde işlemi bitiren C# dilinde program*/

    static void Main(string[] args)
    {
        string seçim;
        
        do
        {
            Console.WriteLine("Sayı giriniz:");
            int sayı = Convert.ToInt32(Console.ReadLine());
            
            if (sayı < 0)
            {
                sayı = sayı * sayı;
                Console.WriteLine("Bu sayı negatif sayıdır, işlem sonucu:\n" + sayı);
            }
            else
            {
                sayı = sayı * sayı * sayı;
                Console.WriteLine("Bu sayı pozitif sayıdır, işlem sonucu:\n" + sayı);
            }
            
            Console.WriteLine("Devam etmek için A tuşuna, çıkmak için A dışında herhangi bir tuşa basın");
            seçim = Console.ReadLine();
            
        } while (seçim.ToUpper() == "A");  // Kullanıcı "A" tuşuna basarsa döngüyü tekrarlayın
    }
}