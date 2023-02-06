class boxer
{
    int health;
    Random rando = new Random();

    public void actionDecider()
    {
        if (health > 25)
        {
            if (rando.Next(0, 100) >= 50)
            {
                boxer.attack();
            }
            else
            {
                boxer.block();
            }
        }
    }

    public void attack()
    {
        int magicNumber = rando.Next(0, 100);
        if (magicNumber < 40)
        {
            boxer.rightHook();
        }
        else if (magicNumber >= 40 && magicNumber < 80)
        {
            boxer.leftHook();
        }
        else
        {
            boxer.uppercut();
        }
    }

    public void block()
    {
        int randoRoll = rando.Next(0, 100);
        if (randoRoll < 35)
        {
            //Hold block for 2 seconds
            boxer.blockFor(2);
        }
        else if (randoRoll >= 35 && randoRoll < 80)
        {
            //Hold block for 3 seconds
            boxer.blockFor(3);
        }
        else
        {
            //Hold block for 4 seconds
            boxer.blockFor(4);
        }
        
    }


}
