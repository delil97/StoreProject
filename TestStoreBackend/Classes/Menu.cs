using System;
using System.Collections.Generic;
using System.Text;

namespace TestStoreBackend.Classes
{
    class Menu
    {
        public void ShowMenu()
        {

            Console.WriteLine("1) Add a new user");
            Console.WriteLine("2) See all user in database");
            Console.WriteLine("3) Update a information");
            Console.WriteLine("4) Delete user");
            Console.SetCursorPosition(0, 8);

            Console.Write("Please choose a number from above: ");
        }
      
    }
}
