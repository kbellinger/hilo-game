public class Dealer {
    public int points = 300;
    // public string guess = "";
    public bool continuePlay = true;
    Card card1 = new Card();
    Card card2 = new Card();
    

    public Dealer(){

        // Card card1 = new Card();
        // Card card2 = new Card();


        
    }

// start and runs the game as long as "continuePlay" is true.
    public void dealGame(){

        while(continuePlay == true){
            int firstCard = card1.drawCard();
            int nextCard = card2.drawCard();
            Console.WriteLine($"\nThe card is: {firstCard}");
            userGuess(firstCard, nextCard);
            Console.WriteLine($"The next card was: {nextCard} \nYour score is: {points}");
            playAgain();
            
        }
    }
    
    // Takes input from the user of if they guess higher or lower. then passes that information into awardPoints
    public void userGuess(int card1, int card2){
        
        Console.Write("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        // Console.WriteLine($"this is my guess{guess}");
        awardPoints(guess, points, card1, card2);
    }

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

            // if(card2 < card1) {
            //     points += 100;
            // } else if (card2 > card1) {
            //     points = points - 75;
            // };
            // if (card2 > card1) {
            //     points += 100;
            // } else if (card2 < card1) {
            //     points = points - 75;
            // }

    public void playAgain(){
        Console.Write("Play again? [y/n] ");
        string play = Console.ReadLine();
        continuePlay = (play == "y");
    }
    
}