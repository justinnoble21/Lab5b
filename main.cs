using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("How many cars are there?");
    int cars = Int32.Parse(Console.ReadLine());

    for (int i = 1; i < cars + 1; i++) {
      Console.WriteLine ("Enter the distance covered by Car #" + i);
      int distance = Int32.Parse(Console.ReadLine());

      Console.WriteLine ("Enter the time taken by Car #" + i);
      int time = Int32.Parse(Console.ReadLine());

      int speed = distance / time;

      Console.WriteLine ("The speed for Car #" + i + " is " + speed + " miles per hour.");
    }

  }
}