using RockPaperScissors;

SimpleGameManager gm = new SimpleGameManager();

do
{
    RoundResult result = gm.PlayRound();

    if (result == RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 Wins!");
    }
    else if (result == RoundResult.Player2Win)
    {
        Console.WriteLine("Player 2 Wins!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }

    Console.Write("Play again (Y/N)? ");
} while (Console.ReadLine().ToUpper() == "Y");