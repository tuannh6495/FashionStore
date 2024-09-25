﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Color : BaseEntity
	{
		public string Name { get; set; }

		public ICollection<ColorP>? ColorPs { get; set; } 

		public Color(string name)
		{
			Name = name;
		}
	}
}
