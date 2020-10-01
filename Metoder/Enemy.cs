using System;

namespace Metoder
{
    public class Enemy
    {

      

      private Random generator = new Random();

      public int hp = 0;

      public Enemy()
      {
        hp = generator.Next(50, 100);
        Console.WriteLine("Yo dude, I got " + hp + "hp!");
      }

      public void Hurt(int amount)
      {
        hp -= amount;

        if (hp < 0)
        {
          hp = 0;
        }

      }

      public void Scream()
      {

        hp++;

        Console.WriteLine("RAAAWR");
      }

    }
}
