Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

/*int roll1 = 6;
int roll2 = 6;
int roll3 = 6;*/

int total = roll1 + roll2 + roll3;

Console.Clear();
Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}\n");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Ojooo tres en racha, mas puntos en camino!!!\n");
        total += 6;
    }else{
        Console.WriteLine("Obtuviste puntos extra hijo!!!\n");
        total += 2;
    }
}     

if(total >= 16)
{
    Console.WriteLine($"Ganaste un auto nuevo!\n");
    Console.WriteLine($"Nuevo total: {total}\n");
}
else if(total >= 10)
{
    Console.WriteLine($"Ganaste una Laptop nueva!\n");
    Console.WriteLine($"Nuevo total: {total}\n");
}
else if(total >= 7)
{
    Console.WriteLine("Ganaste un viaje todo pagado!\n");
    Console.WriteLine($"Nuevo total: {total}\n");
}
else
{
    Console.WriteLine("Ganaste un gatito :D");
    Console.WriteLine($"Nuevo total: {total}\n");
}