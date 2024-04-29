namespace TrainTheLanguage.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int Progress { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public DateTime? NextReview { get; set; }

        public Card()
        {

        }

    }
}
