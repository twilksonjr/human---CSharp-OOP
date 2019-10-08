using System;
using System.Collections.Generic;

namespace OOP
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Human myHuman = new Human("Tim");
      Human anotherHuman = new Human("Landon", 4, 5, 6, 150);
      System.Console.WriteLine($"anotherHuman current health is{anotherHuman.Health}");
      myHuman.Attack(anotherHuman);


      // Console.WriteLine($"Enter your Humans name {Name}");
      System.Console.WriteLine($"myHuman's name is {myHuman.Name} his strength is {myHuman.Strength}");
      System.Console.WriteLine($"anotherHuman's name is {anotherHuman.Name}");

      System.Console.WriteLine($" Return health is {anotherHuman.Health}");



    }

    public class Human
    {
      // all of your variables and fields
      public string Name;
      public int Strength;
      public int Intelligence;
      public int Dexterity;
      private int health;
      // private int Attack;

      // getter 
      public int Health
      {
        get { return health; }
      }

      // constructor -methods- function, that creates the instance of human (the blueprint)
      public Human(string val)
      {
        Name = val;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
        // Attack = 5;
      }
      // 2nd Human constructor - overloading
      public Human(string name, int strength, int intelligence, int dexterity, int _health)
      {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        health = _health;

      }
      public int Attack(Human target)
      {
        int attackDamage = Strength * 5;
        target.health -= attackDamage;
        return target.health;
      }


    }



    // public void SayHi()
    // {
    //   System.Console.WriteLine("Hi");
    // }

    // // This is a plain function
    // SayHi();

    // // This is a method of the List class (it is also a function)
    // List<int> myList = new List<int>() {1,2,3};
    // myList.Add(4);

    // // This is a constructor of the Human class (it is also a method, it is also a function)
    // Human myHuman = new Human("Bob");
  }
}