using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kullanicilar = new Dictionary<int, string>();
            Kullanicilar.Add(1, "Umut");
            Kullanicilar.Add(2, "Mehmet");
            
            

            var myDictionary = new Dictionary<int , string>();
            myDictionary.Add(3, "Fatih");
            myDictionary.Add(4, "Cemil");
            myDictionary.Add(5, "Ahmet");
            

            foreach (var kullanicilar in Kullanicilar)
            {
                Console.WriteLine("ID : " +kullanicilar.Key + " " + " İsim :" + kullanicilar.Value);
            }
            Console.WriteLine("Birinci Dictionarydeki eleman sayısı : " +Kullanicilar.Count);
            Console.WriteLine("-------------------------------------------");
            foreach (var dictionary in myDictionary)
            {
                Console.WriteLine("ID : " + dictionary.Key + " " + " İsim :" + dictionary.Value);
            }
            Console.WriteLine("İkinci Dictionarydeki eleman sayısı :" +myDictionary.Count);
        }
    }
}
