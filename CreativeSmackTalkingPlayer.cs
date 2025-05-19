namespace ShootingDice;

// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    private static readonly string[] Taunts = new[]
    {
        "You're no match for me!",
        "Is that all you've got?",
        "I'll roll over you!",
        "Prepare to be crushed!",
        "You're going down!",
        "Say goodbye to your pride!",
        "Hope you like losing!",
        "This won't even be close!"
    };

    private static readonly Random _rng = new();

    public override void Play(Player other)
    {
        string taunt = Taunts[_rng.Next(Taunts.Length)];
        Console.WriteLine($"{Name} says: \"{taunt}\"");

        base.Play(other);
    }
}
