using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class DressStyle : BaseEntity
	{
		public string Name { get; set; }

		public ICollection<DressStyleP>? DressStylePs { get; set; }

		public DressStyle(string name) 
		{
			Name = name;
		}
	}
}
