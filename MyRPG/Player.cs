using System;

namespace Player
{
    public class Player
    {
       private int xp;
       private float health;
       public string Name {get; }

       public int XP
       {
        get => xp;
        set
        {
            if (value > xp)
            {
                xp = value;
            }
        }

       }
      
    }
}