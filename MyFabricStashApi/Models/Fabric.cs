using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFabricStashApi.Models
{
	public class Fabric
	{
		public int Id { get; set; }

		// Main Details
		public string Name { get; set; }
		public long? MainCategoryId { get; set; }
		public virtual MainCategory MainCategory { get; set; }
		public long? SubCategoryId { get; set; }
		public virtual SubCategory SubCategory { get; set; }
		public string? Location { get; set; }
		public string? ImageFilePath { get; set; }
		public string? Description { get; set; }
		public bool IsActive { get; set; }

		// Amount
		public long? TotalLengthInches { get; set; }
		public long? FatQtrQty { get; set; }
		public long? TotalWidthInches { get; set; }

		// Design
		public string? BackgroundColor { get; set; }
		public string? AccentColor { get; set; }
		public string? DesignType { get; set; } //Stripe, floral, solid, etc.

		// Material
		public string? FabricType { get; set; } // Fleece, Knit, Silk, Woven
		public string? FabricWeight { get; set; } // Light, Medium, Heavy
		public string? FabricContent { get; set; } // Cotton, Polyester, Silk, etc.



		// Source
		public string? SourceName { get; set; }
		public string? SourceWebsite { get; set; }
		public DateTime? AcquiredDate { get; set; }
		public DateTime? ReleaseDate { get; set; }
		public long? InitialPurchaseInches { get; set; }
		public double? InitialPurchaseAmountPaid { get; set; }
		public string? Brand { get; set; }
		public string? Designer { get; set; }
		public string? Collection { get; set; }


		// Misc
		public string? Notes { get; set; }

	}
}
