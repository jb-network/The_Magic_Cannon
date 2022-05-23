// This is challenge work for the "C# Players Guide"
// Level 11 the Magic Cannon Challenge
// Build a simple program to create a loop fires a cannon in the following manner:
// Every 3rd crank of the cannon produces a fire bast
// Every 5th crank of the cannon produces an electric blast
// When fire and electric overlap, a combined blast is created
// All other cranks provide a normal output
// Firing should go from 1 to 100 times

//Simple themed intro for challenge
Console.WriteLine("Welcome to the cannon fire simulation program!");
Console.WriteLine("This program will crank the cannon 100 times to see what is produced");
Console.WriteLine("Press any key to begin simulation");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Firing 100 simulation rounds!");

//Firing sequence loop
for (int fireRound = 1; fireRound <= 100; fireRound++)
{
    string roundType;

    if (fireRound % 3 == 0 && fireRound % 5 == 0)
    {
        roundType = "Combo Fire & Electric";
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    
    else if (fireRound % 3 == 0)
    {
        roundType = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;
    }
    
    else if (fireRound % 5 == 0)
    {
        roundType = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    
    else
    {
        roundType = "Normal";
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    Console.WriteLine($"Firing Round {fireRound}: Round Type Generated: {roundType}");
}

// Restore console color to default and end simulation
Console.ResetColor();
Console.WriteLine("Press any key to end the simulation");
Console.ReadKey();





