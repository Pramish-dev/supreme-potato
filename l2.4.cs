using System;
using System.Collection.Generic;
 
 class Lab2{
    static void Main(){
        Dictionary<string, int> hashTable = new Dictionary<string, int>(){
            {
                {"One",1},
                {"Two",2},
                {"Three",3}
            };
            Console.WriteLine("Original Hash Table: ");
            PrintHashTable(hashTable);
            hashTable.Remove("Three");

            Console.WriteLine("\n Hash Table after Removing 'Three': ");
            PrintHashTable(hashTable);

        }
        static void PrintHashTable(Dictionary<string, int> hashTable)
        {
            foreach (var kvp in hashTable)
            {
                Console.WriteLine(kvp.key+": "+kvp.Value);
            }
        }
    }
 }