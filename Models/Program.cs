using System;
using System.Collections.Generic;
using ToDoList.Models;
namespace ToDoList {
  public class Program
  {
    public static List<string> userList = new List<string>();
    public static void Main()
    {
      Console.WriteLine("Welcome to the Main Menu!");
      Console.WriteLine("--------------------------");
      Console.WriteLine("Would you like to add an item to your list?['Yes' for yes, 'Enter' for no]");
      string answer = Console.ReadLine();

      if (answer == "yes" || answer == "Yes")
      {
        AddItem();
      } 
      else 
      {
        Console.WriteLine("Would you like to review your list?['Y' for yes, 'Enter' for no]");
        string lookUpItems = Console.ReadLine();

        if (lookUpItems == "Y")
        {
          ListItems();
        }
        else
        {
          Console.WriteLine("Would you like to exit program or return to Main Menu? ['X' to exit, 'Return' for Main Menu");
          string finalAnswer = Console.ReadLine();

          if (finalAnswer == "X")
          {
            Console.WriteLine("Goodbye, anonymous loser!");
          }
          else
          {
            Main();
          }
        }
      }
    }
    public static void AddItem()
    {
      Console.WriteLine("NEW ITEM");
      Console.WriteLine("Please enter task description");
      string itemName = Console.ReadLine();
      userList.Add(itemName);
      Console.WriteLine(itemName + " has been added to your list");
      Main();
    }

    public static void ListItems()
    {
      userList.ForEach(Console.WriteLine);
      Console.WriteLine("Press 'Return' to navigate to Main Menu, or 'X' to Exit program");
      string finalLoop = Console.ReadLine();

      if (finalLoop == "X" || finalLoop == "x")
      {
        Console.WriteLine("Goodbye, anonymous loser!");
      }
      else
      {
        Main();
      }
    }
  }
}
