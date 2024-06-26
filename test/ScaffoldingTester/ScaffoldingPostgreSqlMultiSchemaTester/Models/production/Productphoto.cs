﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.dboSchema;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.HumanResourcesSchema;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.PersonSchema;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.ProductionSchema;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.PurchasingSchema;
using ScaffoldingPostgreSqlMultiSchemaTester.Models.SalesSchema;


namespace ScaffoldingPostgreSqlMultiSchemaTester.Models.ProductionSchema
{
    /// <summary>
    /// Product images.
    /// </summary>
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }

        /// <summary>
        /// Primary key for ProductPhoto records.
        /// </summary>
        public int ProductPhotoId { get; set; }
        /// <summary>
        /// Small image of the product.
        /// </summary>
        public byte[] ThumbNailPhoto { get; set; }
        /// <summary>
        /// Small image file name.
        /// </summary>
        public string ThumbnailPhotoFileName { get; set; }
        /// <summary>
        /// Large image of the product.
        /// </summary>
        public byte[] LargePhoto { get; set; }
        /// <summary>
        /// Large image file name.
        /// </summary>
        public string LargePhotoFileName { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }
    }
}