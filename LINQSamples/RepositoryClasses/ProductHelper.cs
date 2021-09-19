using System.Collections.Generic;
using System.Linq;

namespace LINQSamples
{
  public static class ProductHelper
  {
    #region ByColor
    public static IEnumerable<Product> ByColor(this IEnumerable<Product> query, string color)
    {
      return query.Where(prod => prod.Color == color);
    }
    #endregion
  }
}
