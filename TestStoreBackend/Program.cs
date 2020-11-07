﻿using StoreBackend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestStoreBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StoreContext())
            {
               
                // Read
                var usr = db.User
                    .OrderBy(b => b.FirstName)
                    .First();
                Console.ReadLine();
                Console.WriteLine(usr.FirstName);


                // Delete
                Console.WriteLine("Delete user");
                db.Remove(usr);
                db.SaveChanges();
            }    
            // Todo Hämta ut information i databasen; // Check

            // Todo Hämta ut en lista av users från databasen // check

            // Todo Ta bort någon user från databasen; // check

            // Todo skapa nytt StoreFrontend projekt och kolla om den fungerar check


        }
    }
}
