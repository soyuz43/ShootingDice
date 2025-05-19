namespace ShootingDice;

// A Player who always rolls in the upper half of their possible roll and
// throws an exception when they lose
public class SoreLoserUpperHalfPlayer : Player
{
    public override int Roll()
    {
        // Upper half starts at (DiceSize / 2) + 1, ends at DiceSize
        int min = (DiceSize / 2) + 1;
        return new Random().Next(min, DiceSize + 1);
    }

    public override void Play(Player other)
    {
        int myRoll = this.Roll();
        int theirRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {theirRoll}");

        if (myRoll > theirRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < theirRoll)
        {
            // The sore loser moment
            throw new Exception($"{Name} loses and throws a fit! 😡");
        }
        else
        {
            Console.WriteLine("It's a tie");
        }
    }
}
