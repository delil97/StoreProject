using StoreBackend;
using System;
using System.Collections.Generic;

namespace TestStoreBackend
{
    class Program
    {
        static void Main(string[] args)
        {
          
          
            //User user = new User()
            //{
            //    FirstName = "Erik",
            //    LastName = "Holm",
            //    Password = 12345
            //};

            //users.Add(user);



            using (var db = new StoreContext())
            {

                    //Todo Hämta ut information i databasen;

                    //Todo Hämta ut en lista av users från databasen

                    //Todo Ta bort någon user från databasen;

                     // Todo skapa nytt StoreFrontend projekt och kolla om den fungerar

                     // Todo BÄNKA 1240 KG

            }
                Console.WriteLine("Hello World!");


            GetUsers();
        }

        private static void GetUsers()
        {
            GetUsers();
        }
    }
}
