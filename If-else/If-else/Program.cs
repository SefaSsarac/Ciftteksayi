using System;

class Program
{
    static void Main()
    {
        Console.Write("Lutfen bir sayi giriniz: ");

        string girilensayi = Console.ReadLine();

        int sayi = Convert.ToInt32(girilensayi);    // Kullanıcının girdigi degeri integer a donusturuyorum.

        if (sayi == 10)                        // Sayının 10'a eşit olup olmadığını kontrol ediyorum
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
        }
        else if (sayi < 10)                   // Sayının 10'dan küçük olup olmadığını kontrol ediyorum
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür. ");
        }
        else                                  // Sayının 10'dan büyük olup olmadığını kontrol ediyorum
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
        }
        if (sayi % 2 == 0)                   // Sayının cift sayı olup olmadiginı kontrol ediyorum
        {
            Console.WriteLine("Girilen sayi cifttir. ");
        }
        else
        {
            Console.WriteLine("Girilen sayi tektir. ");
        }
    }
}





