namespace ThreeLayer.Service.Dtos;

/// <summary>
/// 產品資訊
/// </summary>
public class ProductDto
{
    /// <summary>
    /// 產品編號
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// 產品名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 產品編號
    /// </summary>
    public string ProductNumber { get; set; }

    /// <summary>
    /// 產品顏色
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// 產品成本
    /// </summary>
    public double StandardCost { get; set; }

    /// <summary>
    /// 產品售價
    /// </summary>
    public double ListPrice { get; set; }

    /// <summary>
    /// 產品尺寸
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// 產品重量
    /// </summary>
    public string Weight { get; set; }

    /// <summary>
    /// 產品類別編號
    /// </summary>
    public int? ProductCategoryId { get; set; }

    /// <summary>
    /// 產品型號編號
    /// </summary>
    public int? ProductModelId { get; set; }

    /// <summary>
    /// 產品開始販售日期
    /// </summary>
    public DateTime SellStartDate { get; set; }

    /// <summary>
    /// 產品結束販售日期
    /// </summary>
    public DateTime? SellEndDate { get; set; }

    /// <summary>
    /// 產品停售日期
    /// </summary>
    public string DiscontinuedDate { get; set; }

    /// <summary>
    /// 產品縮圖
    /// </summary>
    public byte[] ThumbNailPhoto { get; set; }

    /// <summary>
    /// 產品縮圖檔名
    /// </summary>
    public string ThumbnailPhotoFileName { get; set; }

    /// <summary>
    /// 產品唯一識別碼
    /// </summary>
    public DateTime ModifiedDate { get; set; }
}
