﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ScaffoldingTester.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    /// <summary>
    /// Obsolete
    /// </summary>
    public string Description { get; set; }

    public byte[] Image { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}