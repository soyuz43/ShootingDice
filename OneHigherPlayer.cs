namespace ShootingDice;

// A player who always rolls one higher than the other player
public class OneHigherPlayer : Player
{
    public override void Play(Player other)
    {
        int otherRoll = other.Roll();
        int myRoll = otherRoll + 1;

        // Clamp roll if it exceeds dice size
        if (myRoll > DiceSize)
        {
            myRoll = DiceSize;
        }

        Console.WriteLine($"{Name} rolls a {myRoll} (cheated)");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else
        {
            Console.WriteLine("It's a tie");
        }
    }
}
