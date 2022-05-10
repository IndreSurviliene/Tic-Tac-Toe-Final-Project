//Hello from Violeta TEST
//Hello from Indre TEST
//Hello from Linda TEST
using Tic_Tac_Toe_Final_Project;

public class Program
{
    static void Main(string[] args)
    {
       // SQL_connection conn = new SQL_connection();

        
        int gameStatus = 0; // STEP 21  new variable to identify who won or the game was a draw
        int currentPlayer = -1; // Declare new variable STEP 10
       

        Console.WriteLine($"Player 1, enter your nickname");
        string Nickname = Console.ReadLine();
        Console.WriteLine($"Player 2, enter your nickname");
        string Nickname2 = Console.ReadLine();

        char[] boardSquares = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // STEP 1 , STEP 11
        // We use do-while because we need to get inside the loop and check condition later STEP 9
       // UserInput();

        do
        {
            
            Console.Clear();
            currentPlayer = GetNextPlayer(currentPlayer); // STEP 10.2 

            Display(currentPlayer, Nickname, Nickname2);// Method should be declared, so we can use it STEP 6
          
            GameBoard(boardSquares); //STEP 8 and STEP 12.1
                                     // Adding user input STEP 4

            GameCore(boardSquares, currentPlayer); //STEP 13.1
            
            gameStatus = WinnerCheck(boardSquares);
        }
        while (gameStatus == 0); // STEP 21.1 

        if (gameStatus == 1)
        {
            Console.WriteLine($"The player {currentPlayer} is the winner!");
        }

        if (gameStatus == 2)
        {
            Console.WriteLine($"There are no winners. Play again!");
        }

        // new method to check the winner STEP 22
        static int WinnerCheck(char[] boardSquares)
        {
            if (GameDraw(boardSquares))
            {
                return 2;
            }
            if (GameWinner(boardSquares))
            {
                return 1;
            }
            return 0;
        }
        // Checking for all the possible wins STEP 23
        static bool GameWinner(char[] boardSquares)
        {
            if (AreBoardSquaresTheSame(boardSquares, 0, 1, 2))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 3, 4, 5))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 6, 7, 8))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 0, 3, 6))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 1, 4, 7))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 2, 5, 8))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 0, 4, 8))
            {
                return true;
            }
            if (AreBoardSquaresTheSame(boardSquares, 2, 4, 6))
            {
                return true;
            }
            return false;
        }

        //STEP 25 Create a method to check positions for horizontaly, verticaly and ...
        static bool AreBoardSquaresTheSame(char[] testBoardSquares, int pos1, int pos2, int pos3)
        {
            return testBoardSquares[pos1] == testBoardSquares[pos2] && testBoardSquares[pos2] == testBoardSquares[pos3];
        }

        // STEP 26 There is no winner or no looser
        static bool GameDraw(char[] gameMarkers)
        {
            return gameMarkers[0] != '1' &&
                   gameMarkers[1] != '2' &&
                   gameMarkers[2] != '3' &&
                   gameMarkers[3] != '4' &&
                   gameMarkers[4] != '5' &&
                   gameMarkers[5] != '6' &&
                   gameMarkers[6] != '7' &&
                   gameMarkers[7] != '8' &&
                   gameMarkers[8] != '9';
        }
        //Create an array for the game board

        //Check for the winner (if gameStatus = 0 we are still playing)

        //Creating display with the players STEP 2

       /* static void UserInput()
        {
            Console.WriteLine($"Player 1, enter your nickname");
            string Nickname = Console.ReadLine();
            Console.WriteLine($"Player 2, enter your nickname");
            string Nickname2 = Console.ReadLine(); 
        }*/


        //Creating a method not to repeat the Display all the time until we get a winner/draw STEP 5
        static void Display(int PlayerNumber, string Nickname, string Nickname2)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine($"\n{Nickname} is Player 1, plays with 'X'");
            Console.WriteLine($"{Nickname2} is Player 2, plays with 'O'");
            Console.WriteLine();
            Console.WriteLine($"Player {PlayerNumber} in order to move, choose a number from 1-9");
            Console.WriteLine();
        }
        //Creating a method not to repeat the board all the time until we get a winner/draw STEP 7
        static void GameBoard(char[] boardSquares)
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
        static void GameCore(char[] boardSquares, int currentPlayer) //create a method GameCore for the logic of the game STEP13
        {
            bool notValidMove = true; //new variable for do-while loop STEP 20.1
            do // if player makes a mistake, keep looping untill right selection STEP 20
            {
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) && //check if user enters a value that is not from 1 to 9 STEP 19
                    userInput == "1" ||//check if user input is a number between 1-9 STEP 14 
                    userInput == "2" ||//check all squares STEP 18
                    userInput == "3" ||
                    userInput == "4" ||
                    userInput == "5" ||
                    userInput == "6" ||
                    userInput == "7" ||
                    userInput == "8" ||
                    userInput == "9")
                {
                    Console.Clear();

                    int.TryParse(userInput, out var gamePlacementMarker); //convert user input to an int value STEP 15

                    char currentMarker = boardSquares[gamePlacementMarker - 1];

                    if (currentMarker == 'X' || currentMarker == 'O') //check if placement that the user made is x or o STEP 16
                    {
                        Console.WriteLine("Placement has already a marker, please choose another placement");
                    }
                    else
                    {
                        boardSquares[gamePlacementMarker - 1] = GetPlayerMarker(currentPlayer);
                        notValidMove = false; //STEP 20.2
                    }
                }
            }
            while (notValidMove); //STEP 20.3


        static char GetPlayerMarker(int player) //create new method GetPlayerMarker to see if it is player 1 or player 2 STEP 17
            {
                if (player % 2 == 0)
                {
                    return 'O';
                }
                else
                {
                    return 'X';
                }
            }
            
        }
    
    }

    
}