using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> enTr = new MyDictionary<string, string>();
            enTr.Add("Pencil", "Kalem");
            enTr.Add("Book", "Kitap");
            enTr.Add("Plate", "Tabak");
            enTr.Add("Table", "Masa");
            enTr.Add("School", "Okul");
            enTr.Add("Car", "Araba");

            enTr.Write();
        }
    }
}
