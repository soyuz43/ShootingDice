using ShootingDice;

// Create base players
Player player1 = new Player() { Name = "Bob" };
Player player2 = new Player() { Name = "Sue" };
player2.Play(player1);

Console.WriteLine("-------------------");

Player player3 = new Player() { Name = "Wilma" };
player3.Play(player2);

Console.WriteLine("-------------------");

// LargeDicePlayer
Player large = new LargeDicePlayer() { Name = "Bigun Rollsalot" };
player1.Play(large);

Console.WriteLine("-------------------");

// SmackTalkingPlayer
Player smack = new SmackTalkingPlayer() { Name = "Chad", Taunt = "You're going down!" };
smack.Play(player1);

Console.WriteLine("-------------------");

// CreativeSmackTalkingPlayer
Player creativeSmack = new CreativeSmackTalkingPlayer() { Name = "Lex Luthor" };
creativeSmack.Play(player2);

Console.WriteLine("-------------------");

// OneHigherPlayer
Player oneHigher = new OneHigherPlayer() { Name = "Sneaky PlusOne" };
oneHigher.Play(player2);

Console.WriteLine("-------------------");

// SoreLoserPlayer
Player sore = new SoreLoserPlayer() { Name = "Salty Sam" };
try
{
    sore.Play(player1);
}
catch (Exception ex)
{
    Console.WriteLine($"[!]  {sore.Name} had a meltdown: {ex.Message}");
}

Console.WriteLine("-------------------");

// HumanPlayer (prompts user input)
Player human = new HumanPlayer() { Name = "You" };
Console.WriteLine("👤 Human player will now roll against Bigun Rollsalot:");
human.Play(large);

Console.WriteLine("-------------------");

// All players
List<Player> players = new List<Player>()
{
    player1,
    player2,
    player3,
    large,
    smack,
    creativeSmack,
    oneHigher,
    sore,
    human
};

PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    Random rng = new Random();
    List<Player> shuffled = players.OrderBy(p => rng.Next()).ToList();

    // Ensure even number of players
    if (shuffled.Count % 2 != 0)
    {
        shuffled.RemoveAt(shuffled.Count - 1);
    }

    for (int i = 0; i < shuffled.Count; i += 2)
    {
        Console.WriteLine("-------------------");
        Player p1 = shuffled[i];
        Player p2 = shuffled[i + 1];

        try
        {
            p1.Play(p2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[!]  Match interrupted: {ex.Message}");
        }
    }
}
