using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower{
    public class Program{
        public static void Main(string[] args){
            Random random = new Random();
            int randomNumber = random.Next(1,100);
            int guess = 10;
            while(guess > 0){
                Console.Write("Geuss a number between 1 and 100: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if(userGuess == randomNumber){
                    Console.WriteLine("You guessed correctly!");
                    break;
                }else if(userGuess > randomNumber){
                    Console.WriteLine("Your guess was too high");
                }else{
                    Console.WriteLine("Your guess was too low");
                }
                guess--;
            }
        }
    }
}