namespace ShootingDice;

// A player that prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
    public override int Roll()
    {
        int roll;
        Console.Write($"{Name}, enter your roll (1–{DiceSize}): ");

        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out roll) && roll >= 1 && roll <= DiceSize)
            {
                return roll;
            }

            Console.Write($"Invalid input. Please enter a number between 1 and {DiceSize}: ");
        }
    }
}
