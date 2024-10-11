﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
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
        public string Name { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }
        public int ?DiscountId { get; set; }
		public double DiscountValue { get; set; }
		public double DiscountedPrice
		{
			get
			{
				return Price - (Price * (DiscountValue) / 100);
			}
		}
		public string? Description { get; set; }
        public decimal AvgRating { get; set; }
        public List<string> ColorHexCodes { get; set; }
        public List<string> ColorNames { get; set; }
        public List<string> SizeNames { get; set; }
    }
}
