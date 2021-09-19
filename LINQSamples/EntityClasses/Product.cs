using System.Text;

namespace LINQSamples
{
  public partial class Product
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }

    // Calculated Properties
    public int? NameLength { get; set; }
    public decimal? TotalSales { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder(1024);

      sb.Append(Name);
      sb.AppendLine($"  ID: {ProductID}");
      sb.Append($"   Color: {Color}");
      sb.AppendLine($"   Size: {(Size ?? "n/a")}");
      sb.Append($"   Cost: {StandardCost:c}");
      sb.AppendLine($"   Price: {ListPrice:c}");
      if (NameLength.HasValue) {
        sb.AppendLine($"   Name Length: {NameLength}");
      }
      if (TotalSales.HasValue) {
        sb.AppendLine($"   Total Sales: {TotalSales:c}");
      }
      return sb.ToString();
    }
    #endregion
  }
}
