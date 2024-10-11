using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Product : BaseEntity
	{
        public List<string> ImageUrls { get; set; }
		public string MainImageUrl
		{
			get
			{
				if (ImageUrls != null && ImageUrls.Count > 0)
				{
					var foreImage = ImageUrls.FirstOrDefault(url =>
						string.Equals(Path.GetFileNameWithoutExtension(url), "fore", StringComparison.OrdinalIgnoreCase));
					return foreImage ?? ImageUrls[0];
				}
				return string.Empty;
			}
		}
		public string Name { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; } 
		public string ?Description { get; set; }
		public decimal AvgRating { get; set; }
        public int Gender { get; set; } //Men-0, Women-1

        public int CategoryId { get; set; }
		public Category Category { get; set; }

		public int ?DiscountId { get; set; }
		public Discount Discount { get; set; }

		public ICollection<OutP> OutPs { get; set; }
		public ICollection<SizeP> SizePs { get; set; }
		public ICollection<ColorP> ColorPs { get; set; }
		public ICollection<CartP> CartPs { get; set; }
		public ICollection<Review> Reviews { get; set; }
		public ICollection<DressStyleP> DressStylePs { get; set; }

        public Product(List<string> imageUrls, string name)
        {
            ImageUrls = imageUrls;
            Name = name;
        }
    }
}
