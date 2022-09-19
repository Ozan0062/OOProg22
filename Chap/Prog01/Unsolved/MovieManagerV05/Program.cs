string year = "2022";

string ratio = "16:9";

string actors = "Robert Pattinson, Jefrey Wrigt, Paul Dano,";

string genre = "Action";

string title = "The Batman";

int lenghtInMinutes = 176;

double incomeInMillionDollar = 770.8; 

string distributor = "Warner Bros";

int budgetInMillionDollar = 200;

double IMDb = 7.9;

string director = "Matt Reeves";

// 3 måder at skrive tekst i consol
Console.Write("Filmen varer ");
Console.Write(lenghtInMinutes );
Console.WriteLine(" minutter");

string tekst = "Filmen varer " +
               lenghtInMinutes +
               " minutter";
Console.WriteLine(tekst);

string tekst2 = $"Filmen varer {lenghtInMinutes} minutter";
Console.WriteLine(tekst2);


// Sandt eller falsk 
int money = 10000;

bool isRich = (money > 100000);

Console.WriteLine(isRich);
