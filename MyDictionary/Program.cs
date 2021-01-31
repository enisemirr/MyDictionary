using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();

            ogrenci.Add(1, "Enis");
            ogrenci.Add(1, "Okan");
            ogrenci.Add(1, "Muzaffer");
            ogrenci.Add(1, "Ahmet");
            ogrenci.Add(1, "Serdar");
            ogrenci.Add(1, "Fatih");
            ogrenci.Add(1, "Ersin");
        }
    }
}
