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
       public int Level
       {
        get
        {
            return 1 + XP /1000;
        }
       }
       public float Health
       {
        get => health;
        private set
        {
            health = value;
            if (health < 0 )
                health = 0;
            if (health > MaxHealth)
                health = MaxHealth;

        }
       }
       public float MaxHealth
        {
            get
            {
                return 100 + (Level-1)*20
            }
        }

        
    }
}