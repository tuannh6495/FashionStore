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
        public List<string> ImageUrls { get; set; }
        public string GetImageByType(string imageType)
        {
            if (ImageUrls != null && ImageUrls.Count > 0)
            {
                var imageUrl = ImageUrls.FirstOrDefault(url =>
                    string.Equals(Path.GetFileNameWithoutExtension(url), imageType, StringComparison.OrdinalIgnoreCase));

                return imageUrl ?? ImageUrls[0];
            }
            return string.Empty;
        }
        public string ProductName { get; set; }
        public string ColorName { get; set; }  
        public string SizeName { get; set; }    
        public int Quantity { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }
        public double TotalPrice { get; set; }
    }
}
