using System;

namespace Metoder
{
  class Program
  {
    static void Main(string[] args)
    {
      // int[,] grid = new int[8,10];

      // for (int x = 0; x < grid.GetLength(0); x++)
      // {
      //   for (int y = 0; y < grid.GetLength(1); y++)
      //   {
      //     Console.WriteLine("X: " + x + ", Y: " + y);
      //     grid[x, y] = 12;
      //   }
      // }

      Enemy herbert = new Enemy();
      Enemy albert = new Enemy();

      herbert.Scream();
      albert.Scream();

      herbert.Hurt(8);


      Console.ReadLine();
    }
  }
}
