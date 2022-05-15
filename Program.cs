// See https://aka.ms/new-console-template for more information
public class Program {
    static void Main(){
        // Card card1 = new Card();
        // Card card2 = new Card();


        // int firstCard = card1.drawCard();
        // int secondCard = card2.drawCard();
        // Console.WriteLine($"The card is: {firstCard} Next card was: {secondCard}");
        Dealer dealer = new Dealer();
        dealer.dealGame();
    }
}
