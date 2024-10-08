using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class CartPDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }  
        public string SizeName { get; set; }    
        public int Quantity { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }   
        public double TotalPrice { get; set; }
    }
}
