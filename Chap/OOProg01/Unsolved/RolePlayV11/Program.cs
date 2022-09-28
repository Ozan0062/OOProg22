
Warrior warriorA = new Warrior("Ragnar" , 150);
Warrior warriorB = new Warrior("Lagertha" , 140);

Console.WriteLine($"In beggining");
Console.WriteLine($"Warrior A is called {warriorA.Name}, " +
                  $"is level {warriorA.Level}, " +
                  $"and has {warriorA.HitPoint} hitpoints, " +
                  $"(is dead= {warriorA.Dead})");
Console.WriteLine($"Warrior B is called {warriorB.Name}, " +
                  $"is level {warriorB.Level}, " +
                  $"and has {warriorB.HitPoint} hitpoints, " +
                  $"(is dead= {warriorB.Dead})");


// first damage
warriorA.Damage(60);
warriorB.Damage(60);

Console.WriteLine($" ");
Console.WriteLine($"In first damage");
Console.WriteLine($"{warriorA.Name}, " +
                  $"has {warriorA.HitPoint} hitpoints, " +
                  $"(is dead= {warriorA.Dead})");
Console.WriteLine($"{warriorB.Name}, " +
                  $"has {warriorB.HitPoint} hitpoints, " +
                  $"(is dead= {warriorB.Dead})");

// second damage
warriorA.Damage(20);
warriorB.Damage(20);

Console.WriteLine($" ");
Console.WriteLine($"In second damage");
Console.WriteLine($"{warriorA.Name}, " +
                  $"has {warriorA.HitPoint} hitpoints, " +
                  $"(is dead= {warriorA.Dead})");
Console.WriteLine($"{warriorB.Name}, " +
                  $"has {warriorB.HitPoint} hitpoints, " +
                  $"(is dead= {warriorB.Dead})");

// third damage
warriorA.Damage(60);
warriorB.Damage(60);

Console.WriteLine($" ");
Console.WriteLine($"In third damage");
Console.WriteLine($"{warriorA.Name}, " +
                  $"has {warriorA.HitPoint} hitpoints, " +
                  $"(is dead= {warriorA.Dead})");
Console.WriteLine($"{warriorB.Name}, " +
                  $"has {warriorB.HitPoint} hitpoints, " +
                  $"(is dead= {warriorB.Dead})");


