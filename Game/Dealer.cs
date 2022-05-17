public class Dealer {
    public int points = 300;
    public bool continuePlay = true;
    Card card1 = new Card();
    Card card2 = new Card();
    

    public Dealer(){


    }

// start and runs the game as long as "continuePlay" is true.
    public void dealGame(){
        //set variable outside so we can reassign for the next round
        int firstCard = card1.drawCard();

        //run everything while they want to keep playing
        while(continuePlay == true){
            int nextCard = card2.drawCard();
            Console.WriteLine($"\nThe card is: {firstCard}");
            userGuess(firstCard, nextCard);
            Console.WriteLine($"The next card was: {nextCard} \nYour score is: {points}");
            playAgain();
            firstCard = nextCard;
        }
    }
    
    // Takes input from the user if they guess higher or lower. then passes that information into awardPoints
    public void userGuess(int card1, int card2){
        
        Console.Write("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        // Console.WriteLine($"this is my guess{guess}");
        points = awardPoints(guess, points, card1, card2);
        
    }

//takes other variables and decides how many points to award
    public int awardPoints(string guess, int points, int card1, int card2){
        if(guess == "l" && card2 < card1){
            points += 100;                                  
            
        } else if (guess == "l" && card2 > card1){
            points = points - 75;

        } else if (guess == "h" && card2 > card1) {
            points += 100;
            
        } else if (guess == "h" && card2 < card1){
            points = points -75;
        }
        return points; 
    }
           
//asks user if they want to play again and assings that to continuePlay
    public void playAgain(){
        Console.Write("Play again? [y/n] ");
        string play = Console.ReadLine();
        continuePlay = (play == "y");
    }
    
}