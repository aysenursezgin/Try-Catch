using System;

class Program
{
    static void Main()
    {
        try
        {
            // Kullanıcıdan sayı girmesini istemek
            Console.Write("Bir sayı giriniz: ");
            string input = Console.ReadLine();

            // Kullanıcının girdiği değeri sayıya dönüştürmek
            int number = Convert.ToInt32(input);

            // Sayının karesini hesaplamak ve ekrana yazdırmak
            int square = number * number;
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
        }
        catch (FormatException)
        {
            // Eğer kullanıcı geçerli bir sayı girmezse (harf, sembol vb.)
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        catch (Exception ex)
        {
            // Diğer beklenmedik hatalar için genel hata mesajı
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
        }
    }
}

