public class Card {
    private int card;

    public Card(){
        // Random randomCard = new Random();
        // this.card = randomCard.Next(1, 14);
    }

    public int drawCard(){
        Random randomCard = new Random();
        this.card = randomCard.Next(1, 14);
        return this.card;
    }
}