// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class RockPaperScissors
{
    public static void Main(string[] args)
    {
        while(true){
            string[] choices={"rock","paper","scissors"};
        string input=Console.ReadLine().ToLower();
        Console.WriteLine("your input is" + " " + input + "\n" );
        
         Random random = new Random();
        
        int randomIndex=random.Next(0,2);
        string computerschoice=choices[randomIndex];
        
        Console.WriteLine("computer chose" + " " + computerschoice + "\n");
        
       if(input !="rock" &&  input!="paper" && input!="scissors"){
           Console.WriteLine("your choice" + " " + input + " " + "is not valid" + "\n" + "please restart the game");
       }
       else{
            if(input == computerschoice){
            Console.WriteLine("you went on a draw");
        }
        else if(input == "scissors" && computerschoice == "rock"){
            Console.WriteLine("computer won!! Rock Smash Scissors");
        }
         else if(input == "scissors" && computerschoice == "paper"){
            Console.WriteLine("you won!! scissors cut paper");
        }
        else if(input == "rock" && computerschoice == "paper"){
            Console.WriteLine("you won!! Rock Smash paper");
        }
        else if(input == "paper" && computerschoice == "scissors"){
            Console.WriteLine("computer won!! scissors cut paper");
        }
        
         else if(input == "paper" && computerschoice == "rock"){
            Console.WriteLine("computer won!! rock smash paper");
        }
       }
           Console.WriteLine("Enter Y to restart game and N to quit");
    string restart=Console.ReadLine().ToLower();
    if(restart !="y"){
        break;
    };
    }
    

        }
}