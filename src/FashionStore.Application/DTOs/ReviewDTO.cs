using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class ReviewDTO
    {
        public decimal ReviewRating { get; set; }
        public string FullNameCustomer { get; set; }
        public string? Comment { get; set; }
        public DateTime DatePost { get; set; }
    }
}
