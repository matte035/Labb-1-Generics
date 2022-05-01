using Labb_1___Generics.Models;
using System;
using System.Collections.Generic;

namespace Labb_1___Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LadaCollection lada = new LadaCollection();

            ICollection<Låda> ladaCollection = new LadaCollection(); 

            ladaCollection.Add(new Låda(5,5,5));
            ladaCollection.Add(new Låda(10, 10, 10));
            ladaCollection.Add(new Låda(20, 20, 20));
            ladaCollection.Add(new Låda(15, 15, 15));
            ladaCollection.Add(new Låda(25, 25, 25));

            DisplayList(ladaCollection);

            CheckIfContains(ladaCollection,new Låda(5,5,5));//skall svara att lådan finns redan
            CheckIfContains(ladaCollection, new Låda(4, 4, 4));//skall svara att lådan inte finns
            DisplayList(ladaCollection);
            ladaCollection.Remove(new Låda(5, 5, 5));// om true är sant så tas lådan bort
            DisplayList(ladaCollection);
        }

        static void CheckIfContains(ICollection<Låda>collection,Låda lada)
        {
            LadaCollection list = collection as LadaCollection;
            if (list.Contains(lada))
            {
                Console.WriteLine("Lådan finns redan");
            }
            else
            {
                Console.WriteLine("Lådan finns inte");
            }

        }
        static void DisplayList(ICollection<Låda>collection)
        {
            
            foreach (var item in collection)
            {
                Console.WriteLine(item.längd + " " + item.höjd + " " + item.bredd );
            }
        }
    }
}
