using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashApi.Models
{
	public class SubCategory
	{
		public long Id { get; set; }
		public string SubCategoryName { get; set; }
		public long MainCategoryId { get; set; }
		public virtual MainCategory MainCategory { get; set; }
		public bool IsDeleted { get; set; }
	}
}
