using System;

namespace Game{
    class TicTacToe{
        public static void Main(String[] args){
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("Would you like to play?(Type yes or no)");
            string answer = Console.ReadLine();

            while(answer.Equals("yes")){
                TicTacToe game = new TicTacToe();
                //game.play();
                Console.WriteLine("Would you like to play?(Type yes or no)");
                answer = Console.ReadLine();
            }
        }

        
    }
}