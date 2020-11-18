using StoreBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStoreBackend.Classes
{
   public class CRUD
    {
        //Create method
        public void Create()
        {
            using (var db = new StoreContext())
            {     
                Console.WriteLine("Add a new user by typing: FirstName, LastName and Password");
                User user = new User()
                {

                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Password = int.Parse(Console.ReadLine())

                };
                db.User.Add(user);
                Console.WriteLine("Press enter to save changes.");
                Console.ReadLine();
                db.SaveChanges();
                Console.WriteLine("The user has been saved in the database!");
            }
        }
        //Read method
        public void Read()
        {

            using (var db = new StoreContext())
            {
                foreach (var item in db.User.ToList())
                {
                    Console.WriteLine("Id: " + item.Id + "\n"
                        + " User name: " + item.FirstName + "\n" + " Last Name: "
                        + item.LastName + "\n" + " Password: " + item.Password);
                }

            }

        }
        //Update method
        public void Uppdate()
        {
            using (var db = new StoreContext())
            {
                Console.ForegroundColor = ConsoleColor.Red; // Changing color
                Console.WriteLine("Type the id of the user you would like to uppdate:");
                User userUpdate = db.User.Find(int.Parse(Console.ReadLine()));

                userUpdate.FirstName = Console.ReadLine();
                userUpdate.LastName = Console.ReadLine();


                Console.WriteLine("Press enter to save changes.");
                db.SaveChanges();
                Console.ReadLine();



            }
        }
        //Delete method
        public void Delete()
        {
            using (var db = new StoreContext())
            {
                Console.ForegroundColor = ConsoleColor.Red; // Changing color
                Console.WriteLine("Type the id of the user you would like to remove:");
                User userRemove = new User()
                {
                    Id = Int32.Parse(Console.ReadLine())
                };
                db.User.Remove(userRemove);
                Console.WriteLine("Press enter to save changes.");
                db.SaveChanges();
                Console.ReadLine();
            }
        }
    }
}
