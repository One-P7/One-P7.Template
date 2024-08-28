﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ThreeLayer.Database.AdventureWorks.Models;

/// <summary>
/// Cross-reference table mapping product descriptions and the language the description is written in.
/// </summary>
public partial class ProductModelProductDescriptionCulture
{
    /// <summary>
    /// Primary key. Foreign key to ProductModel.ProductModelID.
    /// </summary>
    public int ProductModelId { get; set; }

    /// <summary>
    /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
    /// </summary>
    public int ProductDescriptionId { get; set; }

    /// <summary>
    /// Culture identification number. Foreign key to Culture.CultureID.
    /// </summary>
    public string CultureId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual Culture Culture { get; set; }

    public virtual ProductDescription ProductDescription { get; set; }

    public virtual ProductModel ProductModel { get; set; }
}