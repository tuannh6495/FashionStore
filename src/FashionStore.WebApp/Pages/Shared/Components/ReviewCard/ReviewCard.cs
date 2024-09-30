using FashionStore.Application.DTOs;
using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ReviewVC
{
    public class ReviewCard : ViewComponent
    {
        public IViewComponentResult Invoke(bool isDatePostShowed, ReviewDTO review)
        {
            ViewData["IsDatePostShowed"] = isDatePostShowed;
            return View(review);
        }
    }
}
