using System;

namespace RekursifVeExtensionMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Reküsif - Öz Yinelemeli Metotlar
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new Islemler();
            Console.WriteLine(instance.UstAl(3,4));


            //Extension Metotlar
            string ifade = "Hello World How Are You";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveSpace());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());


            int[] dizi = { 1, 2, 0, 5, 8, 9, };
            dizi.SortArray();
            dizi.EkranaYazdir();

        }
    }

    class Islemler
    {
        public int UstAl(int sayi, int ust)
        {
            if(ust < 2)
            {
                return sayi;
            }
            else
            {
                return UstAl(sayi, ust - 1) * sayi;
            }
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
    }
}
