using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Outstanding : BaseEntity
	{
		public string Name { get; set; }

		public ICollection<OutP> OutPs { get; set; }
	}
}
