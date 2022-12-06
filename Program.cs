using Battle_Royale;

Enemy e1 = new Enemy(1);
Enemy e2 = new Enemy(2);
Enemy[] combatants = new Enemy[] { e1, e2 };
int combAlive = combatants.Length;
int round = 0;
while (combAlive > 1)
{
    Console.WriteLine("-- " + round++ + " --");
    foreach (var c in combatants)
    {
        var x = c.PickOpponent(combatants);
        c.Attack(2, x);
    }
    combAlive = 0;
    foreach (var c in combatants)
    {
        if (c.IsAlive) combAlive++;
        Console.WriteLine(c);
    }
}


