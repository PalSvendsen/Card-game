namespace cardgame
{
    class Program
    {
        static void Main()
        {
            string[] cards = { "Clubs", "Hearts", "Spades", "Diamonds" };
            Random random = new Random();
            var randomIndex = random.Next(cards.Length);
            Random Number = new Random();
            var numIndex = random.Next(1, 11);
            Random higher = new Random();
            string[] high = { "Joker", "Ace", "King", "Queen" };
            var highIndex = random.Next(high.Length);
            string randomHigh = high[highIndex];
            string randomCards = cards[randomIndex];
           
            Console.WriteLine($"Your random card is {numIndex} of {randomCards}. Your special card is {randomHigh}");

        }
    }
} 

