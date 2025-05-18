using System;
using ShootingDice;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; } = "You're going down!";

        public override void Play(Player other)
        {
            Console.WriteLine($"{Name} says: {Taunt}");
            base.Play(other);
        }
    }
}
