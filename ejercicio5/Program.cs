Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.Clear();
if(daysUntilExpiration == 1)
{
    discountPercentage = 20;
}
else if(daysUntilExpiration <= 5)
{
    discountPercentage = 10;
}


if(daysUntilExpiration == 0)
{
    Console.WriteLine("\nTu suscripcion ha expirado");
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine(@$"
Tu suscripcion expira mañana
renueva ahora y obten {discountPercentage}% de descuento!");
}
else if(daysUntilExpiration <= 5)
{
    Console.WriteLine(@$"
Tu suscripcion expira en {daysUntilExpiration} dias!
renueva ahora y obten {discountPercentage}% de descuento!");
}
else if(daysUntilExpiration <= 10)
{
    Console.WriteLine("\nTu suscripcion expirara pronto!");
}

Console.WriteLine(daysUntilExpiration == 0 ? "\nExpiró" : "\nQuedan " + daysUntilExpiration + " dias restantes\n");
