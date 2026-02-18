using System;

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

        int spel=Random.Shared.Next(2); 
        if (Patience==0)
        {
            Console.WriteLine("Du får inget körkort");
        }
        else if (spel==1)
        {
            Console.WriteLine("Du lyckades");
            TheorySkill +=5; 
        }
        else  
        {
            Console.WriteLine("Du misslyckades");
            Patience--; 
        }
        // ingen patience kvar? misslyckas!
        // lyckas? theoryskill++
        // misslyckas? patience--
    }
    public void LearnDriving()
    {
        int pal=Random.Shared.Next(2); 
        if (Patience==0)
        {
            
        }
    }
    public bool TakeTest()
    {
        return HasLicence=true; 
    }
}
