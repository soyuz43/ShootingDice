namespace ShootingDice;

// A Player that throws an exception when they lose to the other player
public class SoreLoserPlayer : Player
{
    public override void Play(Player other)
    {
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

        if (myRoll < otherRoll)
        {
            throw new Exception($"{Name} loses and throws a fit!");
        }
        else if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} wins!");
        }
        else
        {
            Console.WriteLine("It's a tie.");
        }
    }
}
