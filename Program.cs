// Build Dice Game
Console.WriteLine("==== Simple Dice Game====\nType 'Start' or 'S' to roll the die");
string startGame = Console.ReadLine()!;

while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase)|| startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{

    Console.ForegroundColor = ConsoleColor.Darkred;
    Console.WriteLine("Invalid Key word provided: ");
    Console.ResetColor();
    Console.WriteLine("To start this game enter Start");
    Console.ResetColor();
    startGame= Console.ReadLine()!;

}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;

const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree) 
{
        totalPoint += TRIPLE_POINT;

        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a triple! You have a {totalPoint} Points");
}

if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;
        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou have a {totalPoint} Points");
}
else
{
        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou have a {totalPoint} Points");
        }

        if (totalPoint >= 10 && totalPoint <=13)
        {
            Console.WriteLine("Congratulations! You have won a balloon");
        }

        if (totalPoint >= 14 && totalPoint <= 16)
        {
           Console.WriteLine("Congratulations! You've won an exercise Book");
        }

        if (totalPoint == 17)
        {
            Console.WriteLine("Congratulations You have won a 5000mAh powerBank");
        }
        
        if (totalPoint >= 18 && totalPoint <= 20)
        {
            Console.WriteLine("Congratulations! You have won a ticket to silverbird cinema");
        }

        if (totalPoint == 21 )
        {
            Console.WriteLine("Congratulations! You just rolled a lucky number, and have won a gift of Samsung A21");
        }

        if (totalPoint >= 22 && totalPoint <= 24)
        {
            Console.WriteLine("Congratulations! You have won all the items on the list");
        }

