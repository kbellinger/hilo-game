public class Points{
    //  public int points = 300;

// Awards points based on if they were correct in their guess or not and reassings point value to the variable "points"

    public Points(){

    }
    public void awardPoints(string guess, int points, int card1, int card2){
        if(guess == "l"){

            if(card2 < card1) {
                points += 100;
            } else if (card2 > card1) {
                points = points - 75;
            };

        } else if (guess == "h") {

            if (card2 > card1) {
                points += 100;
            } else if (card2 < card1) {
                points = points - 75;
            }
        } 
    }

    public string endGame(int points){
        if(points == 0){
            return;
        }
    }
        


}