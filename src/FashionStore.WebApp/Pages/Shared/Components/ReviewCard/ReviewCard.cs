using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ReviewVC
{
    public class ReviewCard : ViewComponent
    {
        public IViewComponentResult Invoke(Review review)
        {
            return View(review);
        }
    }
}
