using StoreBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using TestStoreBackend.Classes;

namespace TestStoreBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            // All methods are in CRUD class
            CRUD crud = new CRUD();

            // Showing menu from a separate class
            Menu ShowMenu = new Menu();


            // Using while to loop through the list 
            bool listRunning = true;
            while (listRunning)
            {
                
                char ch;
                ShowMenu.ShowMenu();
                ch = char.Parse(Console.ReadLine());

                switch (ch)
                {
                    //Create
                    case '1':
                        crud.Create(); 
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                        //Read
                    case '2':
                        crud.Read(); 
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                        //Update
                    case '3':
                        crud.Read();// Displaying all the users from the database, application user then can update a user by giving the Id.
                        crud.Uppdate();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    //Delete
                    case '4':
                        crud.Read(); // Displaying all the users from the database, application user then can delete a user by giving the Id.
                        crud.Delete();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;


                }

            }

            // ----Implement this simple login later----

            // User user = new User()
            // {
            //     FirstName = "Erik",
            //     LastName = "Holm",
            //     Password = 123
            // };

            // db.User.Add(user);
            // db.SaveChanges();

            // var userIsValid = from u in db.User where u.FirstName == "Erik" && u.Password == 123 select u;

            // if(userIsValid.Count() >= 0)
            // {
            //     Console.WriteLine("You are logged in!");
            // }

        }
    }
}
