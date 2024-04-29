using Microsoft.AspNetCore.Mvc;
using TrainTheLanguage.Models;

namespace TrainTheLanguage.Controllers
{
    public class CardController : Controller
    {
        public List<Card> cards = new List<Card>()
        {
            new Card() { Id = 1, Word = "badger", Definition = "to persuade someone by telling them repeatedly to do something, or to question someone repeatedly", Example = "Stop badgering me - I'll do it when I'm ready.", Progress = 0, NextReview = null},
            new Card() { Id = 2, Word = "pester", Definition = "to behave in an annoying manner towards someone by doing or asking for something repeatedly", Example = "John has been pestering her to go out with him all month.", Progress = 0, NextReview = null},
            new Card() { Id = 3, Word = "solicit", Definition = "to ask someone for money, information, or help", Example = "to solicit donations for a charity", Progress = 0, NextReview = null},
            new Card() { Id = 4, Word = "comprehend", Definition = "to understand something completely", Example = "He doesn't seem to comprehend the scale of the problem", Progress = 0, NextReview = null},
            new Card() { Id = 5, Word = "topple", Definition = "to (cause to) lose balance and fall down", Example = "The tree toppled and fell.", Progress = 0, NextReview = null},
            new Card() { Id = 6, Word = "oblique", Definition = "having a sloping direction, angle, or position", Example = "He gave her an oblique glance.", Progress = 0, NextReview = null},
            new Card() { Id = 9, Word = "taut", Definition = "tight or completely stretched", Example = "a taut rope", Progress = 0, NextReview = null}
        };
        public IActionResult Index()
        {
            return View(cards);
        }
    }

}
