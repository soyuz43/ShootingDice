namespace ShootingDice;

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    // The taunt this player will say
    public string Taunt { get; set; } = "You're going down!";

    public override void Play(Player other)
    {
        Console.WriteLine($"{Name} says: \"{Taunt}\""); // Say the taunt
        base.Play(other); // Then proceed with the default behavior
    }
}
