Console.ForegroundColor = ConsoleColor.Magenta;
string[] zajmy = { "Hry", "Cestování", "Fotbal" };

Console.WriteLine("Ahoj jsem Marek Flach, chodím na SŠ Educhem a baví mě:");

foreach(var PoleZajmu in zajmy)
{
    Console.WriteLine(PoleZajmu);
}