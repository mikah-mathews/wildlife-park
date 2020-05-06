using System;
using ParkTracker;
using System.Collections.Generic;

namespace Something
{
  public class Program
  {
    public static void Main()
    {
      List<Animals> animals = new List<Animals>();
      string command = "";
      while (command != "quit")
      {
        Console.WriteLine("Do you want to add an animal, find an animal, list all animals or quit (add, find, list, quit)");
        command = Console.ReadLine();

        if (command == "add")
        {
          //Animals animal = new Animals("Tricks", 1, "ardvark", "male", "ants", "forest");
          //animals.Add(animal);
          Console.WriteLine("What is the Animal's name?");
          string name = Console.ReadLine();
          Console.WriteLine("What is the Animal's age?");
          string ageInput = Console.ReadLine();
          int age = int.Parse(ageInput);
          Console.WriteLine("What is the Animal's species");
          string species = Console.ReadLine();
          Console.WriteLine("What is the Animal's sex?");
          string sex = Console.ReadLine();
          Console.WriteLine("What is the Animal's diet?");
          string diet = Console.ReadLine();
          Console.WriteLine("What is the Animal's environment?");
          string environment = Console.ReadLine();
          Animals newAnimal = new Animals(name, age, species, sex, diet, environment);
          animals.Add(newAnimal);
        }
        else if (command == "find")
        {
          Console.Write("Enter the name of the animal you're looking for: ");
          string animalName = Console.ReadLine();
          bool foundAnimal = false;

          for (int i = 0; i < animals.Count; i++)
          {
            if (animals[i].GetName() == animalName)
            {
              foundAnimal = true;
              Console.WriteLine("We found " + animals[i].GetName());
              Console.WriteLine("-----------------");
              Console.WriteLine("Name: " + animals[i].GetName());
              Console.WriteLine("Age: " + animals[i].GetAge());
              Console.WriteLine("Species: " + animals[i].GetSpecies());
              Console.WriteLine("Sex: " + animals[i].GetSex());
              Console.WriteLine("Diet: " + animals[i].GetDiet());
              Console.WriteLine("Environment: " + animals[i].GetEnvironment());
              Console.WriteLine("-----------------");
            }
          }

          if (!foundAnimal)
          {
            Console.WriteLine("We couldn't find " + animalName + ". Maybe it escaped.");
          }
        }
        else if (command == "list")
        {
          Console.WriteLine("Here are all of the animals!");
          Console.WriteLine("-----------------");
          for (int i = 0; i < animals.Count; i++)
          {
            Console.WriteLine("-----------------");
            Console.WriteLine("Name: " + animals[i].GetName());
            Console.WriteLine("Age: " + animals[i].GetAge());
            Console.WriteLine("Species: " + animals[i].GetSpecies());
            Console.WriteLine("Sex: " + animals[i].GetSex());
            Console.WriteLine("Diet: " + animals[i].GetDiet());
            Console.WriteLine("Environment: " + animals[i].GetEnvironment());
            Console.WriteLine("-----------------");
          }
        }
      }
    }
  }
}