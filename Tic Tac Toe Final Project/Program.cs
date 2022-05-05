//Hello from Violeta TEST
//Hello from Indre TEST
//Hello from Linda TEST
class Program
{
    static void Main(string[] args)
    {
        int currentPlayer = -1; // Declare new variable STEP 10

        char[] boardSquares = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // STEP 1 , STEP 11
        // We use do-while because we need to get inside the loop and check condition later STEP 9
        do
        {
            currentPlayer = GetNextPlayer(currentPlayer); // STEP 10.2 

            Display(currentPlayer);// Method should be declared, so we can use it STEP 6
            GameBoard(boardSquares); //STEP 8 and STEP 12.1
                         // Adding user input STEP 4
            string userInput = Console.ReadLine();
            Console.Clear();
        }
        while (true);
        
        

        //Create an array for the game board

        //Check for the winner (if gameStatus = 0 we are still playing)

        //Creating display with the players STEP 2

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
        static void GameBoard(char [] boardSquares)
        {
            //Creating gameBoard STEP 3 , Update the method GameBoard() with array values STEP 12 
            Console.WriteLine($"{boardSquares[0]} | {boardSquares[1]} | {boardSquares[2]}");
            Console.WriteLine("**|***|***");
            Console.WriteLine($"{boardSquares[3]} | {boardSquares[4]} | {boardSquares[5]}");
            Console.WriteLine("**|***|***");
            Console.WriteLine($"{boardSquares[6]} | {boardSquares[7]} | {boardSquares[8]}");
            Console.WriteLine("**|***|***");
        }

        static int GetNextPlayer(int player) // Create a new method (GetNextPlayer) STEP 10.1
        {
            if (player == 1)
            {
                return 2;
            }
            return 1;
        }
    }
}