using System;
using System.ComponentModel.DataAnnotations;

namespace omprovtest2;

public class SuperVillain
{
    public string Name;
    public int TheorySkill;
    public int DrivingSkill;
    public int Patience;
    public bool HasLicence;

    public void LearnTheory()
    {
        
        int spel = Random.Shared.Next(2);
        if (Patience == 0)
        {
            Console.WriteLine("Du får inget körkort");
        }
        else if (spel == 1)
        {
            Console.WriteLine("Du lyckades");
            TheorySkill += 5;
        }
        else if (spel == 2)
        {
            Console.WriteLine("Du misslyckades");
            Patience -= 1;
        }

    }
    public void LearnDriving()
    {
        int pal = Random.Shared.Next(2);
        if (Patience == 0)
        {
            Console.WriteLine("Du får inget körkort");
        }
        else if (pal == 1)
        {
            Console.WriteLine("Du lyckades");
            DrivingSkill += 5;
        }
        else if (pal == 2)
        {
            Console.WriteLine("Du misslyckades");
            Patience -= 1;
        }
    }
    public bool TakeTest()
    {
        int play = TheorySkill;
        int steer = DrivingSkill;
    
        
            if (play>=40&&steer>=40)
            {
                Console.WriteLine("Du fick ditt körkort");
                HasLicence=true; 
            }
            else
            {
                Console.WriteLine("Du nådde inte kravet för körkort");
            }
        
        return HasLicence;
    }
}
