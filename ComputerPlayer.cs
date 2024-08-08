namespace RockPaperScissors;

public class ComputerPlayer : IPlayer
{
    private Random _random = new Random();
    public Choice GetChoice()
    {
        Choice p2 = (Choice)_random.Next(0, 3);
        //Console.WriteLine("Player 2 picked {0}", p2.ToString());
        return p2;
   }
}