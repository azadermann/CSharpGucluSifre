using System;
using System.Drawing;
using System.Text;

internal class Program
{
    public static string GuclluSifre(int lenght)
    {
        const string chars = "0123456789qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < lenght; i++)
        {
            int indeks = rnd.Next(chars.Length);
            sb.Append(chars[indeks]);
        }
        return sb.ToString();
    }

    private static void Main(string[] args)
    {
        Console.Write("Bir Şifre Uzunluğunu Giriniz Ör: 12 ==> ");
        int lnght = Convert.ToInt32(Console.ReadLine());

        string sifre = GuclluSifre(lnght);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                                                Yeni Şifre Güçlü Şifre                               ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(sifre);
        

        Console.ReadLine();
        



    }
}