namespace ShootingDice;

// A Player whose roll will always be in the upper half of their possible rolls
public class UpperHalfPlayer : Player
{
    public override int Roll()
    {
        int min = (DiceSize / 2) + 1;
        return new Random().Next(min, DiceSize + 1);
    }
}
