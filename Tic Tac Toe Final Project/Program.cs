//Hello from Violeta TEST
//Hello from Indre TEST
//Hello from Linda TEST
class Program
{
    static void Main(string[] args)
    {
        // We use do-while because we need to get inside the loop and check condition later STEP 9
        do
        {
            Display(1);// Method should be declared, so we can use it STEP 6
            GameBoard(); //STEP 8
                         // Adding user input STEP 4
            string userInput = Console.ReadLine();
            Console.Clear();
        }
        while (true);
        
        char[] boardSquares = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // STEP 1

        //Create an array for the game board

        //Check for the winner (if gameStatus = 0 we are still playing)

        //Creating display with the players STEP 2

        //Creating gameBoard STEP 3
        Console.WriteLine("1 | 2 | 3");
        Console.WriteLine("**|***|***");
        Console.WriteLine("4 | 5 | 6");
        Console.WriteLine("**|***|***");
        Console.WriteLine("7 | 8 | 9");
        Console.WriteLine("**|***|***");


        //Creating a method not to repeat the Display all the time until we get a winner/draw STEP 5
        static void Display(int PlayerNumber)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("\nPlayer 1 plays with 'X'");
            Console.WriteLine("Player 2 plays with 'O'");
            Console.WriteLine();
            Console.WriteLine($"Player {PlayerNumber} in order to move, choose a number from 1-9");
            Console.WriteLine();
        }
        //Creating a method not to repeat the board all the time until we get a winner/draw STEP 7
        static void GameBoard()
        {

        }
    }
}