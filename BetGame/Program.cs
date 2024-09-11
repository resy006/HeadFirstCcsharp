using Bank;

Random random = new Random();
double odds = 0.1;

Guy player = new Guy() { Name = "The player", Cash = 100 };
Console.WriteLine("Wellcome to the casino. The odds are " + odds);
while (player.Cash > 0)
{
    player.WriteMyInfo();

    Console.Write("How much do you want to bet :");
    string howMuch = Console.ReadLine();

    if(int.TryParse(howMuch, out int amount))
    {
        int pot = amount * 2;

        double number = random.NextDouble() * (1.0 - 0.0) + 0.0;

        if (number > odds)
        {
            Console.WriteLine("Good luck you win.");
            player.Cash += pot;
        }
        else
        {
            Console.WriteLine("Bad luck you lose.");
            player.Cash -= amount;
        }
    }
    else
    {
        Console.WriteLine("Please enter a number");
    }

}
