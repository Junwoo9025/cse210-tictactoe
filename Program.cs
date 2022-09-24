// Tic-Tac-Toe, Junwoo Jeong
using System;

namespace cse210_01
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
           
        //array of string. array itself is list.                             
            string[] board = {"1","2","3","4","5","6","7","8","9"};
            DisplayBoard(board);    

            
           
           //declaration bool, declaration mean is that first time I create. 
           //in order to declare, I have to clarify data type!!!!.
            bool keepGoing = true;
            string player = "x";  
            //once you declare it you can just use it, keepgoing
            while(keepGoing)
            {
                int move = GetInput(player);
                //after you declare called getinput function
                // = assigning, == comparsion
                // update
                board[move -1] = player;
                if (CheckWinner(board) == true )
                {
                    keepGoing = false;
                    return;
                }
                //output
                DisplayBoard(board);
                if (player == "x")
                { 
                    player = "o";                  
                }
                
                else 
                { 
                    player = "x";                  
                }
                

                 
            }
            
        }
        // int after static is return type. Make sure returing int.
        // array list has to use []
        static int GetInput(string player){
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            int inPutX  = Convert.ToInt32 (Console.ReadLine());
                                            //it allows me to get the input from the terminal
                                            //ReadLine's return type is string.
            return inPutX; 
        }
       // Console.Readline and writeLine() they are function
        //The first player to get three of their marks in a row (vertically, horizontally, or diagonally) is the winmner.
        static bool CheckWinner(string[] board){
            // first column second, third  
            // two diagonally
            // same symbol
            // return true.
            //The first player to get three of their marks in a row (vertically, horizontally, or diagonally) is the winner.
            //If all nine squares are full and neither player has three in a row, the game ends in a draw.
        
            if ((board[0] == board[1] && board[0] == board[2]) ||
                (board[3] == board[4] && board[3] == board[5]) ||
                (board[6] == board[7] && board[6] == board[8]) ||
                (board[0] == board[3] && board[0] == board[6]) ||
                (board[1] == board[4] && board[1] == board[7]) ||
                (board[2] == board[5] && board[2] == board[8]) ||
                (board[0] == board[4] && board[0] == board[8]) ||
                (board[2] == board[4] && board[2] == board[6]))
                {
               Console.WriteLine("Good game. Thanks for playing!");
               return true;
               
                }
            else
            {
                return false;
            }
                
                
                 
                
            
            
        
        }

        static bool CheckBoardFilled(string[] board){
            for(int i=0; i<9;i++){
                if(board[i]!= "x"&& board[i]!="o"){
                    return(false);
                }
            }
            return(true);

        }
       
                            //define data type inside of parameter.
                            //inside parmeter1. datatype 2. variable name.
        static void DisplayBoard(string[] board){
           
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }
    }
    }
 
        