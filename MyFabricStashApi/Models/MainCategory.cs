using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashApi.Models
{
	public class MainCategory
	{
		public long Id { get; set; }
		public string MainCategoryName { get; set; }
		[NotMapped]
		public int FabricId { get; set; }
		[NotMapped]
		public int SubCategoryId { get; set; }
		public List<SubCategory> SubCategories { get; set; }
		public bool IsDeleted { get; set; }
	}
}
